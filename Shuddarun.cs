using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Dev_School
{
    public partial class Shuddarun : Form
    {
        public Shuddarun()
        {
            InitializeComponent();
            GetPrivateIP();
        }
        private void GetPrivateIP()
        {
            String strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                textBox1.Text += addr[i].ToString() + Environment.NewLine;
            }
        }
    }
}