using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Tabulation tabulation = new Tabulation();

            double xn, xk, h, a;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            tabulation.tab(xn, xk, h, a);
            for (int i = 0; i < tabulation.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabulation.xy[i, 0], 2).ToString(),
                    Math.Round(tabulation.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabulation.xy[i, 0], tabulation.xy[i, 1]);
            }
        }
    }
}
