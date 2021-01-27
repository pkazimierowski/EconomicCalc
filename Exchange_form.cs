using System;
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

        Exchange exchange;


        public Exchange_form()
        {
            InitializeComponent();
        }
        public void tableLayoutPanelcreate()
        {
            tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(339, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = currencyCount ;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(330, 472);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            Console.WriteLine("test");
        }
        public async System.Threading.Tasks.Task ComboboxInitializeItemsAsync()
        {

            exchange = new Exchange();
            await exchange.connectNbpApiAsync();
            currencyCount = exchange.GetAmountCurrencys();
            currency = new string[currencyCount];
            for (int i = 0; i < currencyCount; i++)
            {
                currency[i] = exchange.GetCurrencyCode(i);
                currencyName[i] = exchange.GetCurrencyName(i);
                currencySell[i] = exchange.GetCurrencySellCost(i);
                currencyBuy[i] = exchange.GetCurrencyBuyCost(i);
                comboBox1.Items.Add(currency[i]);
                Console.WriteLine(currency[i]);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async void label2_Click(object sender, EventArgs e)
        {
            await ComboboxInitializeItemsAsync();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            //this.tableLayoutPanel3.SetRow();
        }
    }
}
