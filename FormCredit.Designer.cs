namespace EconomicCalc
{
    partial class FormCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wybor = new System.Windows.Forms.ComboBox();
            this.labeKwotaKredytu = new System.Windows.Forms.Label();
            this.textBoxKwotaKredytu = new System.Windows.Forms.TextBox();
            this.labelIloscRat = new System.Windows.Forms.Label();
            this.textBoxIloscRat = new System.Windows.Forms.TextBox();
            this.labelOprocentowanie = new System.Windows.Forms.Label();
            this.textBoxOprocentowanie = new System.Windows.Forms.TextBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.textBoxRataKredytu = new System.Windows.Forms.TextBox();
            this.textBoxCalkowityKoszt = new System.Windows.Forms.TextBox();
            this.labelRataKredytu = new System.Windows.Forms.Label();
            this.labelCalkowityKoszt = new System.Windows.Forms.Label();
            this.labelProwizja = new System.Windows.Forms.Label();
            this.textBoxProwizja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wybor
            // 
            this.wybor.FormattingEnabled = true;
            this.wybor.Items.AddRange(new object[] {
            "Bez prowizji",
            "Z prowizją netto",
            "Z prowizją brutto"});
            this.wybor.Location = new System.Drawing.Point(29, 32);
            this.wybor.Name = "wybor";
            this.wybor.Size = new System.Drawing.Size(220, 21);
            this.wybor.TabIndex = 0;
            this.wybor.SelectedIndexChanged += new System.EventHandler(this.wybor_SelectedIndexChanged);
            // 
            // labeKwotaKredytu
            // 
            this.labeKwotaKredytu.AutoSize = true;
            this.labeKwotaKredytu.Location = new System.Drawing.Point(26, 96);
            this.labeKwotaKredytu.Name = "labeKwotaKredytu";
            this.labeKwotaKredytu.Size = new System.Drawing.Size(75, 13);
            this.labeKwotaKredytu.TabIndex = 1;
            this.labeKwotaKredytu.Text = "Kwota kredytu";
            this.labeKwotaKredytu.Click += new System.EventHandler(this.labeKwotaKredytu_Click);
            // 
            // textBoxKwotaKredytu
            // 
            this.textBoxKwotaKredytu.Location = new System.Drawing.Point(29, 112);
            this.textBoxKwotaKredytu.Name = "textBoxKwotaKredytu";
            this.textBoxKwotaKredytu.Size = new System.Drawing.Size(100, 20);
            this.textBoxKwotaKredytu.TabIndex = 2;
            this.textBoxKwotaKredytu.TextChanged += new System.EventHandler(this.textBoxKwotaKredytu_TextChanged);
            // 
            // labelIloscRat
            // 
            this.labelIloscRat.AutoSize = true;
            this.labelIloscRat.Location = new System.Drawing.Point(241, 97);
            this.labelIloscRat.Name = "labelIloscRat";
            this.labelIloscRat.Size = new System.Drawing.Size(44, 13);
            this.labelIloscRat.TabIndex = 3;
            this.labelIloscRat.Text = "Ilość rat";
            this.labelIloscRat.Click += new System.EventHandler(this.labelIloscRat_Click);
            // 
            // textBoxIloscRat
            // 
            this.textBoxIloscRat.Location = new System.Drawing.Point(244, 112);
            this.textBoxIloscRat.Name = "textBoxIloscRat";
            this.textBoxIloscRat.Size = new System.Drawing.Size(100, 20);
            this.textBoxIloscRat.TabIndex = 4;
            this.textBoxIloscRat.TextChanged += new System.EventHandler(this.textBoxIloscRat_TextChanged);
            // 
            // labelOprocentowanie
            // 
            this.labelOprocentowanie.AutoSize = true;
            this.labelOprocentowanie.Location = new System.Drawing.Point(26, 166);
            this.labelOprocentowanie.Name = "labelOprocentowanie";
            this.labelOprocentowanie.Size = new System.Drawing.Size(85, 13);
            this.labelOprocentowanie.TabIndex = 5;
            this.labelOprocentowanie.Text = "Oprocentowanie";
            this.labelOprocentowanie.Click += new System.EventHandler(this.labelOprocentowanie_Click);
            // 
            // textBoxOprocentowanie
            // 
            this.textBoxOprocentowanie.Location = new System.Drawing.Point(29, 181);
            this.textBoxOprocentowanie.Name = "textBoxOprocentowanie";
            this.textBoxOprocentowanie.Size = new System.Drawing.Size(100, 20);
            this.textBoxOprocentowanie.TabIndex = 6;
            this.textBoxOprocentowanie.TextChanged += new System.EventHandler(this.textBoxOprocentowanie_TextChanged);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(134, 243);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(115, 43);
            this.buttonOblicz.TabIndex = 7;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // textBoxRataKredytu
            // 
            this.textBoxRataKredytu.Location = new System.Drawing.Point(29, 342);
            this.textBoxRataKredytu.Name = "textBoxRataKredytu";
            this.textBoxRataKredytu.Size = new System.Drawing.Size(100, 20);
            this.textBoxRataKredytu.TabIndex = 8;
            this.textBoxRataKredytu.TextChanged += new System.EventHandler(this.textBoxRataKredytu_TextChanged);
            // 
            // textBoxCalkowityKoszt
            // 
            this.textBoxCalkowityKoszt.Location = new System.Drawing.Point(244, 342);
            this.textBoxCalkowityKoszt.Name = "textBoxCalkowityKoszt";
            this.textBoxCalkowityKoszt.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalkowityKoszt.TabIndex = 9;
            this.textBoxCalkowityKoszt.TextChanged += new System.EventHandler(this.textBoxCalkowityKoszt_TextChanged);
            // 
            // labelRataKredytu
            // 
            this.labelRataKredytu.AutoSize = true;
            this.labelRataKredytu.Location = new System.Drawing.Point(26, 324);
            this.labelRataKredytu.Name = "labelRataKredytu";
            this.labelRataKredytu.Size = new System.Drawing.Size(69, 13);
            this.labelRataKredytu.TabIndex = 10;
            this.labelRataKredytu.Text = "Rata Kredytu";
            this.labelRataKredytu.Click += new System.EventHandler(this.labelRataKredytu_Click);
            // 
            // labelCalkowityKoszt
            // 
            this.labelCalkowityKoszt.AutoSize = true;
            this.labelCalkowityKoszt.Location = new System.Drawing.Point(241, 324);
            this.labelCalkowityKoszt.Name = "labelCalkowityKoszt";
            this.labelCalkowityKoszt.Size = new System.Drawing.Size(120, 13);
            this.labelCalkowityKoszt.TabIndex = 11;
            this.labelCalkowityKoszt.Text = "Całkowity koszt kredytu";
            this.labelCalkowityKoszt.Click += new System.EventHandler(this.labelCalkowityKoszt_Click);
            // 
            // labelProwizja
            // 
            this.labelProwizja.AutoSize = true;
            this.labelProwizja.Location = new System.Drawing.Point(241, 166);
            this.labelProwizja.Name = "labelProwizja";
            this.labelProwizja.Size = new System.Drawing.Size(46, 13);
            this.labelProwizja.TabIndex = 12;
            this.labelProwizja.Text = "Prowizja";
            this.labelProwizja.Click += new System.EventHandler(this.labelProwizja_Click);
            // 
            // textBoxProwizja
            // 
            this.textBoxProwizja.Location = new System.Drawing.Point(244, 181);
            this.textBoxProwizja.Name = "textBoxProwizja";
            this.textBoxProwizja.Size = new System.Drawing.Size(100, 20);
            this.textBoxProwizja.TabIndex = 13;
            this.textBoxProwizja.TextChanged += new System.EventHandler(this.textBoxProwizja_TextChanged);
            // 
            // FormCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 404);
            this.Controls.Add(this.textBoxProwizja);
            this.Controls.Add(this.labelProwizja);
            this.Controls.Add(this.labelCalkowityKoszt);
            this.Controls.Add(this.labelRataKredytu);
            this.Controls.Add(this.textBoxCalkowityKoszt);
            this.Controls.Add(this.textBoxRataKredytu);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.textBoxOprocentowanie);
            this.Controls.Add(this.labelOprocentowanie);
            this.Controls.Add(this.textBoxIloscRat);
            this.Controls.Add(this.labelIloscRat);
            this.Controls.Add(this.textBoxKwotaKredytu);
            this.Controls.Add(this.labeKwotaKredytu);
            this.Controls.Add(this.wybor);
            this.Name = "FormCredit";
            this.Text = "FormCredit";
            this.Load += new System.EventHandler(this.FormCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wybor;
        private System.Windows.Forms.Label labeKwotaKredytu;
        private System.Windows.Forms.TextBox textBoxKwotaKredytu;
        private System.Windows.Forms.Label labelIloscRat;
        private System.Windows.Forms.TextBox textBoxIloscRat;
        private System.Windows.Forms.Label labelOprocentowanie;
        private System.Windows.Forms.TextBox textBoxOprocentowanie;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.TextBox textBoxRataKredytu;
        private System.Windows.Forms.TextBox textBoxCalkowityKoszt;
        private System.Windows.Forms.Label labelRataKredytu;
        private System.Windows.Forms.Label labelCalkowityKoszt;
        private System.Windows.Forms.Label labelProwizja;
        private System.Windows.Forms.TextBox textBoxProwizja;
    }
}