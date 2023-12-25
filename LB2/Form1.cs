using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double pl = Double.Parse(textBox2.Text);

            var stil = new Stil(name, pl);

            double res1 = stil.Price(); 
            label5.Text = res1.ToString()+ " $";

            var spad = new Spad (name, pl, textBox3.Text, Double.Parse(textBox4.Text));

            double res2 = spad.fullPrice();
            label8.Text = res2.ToString() + " $";
        }


        private void menuItemInheritance_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form inheritanceForm = new Form();
            inheritanceForm.Show();
        }
    }
}
