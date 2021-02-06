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

            //背景灰色
            chart1.BackColor = Color.Gray;
            chart1.ChartAreas[0].BackColor = Color.Gray;
            //X，Y轴黑色
            chart1.ChartAreas[0].AxisX.LineColor = Color.Black;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
            //线条黄色
            chart1.Series[0].Color = Color.Yellow; //线条颜色
            chart1.Series[1].Color = Color.Red; //线条颜色
            chart1.Series[2].Color = Color.Red; //线条颜色

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

            //获取有区域的LIST
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //int error = analyzer.Open(combDevString.Text);
            //string idn;
            //error = analyzer.GetInstrumentIdentifier(out idn);
            //error = analyzer.ClearAllErrorQueue();
            //error = analyzer.Preset();

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
    }//end form class

    public static class common
    {
        private static bool isopen = false;
        public static bool isOpen
        {
            get { return isopen; }
            set { isopen = value; }
        }
    }
}
