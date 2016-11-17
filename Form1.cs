using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

