using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicCalc
{
    public partial class Form1 : Form
    {
        int value1;
        double value2, value3;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out value1);
            double.TryParse(textBox2.Text, out value2);
            double.TryParse(textBox3.Text, out value3);
            label4.Text = Deposit.lokataProgresywna(value1, value2, value3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out value1);
            double.TryParse(textBox2.Text, out value2);
            double.TryParse(textBox3.Text, out value3);
            label4.Text = Deposit.lokataStatyczna(value1, value2, value3).ToString();
        }
    }
}
