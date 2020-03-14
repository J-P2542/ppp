using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace เกรด
{
    public partial class calculate : Form
    {
        public calculate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gt = button1.Text;
            double g = double.Parse(gt);
            string s = "";
            if (g > 100 || g < 0) 
            {
                s = ("Error");
            }
            else if (g < 50)
            {
                s = ("F");
            }
            else if (g < 60)
            {
                s = ("D");
            }
            else if (g < 70)
            {
                s = ("C");
            }
            else if (g < 80)
            {
                s = ("B");
            }
            else if (g <= 100)
            {
                s = ("A");
            }
            button1.Text = ("" +s);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
