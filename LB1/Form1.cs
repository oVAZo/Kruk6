using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double r = double.Parse(textBox1.Text);
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox3.Text);

            var semicycle = new Semicycle(r);


            double res1 = semicycle.CalculateArea();
            double res2 = semicycle.CalculateArcLength();
            

            string Res1 = res1.ToString();
            string Res2 = res2.ToString();
            string Res3 = semicycle.CheckPoint(x, y);

            label4.Text = "Площа = " + Res1;
            label5.Text = "Довжина дуги = " + Res2;
            label6.Text = Res3;

        }
    }
}
