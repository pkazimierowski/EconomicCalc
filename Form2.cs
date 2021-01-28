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
    public partial class TaxForm : Form
    {
        double wart1,wart2, result;
        Form1 MainForm;
        public TaxForm(Form1 main)
        {
            InitializeComponent();
            MainForm = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(Koszty.Text, out wart2);

            if (double.TryParse(Brutto.Text, out wart1) && wybor.SelectedIndex != -1)
            {
                if (wart2 > wart1)
                {
                    MessageBox.Show("Koszty nie mogą być wyższe od przychodu!", "Błąd");

                }
                else
                {
                    switch (wybor.SelectedIndex)
                    {
                        case 0:
                            result = contract.uop(wart1);
                            Wynik.Text = result.ToString();
                            break;
                        case 1:
                            result = contract.uz(wart1);
                            Wynik.Text = result.ToString();
                            break;
                        case 2:
                            result = contract.uod(wart1);
                            Wynik.Text = result.ToString();
                            break;
                        case 3:
                            result = contract.b2b(wart1, wart2);
                            Wynik.Text = result.ToString();
                            break;

                    }
                }
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
