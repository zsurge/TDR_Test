using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TDR_Test.Driver;

namespace TDR_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        E5080B analyzer = new E5080B();
        LoggerHelper logger = new LoggerHelper();

        public const int SINGLE = 1;
        public const int DIFFERENCE = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化状态栏
            cts = new CancellationTokenSource();
            ShowTime();

            //初始化控件
            initControl();

            //初始化CHART
            initChart();
        }

        private void InvokeToForm(Action action)
        {
            try
            {
                this.Invoke(action);
            }
            catch { }
        }

        CancellationTokenSource cts;
        private void ShowTime()
        {
            Task.Factory.StartNew(() =>
            {
                string now;
                while (!cts.IsCancellationRequested)
                {
                    now = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                    InvokeToForm(() => this.localTime.Text = now);
                    Thread.Sleep(500);
                }
            });
        }

        /// <summary>
        /// 控件初始化
        /// </summary>
        private void initControl()
        {
            combCommand.SelectedIndex = 0;
            combDevType.SelectedIndex = 0;
            combTranType.SelectedIndex = 0;
        }


        private void initChart()
        {
            //chart1.Series.Clear();
            chart1.Series[0].LegendText = "测试曲线";
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;

            //背景黑色
            chart1.BackColor = Color.Black;
            chart1.ChartAreas[0].BackColor = Color.Black;

            //XY标签改为白色
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            //X，Y轴白色
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            
            //差分线条黄色
            chart1.Series[0].Color = Color.Yellow; //线条颜色

            //有效区域线红色
            chart1.Series[1].Color = Color.Red; //线条颜色
            chart1.Series[2].Color = Color.Red; //线条颜色

            //单端线条蓝色
            chart1.Series[3].Color = Color.Blue; //线条颜色

            //网格线颜色白色
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;            
        }



        private void EnableControl(bool enable)
        {
            combCommand.Enabled = enable;
            combDevString.Enabled = enable;
            combDevType.Enabled = enable;
            combTranType.Enabled = enable;
            listboxResult.Enabled = !enable;
            btnClear.Enabled = !enable;
            btnOpen.Enabled = !enable;
            btnRefresh.Enabled = !enable;
            btnSend.Enabled = !enable;
        }

        /// <summary>
        /// 读取CSV并生成
        /// </summary>
        /// <param name="filePath"></param> 
        /// <returns></returns>
        private List<float> ReaderFile(string filePath)
        {
            int i = 0;

            //读取文件的源路径及其读取流            
            StreamReader srReadFile = new StreamReader(filePath, Encoding.Default);
            List<float> result = new List<float>();  //数据

            //读取流直至文件末尾结束
            while (!srReadFile.EndOfStream)
            {
                string str = srReadFile.ReadLine().Replace("\0", "");

                if (i++ > 317 && str != "")
                {
                    float tmpData = Convert.ToSingle(str);
                    if (tmpData <= 200.0)
                    {
                        result.Add(tmpData);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            srReadFile.Close();

            return result;
        }

        private void CreateChart(string filePath)
        {
            //读取文件获取数据数据
            List<float> result = ReaderFile(filePath);

            //计算有效区域起始结束位置
            float offsetValue = Convert.ToSingle(30) / 2 / 100;
            float xbegin = result.Count * offsetValue;
            float xend = result.Count * (1 - offsetValue);

            //获取有效区域的LIST
            List<float> tmpResult = result.Skip((int)xbegin).Take((int)(result.Count - xend)).ToList();

            //设置网格间距
            chart1.ChartAreas[0].AxisX.Interval = (float)result.Count / 10;//X轴间距
            chart1.ChartAreas[0].AxisY.Interval = 50;//Y轴间距.
            //设置Y坐标最大值
            chart1.ChartAreas[0].AxisY.Maximum = 200;

            //求最大值及最小值
            chart1.Series[0].LegendText = "平均值：" + tmpResult.Average().ToString();
            chart1.Series[1].LegendText = "最大值:" + tmpResult.Max().ToString();
            chart1.Series[2].LegendText = "最小值:" + tmpResult.Min().ToString();

            //生成测试数据曲线
            for (int i = 0; i < result.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, result[i]);
            }

            //生成上半位有效区域
            chart1.Series[1].Points.AddXY(xbegin, 200);
            chart1.Series[1].Points.AddXY(xbegin, 115);
            chart1.Series[1].Points.AddXY(xend, 115);
            chart1.Series[1].Points.AddXY(xend, 200);

            //生成下半部有效区域
            chart1.Series[2].Points.AddXY(xbegin, 0);
            chart1.Series[2].Points.AddXY(xbegin, 85);
            chart1.Series[2].Points.AddXY(xend, 85);
            chart1.Series[2].Points.AddXY(xend, 0);
        }

        /// <summary>
        /// 创建量测时的图表
        /// </summary>
        /// <param name="measData"></param>
        private void CreateMeasChart(List<float> measData,int channel)
        {
            float xbegin = 0;
            float xend = 0;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //计算有效区域起始结束位置 
            if (channel == SINGLE)
            {                
                xbegin = measData.Count * Convert.ToSingle(txSingleBegin.Text)/100;
                xend = measData.Count * Convert.ToSingle(txSingleEnd.Text)/100;

                chart1.ChartAreas[0].AxisY.Interval = 25;//Y轴间距
                chart1.ChartAreas[0].AxisY.Maximum = 125;//设置Y坐标最大值
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                //生成上半位有效区域
                chart1.Series[1].Points.AddXY(xbegin, 100);
                chart1.Series[1].Points.AddXY(xbegin, 56);
                chart1.Series[1].Points.AddXY(xend, 56);
                chart1.Series[1].Points.AddXY(xend, 100);

                //生成下半部有效区域
                chart1.Series[2].Points.AddXY(xbegin, 0);
                chart1.Series[2].Points.AddXY(xbegin, 44);
                chart1.Series[2].Points.AddXY(xend, 44);
                chart1.Series[2].Points.AddXY(xend, 0);


            }
            else
            {
                xbegin = measData.Count * Convert.ToSingle(txDiffBegin.Text) / 100;
                xend = measData.Count * Convert.ToSingle(txDiffEnd.Text) / 100;

                chart1.ChartAreas[0].AxisY.Interval = 50;//Y轴间距
                chart1.ChartAreas[0].AxisY.Maximum = 250;//设置Y坐标最大值
                chart1.ChartAreas[0].AxisY.Minimum = 0;

                //生成上半位有效区域
                chart1.Series[1].Points.AddXY(xbegin, 200);
                chart1.Series[1].Points.AddXY(xbegin, 115);
                chart1.Series[1].Points.AddXY(xend, 115);
                chart1.Series[1].Points.AddXY(xend, 200);

                //生成下半部有效区域
                chart1.Series[2].Points.AddXY(xbegin, 0);
                chart1.Series[2].Points.AddXY(xbegin, 85);
                chart1.Series[2].Points.AddXY(xend, 85);
                chart1.Series[2].Points.AddXY(xend, 0);

            }
            //获取有效区域的LIST
            List<float> tmpResult = measData.Skip((int)xbegin).Take((int)(measData.Count - xend)).ToList();

            //求最大值及最小值
            if (tmpResult.Count != 0)
            {
                //设置网格间距
                chart1.ChartAreas[0].AxisX.Interval = (float)measData.Count / 10;//X轴间距
                chart1.ChartAreas[0].AxisX.Maximum = (float)measData.Count; //设置X坐标最大值
                chart1.ChartAreas[0].AxisX.Minimum = 0;//设置X坐标最小值

                chart1.Series[0].LegendText = "平均值：" + tmpResult.Average().ToString();
                chart1.Series[1].LegendText = "最大值:" + tmpResult.Max().ToString();
                chart1.Series[2].LegendText = "最小值:" + tmpResult.Min().ToString();


            }
            else
            {
                //设置默认网格间距
                chart1.ChartAreas[0].AxisX.Interval = 250;//X轴间距
                chart1.ChartAreas[0].AxisX.Maximum = 2500; //设置X坐标最大值
                chart1.ChartAreas[0].AxisX.Minimum = 0;//设置X坐标最小值

                chart1.ChartAreas[0].AxisY.Interval = 25;//Y轴间距
                chart1.ChartAreas[0].AxisY.Maximum = 250;//设置Y坐标最大值
                chart1.ChartAreas[0].AxisY.Minimum = 0;
            }

            //生成测试数据曲线
            for (int i = 0; i < measData.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, measData[i]);
            }
        }



        /// <summary>
        /// 开路定义时，显示的图表
        /// </summary>
        /// <param name="measDiffData">差分开路数据</param>
        /// <param name="measSingleData">单端开路数据</param>
        private void CreateInitMeasChart(List<float> measDiffData,List<float>measSingleData)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //求最大值及最小值
            if (measDiffData.Count != 0 && measSingleData.Count != 0) 
            {
                
                //设置网格间距
                chart1.ChartAreas[0].AxisX.Interval = (float)measDiffData.Count / 10;//X轴间距
                chart1.ChartAreas[0].AxisX.Maximum = (float)measDiffData.Count; //设置X坐标最大值
                chart1.ChartAreas[0].AxisX.Minimum = 0;//设置X坐标最小值

                chart1.ChartAreas[0].AxisY.Interval = 25;//Y轴间距
                chart1.ChartAreas[0].AxisY.Maximum = 250;//设置Y坐标最大值
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;

                //设置几条线的文字为空
                chart1.Series[0].LegendText = "diff";
                chart1.Series[1].LegendText = "limit";
                chart1.Series[2].LegendText = "limit";
                chart1.Series[3].LegendText = "single";
            }
            else
            {
                //设置默认网格间距
                chart1.ChartAreas[0].AxisX.Interval = 250;//X轴间距
                chart1.ChartAreas[0].AxisX.Maximum = 2500; //设置X坐标最大值
                chart1.ChartAreas[0].AxisX.Minimum = 0;//设置X坐标最小值

                chart1.ChartAreas[0].AxisY.Interval = 25;//Y轴间距
                chart1.ChartAreas[0].AxisY.Maximum = 250;//设置Y坐标最大值
                chart1.ChartAreas[0].AxisY.Minimum = 0;
            }

            //生成测试数据曲线
            for (int i = 0; i < measDiffData.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, measDiffData[i]);
            }

            for (int i = 0; i < measSingleData.Count; i++)
            {
                chart1.Series[3].Points.AddXY(i, measSingleData[i]);
            }
        }


        private void CreateReport()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel(*.csv)|*.csv";
            openFile.InitialDirectory = Environment.CurrentDirectory;
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            var filePath = openFile.FileName;
            string fileType = System.IO.Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(fileType))
                return;

            CreateChart(filePath);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //这里先判定是否已做开路，若已坐开路，则只打开设备，若没有做开路，则做开路设定
            if (GetIndex.isOpen)
            {
                //表示已经开路定义过，只需要打开窗口即可
                int error = analyzer.Open(combDevString.Text);
                string idn = string.Empty;
                error = analyzer.GetInstrumentIdentifier(out idn);
                SetRecvListSafe(idn);

                string cmd2 = "FORM:DATA ASCII";
                analyzer.ExecuteCmd(cmd2);

                string cmd3 = "MMEM:STOR:TRAC:FORM:SNP MA";
                analyzer.ExecuteCmd(cmd3);
                //logger.Debug("open dev");
            }
            else
            {
                //表示没有开路定义
                int error = analyzer.Open(combDevString.Text);
                string idn = string.Empty;
                error = analyzer.GetInstrumentIdentifier(out idn);
                SetRecvListSafe(idn);

                string cmd2 = "FORM:DATA ASCII";
                analyzer.ExecuteCmd(cmd2);

                string cmd3 = "MMEM:STOR:TRAC:FORM:SNP MA";
                analyzer.ExecuteCmd(cmd3);
                //logger.Debug("open dev and get index value");

                //开路定义
                GetDevInitIndexValue();
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            analyzer.ExecuteCmd(combCommand.SelectedItem.ToString());
        }

        /// <summary>
        /// 
        ///发送指令并且读取返回值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendAndRead_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            analyzer.QueryCommand(combCommand.SelectedItem.ToString(),out result);
            SetRecvListSafe(result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {    
            analyzer.viClear();
            analyzer.viClose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            analyzer.viClose();
        }

        delegate void SetRecvListSafeCallback(string text);
        public void SetRecvListSafe(string text)
        {
            if (this.listboxResult.InvokeRequired)
            {
                SetRecvListSafeCallback d = new SetRecvListSafeCallback(SetRecvListSafe);
                this.Invoke(d, new object[] { text });
            }
            else
            {                
                this.listboxResult.Items.Add(text);
                this.listboxResult.TopIndex = listboxResult.Items.Count - 1;
            }
        }


        /// <summary>
        /// 获取开路的索引值
        /// </summary>
        private void GetDevInitIndexValue()
        {
            List<float> tmpDiffMeasData = new List<float>();
            List<float> tmpSingleMeasData = new List<float>();
            string result = string.Empty;           
            string cmd4 = "CALCulate:PARameter:CAT?";
            analyzer.QueryCommand(cmd4, out result,256);
            SetRecvListSafe(result);
            result = string.Empty;

            string cmd5 = ":CALCulate1:TRANsform:TIME:STARt -5E-10";
            analyzer.ExecuteCmd(cmd5);

            string cmd6 = ":CALCulate1:TRANsform:TIME:STOP 9.5E-9";
            analyzer.ExecuteCmd(cmd6);

            string cmd7 = ":SENSe1:SWEep:POINts?";            
            analyzer.QueryCommand(cmd7, out result, 256);
            SetRecvListSafe(result);
            result = string.Empty;

            string cmd8 = ":CALCulate1:TRANsform:TIME:STARt?";
            analyzer.QueryCommand(cmd8, out result, 256);
            SetRecvListSafe(result);
            result = string.Empty;

            string cmd9 = ":CALCulate1:TRANsform:TIME:STOP?";
            analyzer.QueryCommand(cmd9, out result, 256);
            SetRecvListSafe(result);
            result = string.Empty;

            string cmd10 = ":INITiate1:CONTinuous ON";
            analyzer.ExecuteCmd(cmd10);

            string cmd11 = ":CALC:PAR:SEL \"win1_tr2\"";
            analyzer.ExecuteCmd(cmd11);
            analyzer.viClear();

            string cmd12 = ":CALCulate1:DATA? FDATa";
            analyzer.QueryCommand(cmd12, out result, 200000);
            tmpSingleMeasData = packetMaesData(result, 0, 0);
            string[] tdd22_array = result.Split(new char[] { ',' });
            result = string.Empty;

            //查找tdd22单端的索引值
            for (int i = 0; i < tdd22_array.Length; i++)
            {
                //logger.Trace(tdd22_array[i]);
                if (Convert.ToSingle(tdd22_array[i]) >= Convert.ToSingle(txSingleIndex.Text))
                {
                    logger.Debug((i-1).ToString() + " = " + tdd22_array[i-1]);
                    GetIndex.tdd22IndexValue = i - 1;
                    break;
                }
            }


            string cmd13 = ":CALC:PAR:SEL \"win1_tr1\"";
            analyzer.ExecuteCmd(cmd13);
            analyzer.viClear();

            string cmd14 = ":CALCulate1:DATA? FDATa";
            analyzer.QueryCommand(cmd14, out result, 200000);
            tmpDiffMeasData = packetMaesData(result, 0, 0);
            string[] tdd11_array = result.Split(new char[] { ',' });

            //查找tdd11差分的索引值
            for (int i = 0; i < tdd11_array.Length; i++)
            {
                //logger.Info(tdd11_array[i]);
                if (Convert.ToSingle(tdd11_array[i]) >= Convert.ToSingle(txIndex.Text))
                {
                    logger.Debug((i-1).ToString() + " = " + tdd11_array[i-1]);
                    GetIndex.tdd11IndexValue = i-1;
                    break;
                }
            }   
            
            result = string.Empty;
            GetIndex.isOpen = true;

            CreateInitMeasChart(tmpDiffMeasData, tmpSingleMeasData);
        }

      
        private void startMeasuration(int channel)
        {
            string result = string.Empty;
            int index = 0;
            string cmd1, cmd2, cmd3, cmd4, cmd5, cmd6;

            if (channel == SINGLE)
            {
                index = GetIndex.tdd22IndexValue;
                cmd1 = ":CALC:PAR:SEL \"win1_tr2\"";
            }
            else
            {
                index = GetIndex.tdd11IndexValue;
                cmd1 = ":CALC:PAR:SEL \"win1_tr1\"";
            }
            analyzer.ExecuteCmd(cmd1);

            cmd2 = ":CALCulate1:TRANsform:TIME:STARt?";
            analyzer.QueryCommand(cmd2, out result, 256);
            SetRecvListSafe(result);
            result = string.Empty;

            cmd3 = "DISPlay:ENABle ON";
            analyzer.ExecuteCmd(cmd3);
            
            analyzer.ExecuteCmd(cmd1);

            cmd5 = ":INITiate1:CONTinuous ON";
            analyzer.ExecuteCmd(cmd5);
            analyzer.viClear();

            cmd6 = ":CALCulate1:DATA? FDATa";
            analyzer.QueryCommand(cmd6, out result, 200000);

            //获取要生成报表的数据
            CreateMeasChart(packetMaesData(result,index, channel), channel);

            result = string.Empty;    
            analyzer.QueryErrorStatus(out result);
        }

        private List<float> packetMaesData(string measBuff,int index,int mode)
        {
            List<float> result = new List<float>();
            string[] tmpArray = measBuff.Split(new char[] { ',' });
            float tmp = 0;
            int i = 0;


           if (mode == 1) //单端模式
            {                
                for (i = index; i < tmpArray.Length; i++)
                {
                    logger.Info(tmpArray[i]);
                }

                for (i = index; i < tmpArray.Length; i++)
                {
                    tmp = Convert.ToSingle(tmpArray[i]);                    
                    if (tmp < Convert.ToSingle(txSingleIndex.Text))
                    {
                        logger.Error(tmpArray[i]);
                        result.Add(tmp);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (mode == 2)//差分模式
            { 
                for (i = index; i < tmpArray.Length; i++)
                {
                
                    tmp = Convert.ToSingle(tmpArray[i]);
                    if (tmp < Convert.ToSingle(txIndex.Text))
                    {
                        result.Add(tmp);
                    }
                    else
                    {
                        break;
                    }
                }
            }
           else
            {
                logger.Trace("-----init start-------");
                //开路定义模式，返回所有数据
                for (i = 0; i < tmpArray.Length; i++)
                {
                    logger.Trace(tmpArray[i]);
                    tmp = Convert.ToSingle(tmpArray[i]);
                    result.Add(tmp);
                }
                
            }     

            return result;
        }

        private void btnMeas_Click(object sender, EventArgs e)
        {
            //这里需要分单端测试和差分测试
            if (radioSingle.Checked)
            {
                //这里是单端测试
                startMeasuration(SINGLE);
            }
            else if (radioDiff.Checked)
            {
                //这里是差分测试
                startMeasuration(DIFFERENCE);
            }
            else
            {
                MessageBox.Show("please select test mode");
            }
        }

        private void radioSingle_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBox10.Enabled = true;
            groupBox11.Enabled = true;
        }

        private void radioDiff_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = true;
            groupBox7.Enabled = true;
            groupBox10.Enabled = false;
            groupBox11.Enabled = false;
        }

        private void radio_single_units_ohm_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_single_units_ohm.Checked)
            {
                lable_diff_units_value.Text = "欧姆";
                lable_diff_units_max.Text = "欧姆";
                lable_diff_units_main.Text = "欧姆";

                txDiffMax.Text = ((Convert.ToSingle(txDiffMax.Text) / 100 + 1) * Convert.ToSingle(txDiffTargetValue.Text)).ToString();
                txDiffMin.Text = ((Convert.ToSingle(txDiffMin.Text) / 100 + 1) * Convert.ToSingle(txDiffTargetValue.Text)).ToString();
            }
        }

        private void radio_single_units_percent_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_single_units_percent.Checked)
            {
                lable_diff_units_value.Text = "%";
                lable_diff_units_max.Text = "%";
                lable_diff_units_main.Text = "%";
                txDiffMax.Text = ((Convert.ToSingle(txDiffMax.Text) / Convert.ToSingle(txDiffTargetValue.Text) - 1) * 100).ToString();
                txDiffMin.Text = ((Convert.ToSingle(txDiffMin.Text) / Convert.ToSingle(txDiffTargetValue.Text) - 1) * 100).ToString();
            }
        }

        private void radio_diff_units_percent_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_diff_units_percent.Checked)
            {
                lable_single_units_value.Text = "%";
                lable_single_units_max.Text = "%";
                lable_single_units_min.Text = "%";
                txSingleMax.Text = ((Convert.ToSingle(txSingleMax.Text) / Convert.ToSingle(txSingleTargetValue.Text) - 1) * 100).ToString();
                txSingleMin.Text = ((Convert.ToSingle(txSingleMin.Text) / Convert.ToSingle(txSingleTargetValue.Text) - 1) * 100).ToString();
            }
        }

        private void radio_deff_units_ohm_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_deff_units_ohm.Checked)
            {
                lable_single_units_value.Text = "欧姆";
                lable_single_units_max.Text = "欧姆";
                lable_single_units_min.Text = "欧姆";

                txSingleMax.Text = ((Convert.ToSingle(txSingleMax.Text) / 100 + 1) * Convert.ToSingle(txSingleTargetValue.Text)).ToString();
                txSingleMin.Text = ((Convert.ToSingle(txSingleMin.Text) / 100 + 1) * Convert.ToSingle(txSingleTargetValue.Text)).ToString();
            }
        }
    }//end form class

    public static class GetIndex
    {
        //这里来定义是否已经开路，并记录下开路的值
        private static bool isopen = false;
        private static int tdd1indexvalue = 0;
        private static int tdd2Indexvalue = 0;
        public static bool isOpen
        {
            get { return isopen; }
            set { isopen = value; }
        }
        public static int tdd11IndexValue
        {
            get { return tdd1indexvalue; }
            set { tdd1indexvalue = value; }
        }
        public static int tdd22IndexValue
        {
            get { return tdd2Indexvalue; }
            set { tdd2Indexvalue = value; }
        }
    }
}
