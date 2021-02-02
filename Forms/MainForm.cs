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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PitButton_Click(object sender, EventArgs e)
        {
            PIT_Form PitForm = new PIT_Form(this);
            this.Hide();
            PitForm.Show();

        }

        private async void ExchangeButton_Click(object sender, EventArgs e)
        {

            Exchange_form exForm = new Exchange_form(this);
            await exForm.ComboboxInitializeItemsAsync();
            this.Hide();
            exForm.tableLayoutPanelcreate();
            exForm.Show();

        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            FormCredit creditsForm = new FormCredit(this);
            this.Hide();
            creditsForm.Show();
        }

        private void TaxButton_Click(object sender, EventArgs e)
        {
            TaxForm taxForm = new TaxForm(this);
            this.Hide();
            taxForm.Show();
        }

        private void DepositsButton_Click(object sender, EventArgs e)
        {
            DepositForms dpForm = new DepositForms(this);
            this.Hide();
            dpForm.Show();
        }
    }
}