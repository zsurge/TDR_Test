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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.localStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(673, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
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
            ":CALCulate1:DATA?FDATa",
            ":CALC:PAR:SEL \"win1_tr1\"",
            ":CALCulate1:DATA?FDATA",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISPlay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":INITiatel:CONTinuous ON",
            ":CALCulate1:DATA?FDATa",
            "SYST:ERROR?",
            ":CALC:PAR:SEL\"win1_tr2\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISplay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr2\"",
            ":INITiatel:CONTinuous ON",
            ":CALCulate1:DATA?FDATa",
            "SYST:ERROR?",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":CALCulate1:TRANsform:TIME:STARt?",
            ":DISplay:ENABle ON",
            ":CALC:PAR:SEL\"win1_tr1\"",
            ":INITiate1:CONTinuous ON",
            ":CALCulate1:DATA?FDATa",
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
            this.groupBox3.Location = new System.Drawing.Point(1, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 329);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // listboxResult
            // 
            this.listboxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxResult.FormattingEnabled = true;
            this.listboxResult.ItemHeight = 12;
            this.listboxResult.Location = new System.Drawing.Point(-1, 11);
            this.listboxResult.Name = "listboxResult";
            this.listboxResult.ScrollAlwaysVisible = true;
            this.listboxResult.Size = new System.Drawing.Size(772, 312);
            this.listboxResult.TabIndex = 0;
            // 
            // localStatusStrip
            // 
            this.localStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.localIP,
            this.localTime});
            this.localStatusStrip.Location = new System.Drawing.Point(0, 398);
            this.localStatusStrip.Name = "localStatusStrip";
            this.localStatusStrip.Size = new System.Drawing.Size(777, 22);
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
            this.localIP.Size = new System.Drawing.Size(691, 17);
            this.localIP.Spring = true;
            // 
            // localTime
            // 
            this.localTime.Name = "localTime";
            this.localTime.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 420);
            this.Controls.Add(this.localStatusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Test V1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.localStatusStrip.ResumeLayout(false);
            this.localStatusStrip.PerformLayout();
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
    }
}

