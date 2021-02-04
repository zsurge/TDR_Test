using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void initControl()
        {
            combCommand.SelectedIndex = 0;            
            combDevType.SelectedIndex = 0;
            combTranType.SelectedIndex = 0;
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


        private void btnOpen_Click(object sender, EventArgs e)
        {
            int error = analyzer.Open();
            string idn;
            error = analyzer.GetInstrumentIdentifier(out idn);
            error = analyzer.ClearAllErrorQueue();
            error = analyzer.Preset();
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
