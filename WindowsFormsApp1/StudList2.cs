using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudList2 : Form
    {

        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer myTimer2 = new System.Windows.Forms.Timer();
        int sek=0;
        public StudList2()
        {
            InitializeComponent();
        }

        private void StudList2_Load(object sender, EventArgs e)
        {

            myTimer.Interval = 100;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

            /*for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value++;
            }*/
            myTimer2.Interval = 1000;
            myTimer2.Tick += MyTimer_Tick2;
            myTimer2.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 60) { myTimer.Tick -= MyTimer_Tick; myTimer.Stop(); }
            else progressBar1.Value++;

        }
        private void MyTimer_Tick2(object sender, EventArgs e)
        {
            
            string chs = DateTime.Now.Hour.ToString()+ ":"+ DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

            label1.Text = chs; //DateTime.Now.ToString();

        }
    }
}
