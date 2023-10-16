using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                int c = Convert.ToInt16(textBox3.Text);

                int revenue = a * 15 + b * 12 + c * 9;

                textBox4.Text = Convert.ToString(a * 15) + "$";
                textBox5.Text = Convert.ToString(b * 12) + "$";
                textBox6.Text = Convert.ToString(c * 9) + "$";

                textBox7.Text = Convert.ToString(revenue) + "$";
            }
            catch
            {
                button2_Click(sender, e);
                MessageBox.Show("Invalid value!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
