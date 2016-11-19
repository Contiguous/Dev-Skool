using System;
using System.Windows.Forms;
using System.Net;

namespace Dev_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fgffh = new Whatever_you_want();
            fgffh.Main();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var gfffg = new Take_This();
            gfffg.Main();
        }

        private void btnGetPublicIP_Click(object sender, EventArgs e)
        {
            var pip = new Public_IP();
            tbxPublicIP.Text = pip.GetPublicIP();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
        }

        private void btnShuddarun_Click(object sender, EventArgs e)
        {
            Shuddarun shd = new Shuddarun();
            shd.Show();
        }
    }
}

