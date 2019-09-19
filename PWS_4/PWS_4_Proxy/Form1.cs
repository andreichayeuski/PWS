using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWS_4_Proxy
{
    public partial class Form1 : Form
    {
        PWS_4_Proxy.Proxy.Simplex proxyClient;
        public Form1()
        {
            InitializeComponent();
            proxyClient = new PWS_4_Proxy.Proxy.Simplex();
        }

        private void GetSum_Click(object sender, EventArgs e)
        {
            result.ForeColor = Color.Black;
            int val1, val2;
            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = proxyClient.Add(val1, val2).ToString();
            }
            else
            {
                result.ForeColor = Color.Red;
                result.Text = "Error!";
            }
        }

        private void Cav_Click(object sender, EventArgs e)
        {
            var msu1 = new Proxy.A
            {
                s = s1.Text,
                k = int.Parse(i1.Text),
                f = float.Parse(d1.Text)
            };

            var msu2 = new Proxy.A
            {
                s = s2.Text,
                k = int.Parse(i2.Text),
                f = float.Parse(d2.Text)
            };

            var result = proxyClient.Sum(msu1, msu2);

            result_1.Text = result.s;
            result_2.Text = result.k.ToString();
            result_3.Text = result.f.ToString();
        }
    }
}
