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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                Mas arr = new Mas(n);
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridView1.Rows.Add(arr[i].ToString());
                }
                int res1 = arr.CountNegativeElements();
                label2.Text = res1.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
