using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var first = new Calculation_abc(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            label4.Text = first.CalculateResult().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var second = new CalculationAB(int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            label7.Text = second.Sun().ToString();
        }
    }
}
