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
    
    public partial class FormCredit : Form
    {
        double kredyt, raty, oprocentowanie, prowizja, rataKredytu, koszt;
        Form1 mainForm;
        public FormCredit(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxCalkowityKoszt.Text, out koszt);
            double.TryParse(textBoxIloscRat.Text, out raty);
            double.TryParse(textBoxOprocentowanie.Text, out oprocentowanie);
            double.TryParse(textBoxProwizja.Text, out prowizja);
            if (double.TryParse(textBoxKwotaKredytu.Text, out kredyt) && wybor.SelectedIndex != -1)
            {
                switch (wybor.SelectedIndex)
                {
                    case 0:
                        rataKredytu = Credit.Installment(kredyt, oprocentowanie, raty);
                        koszt = Credit.Total(rataKredytu, raty);
                        textBoxCalkowityKoszt.Text = koszt.ToString();
                        textBoxRataKredytu.Text = rataKredytu.ToString();
                        break;
                    case 1:
                        rataKredytu = Credit.InstallmentNetto(kredyt, oprocentowanie, raty, prowizja);
                        koszt = Credit.Total(rataKredytu, raty);
                        textBoxCalkowityKoszt.Text = koszt.ToString();
                        textBoxRataKredytu.Text = rataKredytu.ToString();
                        break;
                    case 2:
                        rataKredytu = Credit.InstallmentBrutto(kredyt, oprocentowanie, raty, prowizja);
                        koszt = Credit.Total(rataKredytu, raty);
                        textBoxCalkowityKoszt.Text = koszt.ToString();
                        textBoxRataKredytu.Text = rataKredytu.ToString();
                        break;


                }
            }

        }
        private void FormCredit_Load(object sender, EventArgs e)
        {

        }

        private void wybor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCalkowityKoszt_Click(object sender, EventArgs e)
        {

        }

        private void labelRataKredytu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCalkowityKoszt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRataKredytu_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBoxOprocentowanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOprocentowanie_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIloscRat_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIloscRat_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKwotaKredytu_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeKwotaKredytu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProwizja_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelProwizja_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}