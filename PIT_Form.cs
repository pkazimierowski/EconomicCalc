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
    public partial class PIT_Form : Form
    {
        public double value1,value2,value3;
        public double value4;

        
        
        public PIT_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double.TryParse(textBox1.Text, out value1);
            double.TryParse(textBox2.Text, out value2);
            double.TryParse(textBox3.Text, out value3);
            label5.Text = Pit.podatekLinowy(value1, value2, value3).ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out value1);
            double.TryParse(textBox2.Text, out value2);
            double.TryParse(textBox3.Text, out value3);
            label5.Text = Pit.podatekProgresywny(value1, value2, value3).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out value1);
            double.TryParse(textBox2.Text, out value2);
            double.TryParse(textBox3.Text, out value3);
            label5.Text = Pit.Ryczalt(value1, value2, value3, value4).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
    }

    
}
