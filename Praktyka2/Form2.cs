using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktyka2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a11 = int.Parse(textBox1.Text);
            int a12 = int.Parse(textBox2.Text);
            int a13 = int.Parse(textBox3.Text);
            int a21 = int.Parse(textBox4.Text);
            int a22 = int.Parse(textBox5.Text);
            int a23 = int.Parse(textBox6.Text);
            int a31 = int.Parse(textBox7.Text);
            int a32 = int.Parse(textBox8.Text);
            int a33 = int.Parse(textBox9.Text);

            Matrix matrix = new Matrix();

            matrix.SetMatrixValues(a11, a12, a13, a21, a22, a23, a31, a32, a33);

            int sumColumn1 = matrix.CalculateSumColumn1();
            int sumColumn2 = matrix.CalculateSumColumn2();
            int sumColumn3 = matrix.CalculateSumColumn3();

            string res1 = sumColumn1.ToString();
            string res2 = sumColumn2.ToString();
            string res3 = sumColumn3.ToString();

            label1.Text = res1;
            label2.Text = res2;
            label3.Text = res3;
        }
    }
}
