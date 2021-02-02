using System;
using System.Media;
using System.Windows.Forms;

namespace EconomicCalc
{
    public partial class Exchange_form : Form
    {
        int currencyCount;
        String[] currency;
        String[] currencyName;
        double[] currencySell;
        double[] currencyBuy;
        Label[,] tableLabels;
        double value;
        double result;
        Form1 mainForm;

        String messagBox1 = "Nie wbrałeś rodzaju waluty";
        String messagBox2 = "Nie podałeś poprawnej warości w kwocie";
        string caption = "Error Detected in Input";

        Exchange exchange;


        public Exchange_form(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        public void tableLayoutPanelcreate()
        {

            tableLabels = new Label[4, currencyCount + 1];
            tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(339, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = currencyCount + 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());

            tableLabels[0, 0] = new Label();
            tableLabels[1, 0] = new Label();
            tableLabels[2, 0] = new Label();
            tableLabels[3, 0] = new Label();

            tableLabels[0, 0].Text = "Currency name";
            tableLabels[1, 0].Text = "Code";
            tableLabels[2, 0].Text = "Sell cost";
            tableLabels[3, 0].Text = "Buy cost";

            tableLayoutPanel3.Controls.Add(tableLabels[0, 0], 0, 0);
            tableLayoutPanel3.Controls.Add(tableLabels[1, 0], 1, 0);
            tableLayoutPanel3.Controls.Add(tableLabels[2, 0], 2, 0);
            tableLayoutPanel3.Controls.Add(tableLabels[3, 0], 3, 0);


            for (int i = 1; i <= currencyCount; i++)
            {
                tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
                tableLabels[0, i] = new Label();
                tableLabels[1, i] = new Label();
                tableLabels[2, i] = new Label();
                tableLabels[3, i] = new Label();

                tableLabels[0, i].Text = currencyName[i - 1];
                tableLabels[1, i].Text = currency[i - 1];
                tableLabels[2, i].Text = currencySell[i - 1].ToString();
                tableLabels[3, i].Text = currencyBuy[i - 1].ToString();

                tableLayoutPanel3.Controls.Add(tableLabels[0, i], 0, i);
                tableLayoutPanel3.Controls.Add(tableLabels[1, i], 1, i);
                tableLayoutPanel3.Controls.Add(tableLabels[2, i], 2, i);
                tableLayoutPanel3.Controls.Add(tableLabels[3, i], 3, i);
            }
            tableLayoutPanel3.Size = new System.Drawing.Size(330, 478);
            tableLayoutPanel3.TabIndex = 1;
        }
        public async System.Threading.Tasks.Task ComboboxInitializeItemsAsync()
        {
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            exchange = new Exchange();
            await exchange.connectNbpApiAsync();
            currencyCount = exchange.GetAmountCurrencys();
            currency = new string[currencyCount];
            currencyName = new string[currencyCount];
            currencySell = new double[currencyCount];
            currencyBuy = new double[currencyCount];
            for (int i = 0; i < currencyCount; i++)
            {
                currency[i] = exchange.GetCurrencyCode(i);
                currencyName[i] = exchange.GetCurrencyName(i);
                currencySell[i] = exchange.GetCurrencySellCost(i);
                currencyBuy[i] = exchange.GetCurrencyBuyCost(i);
                comboBox1.Items.Add(currency[i]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value) && comboBox1.SelectedIndex >= 0)
            {
                result = Math.Round(exchange.Sell(value, comboBox1.SelectedIndex), 2);
                label3.Text = result.ToString() + " PLN";
            }
            else if (comboBox1.SelectedIndex < 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(messagBox1, caption);
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(messagBox2, caption);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value) && comboBox1.SelectedIndex >= 0)
            {
                result = Math.Round(exchange.Buy(value, comboBox1.SelectedIndex), 2);
                label3.Text = result.ToString() + " PLN";
            }
            else if (comboBox1.SelectedIndex < 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(messagBox1, caption);
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(messagBox2, caption);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}