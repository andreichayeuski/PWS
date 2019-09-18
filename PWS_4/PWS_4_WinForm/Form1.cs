using PWS_4_WinForm.Simplex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWS_4_WinForm
{
    public partial class Form1 : Form
    {
        SimplexSoapClient refClient;
        Simplex_local.SimplexSoapClient simplexLocalClient;

        public Form1()
        {
            refClient = new SimplexSoapClient();
            simplexLocalClient = new Simplex_local.SimplexSoapClient();
            InitializeComponent();
        }

        private void GetSum_Click_1(object sender, EventArgs e)
        {
            result.ForeColor = Color.Black;
            int val1, val2;
            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                //result.Text = refClient.Add(val1, val2).ToString();
                result.Text = simplexLocalClient.Add(val1, val2).ToString();
            }
            else
            {
                result.ForeColor = Color.Red;
                result.Text = "Error!";
            }
        }

        private void Cav_Click(object sender, EventArgs e)
        {
            var msu1 = new Simplex_local.A();
            msu1.s = s1.Text;
            msu1.k = int.Parse(i1.Text);
            msu1.f = float.Parse(d1.Text);

            var msu2 = new Simplex_local.A();
            msu2.s = s2.Text;
            msu2.k = int.Parse(i2.Text);
            msu2.f = float.Parse(d2.Text);

            var result = simplexLocalClient.Sum(msu1, msu2);

            result_1.Text = result.s;
            result_2.Text = result.k.ToString();
            result_3.Text = result.f.ToString();
        }
    }
}
