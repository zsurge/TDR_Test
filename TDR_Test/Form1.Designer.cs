namespace TDR_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.combUnit = new System.Windows.Forms.ComboBox();
            this.txMin = new System.Windows.Forms.TextBox();
            this.txMax = new System.Windows.Forms.TextBox();
            this.txTargetValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txOffset = new System.Windows.Forms.TextBox();
            this.txIndex = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioDiff = new System.Windows.Forms.RadioButton();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.btnSendAndRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txTimeOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combCommand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combDevString = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combDevType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combTranType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listboxResult = new System.Windows.Forms.ListBox();
            this.localStatusStrip = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.localIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.localTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.localStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnSendAndRead);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txTimeOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combCommand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(754, 49);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "量测";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.combUnit);
            this.groupBox7.Controls.Add(this.txMin);
            this.groupBox7.Controls.Add(this.txMax);
            this.groupBox7.Controls.Add(this.txTargetValue);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(1047, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 66);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "测量范围";
            // 
            // combUnit
            // 
            this.combUnit.FormattingEnabled = true;
            this.combUnit.Items.AddRange(new object[] {
            "欧姆",
            "%"});
            this.combUnit.Location = new System.Drawing.Point(85, 13);
            this.combUnit.Name = "combUnit";
            this.combUnit.Size = new System.Drawing.Size(79, 20);
            this.combUnit.TabIndex = 11;
            // 
            // txMin
            // 
            this.txMin.Location = new System.Drawing.Point(123, 42);
            this.txMin.Name = "txMin";
            this.txMin.Size = new System.Drawing.Size(41, 21);
            this.txMin.TabIndex = 10;
            // 
            // txMax
            // 
            this.txMax.Location = new System.Drawing.Point(36, 42);
            this.txMax.Name = "txMax";
            this.txMax.Size = new System.Drawing.Size(41, 21);
            this.txMax.TabIndex = 9;
            // 
            // txTargetValue
            // 
            this.txTargetValue.Location = new System.Drawing.Point(36, 16);
            this.txTargetValue.Name = "txTargetValue";
            this.txTargetValue.Size = new System.Drawing.Size(41, 21);
            this.txTargetValue.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "下限:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "上限:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "阻抗:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txOffset);
            this.groupBox6.Controls.Add(this.txIndex);
            this.groupBox6.Location = new System.Drawing.Point(909, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(132, 66);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "X轴量测试范围";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "偏移量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "开路位置:";
            // 
            // txOffset
            // 
            this.txOffset.Location = new System.Drawing.Point(66, 38);
            this.txOffset.Name = "txOffset";
            this.txOffset.Size = new System.Drawing.Size(62, 21);
            this.txOffset.TabIndex = 1;
            // 
            // txIndex
            // 
            this.txIndex.Location = new System.Drawing.Point(66, 15);
            this.txIndex.Name = "txIndex";
            this.txIndex.Size = new System.Drawing.Size(62, 21);
            this.txIndex.TabIndex = 0;
            this.txIndex.Text = "200";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioDiff);
            this.groupBox5.Controls.Add(this.radioSingle);
            this.groupBox5.Location = new System.Drawing.Point(835, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(68, 66);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "测试模式";
            // 
            // radioDiff
            // 
            this.radioDiff.AutoSize = true;
            this.radioDiff.Location = new System.Drawing.Point(6, 39);
            this.radioDiff.Name = "radioDiff";
            this.radioDiff.Size = new System.Drawing.Size(47, 16);
            this.radioDiff.TabIndex = 1;
            this.radioDiff.TabStop = true;
            this.radioDiff.Text = "差分";
            this.radioDiff.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(6, 20);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(47, 16);
            this.radioSingle.TabIndex = 0;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "单端";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // btnSendAndRead
            // 
            this.btnSendAndRead.Location = new System.Drawing.Point(673, 49);
            this.btnSendAndRead.Name = "btnSendAndRead";
            this.btnSendAndRead.Size = new System.Drawing.Size(75, 23);
            this.btnSendAndRead.TabIndex = 16;
            this.btnSendAndRead.Text = "发和收";
            this.btnSendAndRead.UseVisualStyleBackColor = true;
            this.btnSendAndRead.Click += new System.EventHandler(this.btnSendAndRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(754, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txTimeOut
            // 
            this.txTimeOut.Location = new System.Drawing.Point(47, 51);
            this.txTimeOut.Name = "txTimeOut";
            this.txTimeOut.Size = new System.Drawing.Size(80, 21);
            this.txTimeOut.TabIndex = 14;
            this.txTimeOut.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "超时：";
            // 
            // combCommand
            // 
            this.combCommand.FormattingEnabled = true;
            this.combCommand.Items.AddRange(new object[] {
            "*IDN?",
            "FORM:DATA ASCII",
            "MMEM:STOR:TRAC:FORM:SNP MA",
            "CALCulate:PARameter:CAT?",
            ":CALCulate1:TRANsform:TIME:STARt -5E-10",
            ":CALCulate1:TRANsform:TIME:Stop 9.5E-9",
            ":SENSe1:SWEep:POINts?",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":CALCulate1:TRANsform:TIME:STOP?",
            ":INITiate1:CONTinuous ON",
            ":CALC:PAR:SEL \"win1_tr2\"",
            ":CALCulate1:DATA? FDATa",
            ":CALC:PAR:SEL \"win1_tr1\"",
            ":CALCulate1:DATA? FDATA",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISPlay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":INITiatel:CONTinuous ON",
            ":CALCulate1:DATA? FDATa",
            "SYST:ERROR?",
            ":CALC:PAR:SEL\"win1_tr2\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISplay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr2\"",
            ":INITiatel:CONTinuous ON",
            ":CALCulate1:DATA? FDATa",
            "SYST:ERROR?",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISplay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":INITiate1:CONTinuous ON",
            ":CALCulate1:DATA? FDATa",
            "SYST:ERROR?"});
            this.combCommand.Location = new System.Drawing.Point(181, 52);
            this.combCommand.Name = "combCommand";
            this.combCommand.Size = new System.Drawing.Size(400, 20);
            this.combCommand.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "命令：";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(673, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(592, 49);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.combDevString);
            this.groupBox8.Location = new System.Drawing.Point(269, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(318, 46);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "设备名称";
            // 
            // combDevString
            // 
            this.combDevString.FormattingEnabled = true;
            this.combDevString.Location = new System.Drawing.Point(65, 16);
            this.combDevString.Name = "combDevString";
            this.combDevString.Size = new System.Drawing.Size(247, 20);
            this.combDevString.TabIndex = 5;
            this.combDevString.Text = "USB0::0x2A8D::0x7901::MY59100857::0::INSTR";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(592, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combDevType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // combDevType
            // 
            this.combDevType.FormattingEnabled = true;
            this.combDevType.Items.AddRange(new object[] {
            "PNA",
            "ENA"});
            this.combDevType.Location = new System.Drawing.Point(67, 16);
            this.combDevType.Name = "combDevType";
            this.combDevType.Size = new System.Drawing.Size(60, 20);
            this.combDevType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备型号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.combTranType);
            this.groupBox4.Location = new System.Drawing.Point(133, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 46);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "通讯方式：";
            // 
            // combTranType
            // 
            this.combTranType.FormattingEnabled = true;
            this.combTranType.Items.AddRange(new object[] {
            "USB",
            "LAN",
            "GPIB"});
            this.combTranType.Location = new System.Drawing.Point(69, 16);
            this.combTranType.Name = "combTranType";
            this.combTranType.Size = new System.Drawing.Size(58, 20);
            this.combTranType.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listboxResult);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(0, 662);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1230, 104);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // listboxResult
            // 
            this.listboxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxResult.FormattingEnabled = true;
            this.listboxResult.ItemHeight = 12;
            this.listboxResult.Location = new System.Drawing.Point(0, 8);
            this.listboxResult.Name = "listboxResult";
            this.listboxResult.ScrollAlwaysVisible = true;
            this.listboxResult.Size = new System.Drawing.Size(1230, 96);
            this.listboxResult.TabIndex = 0;
            // 
            // localStatusStrip
            // 
            this.localStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.localIP,
            this.localTime});
            this.localStatusStrip.Location = new System.Drawing.Point(0, 769);
            this.localStatusStrip.Name = "localStatusStrip";
            this.localStatusStrip.Size = new System.Drawing.Size(1230, 22);
            this.localStatusStrip.TabIndex = 2;
            this.localStatusStrip.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(71, 17);
            this.info.Text = "Test V1.0.1";
            // 
            // localIP
            // 
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(1144, 17);
            this.localIP.Spring = true;
            // 
            // localTime
            // 
            this.localTime.Name = "localTime";
            this.localTime.Size = new System.Drawing.Size(0, 17);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1224, 584);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 791);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.localStatusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Test V1.0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.localStatusStrip.ResumeLayout(false);
            this.localStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combDevString;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combTranType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox combCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTimeOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listboxResult;
        private System.Windows.Forms.ComboBox combDevType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip localStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.ToolStripStatusLabel localIP;
        private System.Windows.Forms.ToolStripStatusLabel localTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSendAndRead;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txOffset;
        private System.Windows.Forms.TextBox txIndex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioDiff;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combUnit;
        private System.Windows.Forms.TextBox txMin;
        private System.Windows.Forms.TextBox txMax;
        private System.Windows.Forms.TextBox txTargetValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTest;
    }
}

