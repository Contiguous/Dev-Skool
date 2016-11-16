using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
namespace Dev_School
{
    class Public_IP
    {

        public void Main()
        {
        }

        public string GetPublicIP()
        {

            string address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("");
            address = address.Substring(first, last - first);

            return address;

        }
    }
}

