
namespace EconomicCalc
{
    partial class form2
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
            this.Przycisk_1_ok = new System.Windows.Forms.Button();
            this.Brutto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Koszty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wybor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Przycisk_1_ok
            // 
            this.Przycisk_1_ok.Location = new System.Drawing.Point(634, 386);
            this.Przycisk_1_ok.Name = "Przycisk_1_ok";
            this.Przycisk_1_ok.Size = new System.Drawing.Size(129, 32);
            this.Przycisk_1_ok.TabIndex = 0;
            this.Przycisk_1_ok.Text = "ok";
            this.Przycisk_1_ok.UseVisualStyleBackColor = true;
            this.Przycisk_1_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Brutto
            // 
            this.Brutto.Location = new System.Drawing.Point(211, 50);
            this.Brutto.Name = "Brutto";
            this.Brutto.Size = new System.Drawing.Size(169, 22);
            this.Brutto.TabIndex = 1;
            this.Brutto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj swoją wypłatę brutto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Koszty
            // 
            this.Koszty.Location = new System.Drawing.Point(192, 338);
            this.Koszty.Name = "Koszty";
            this.Koszty.Size = new System.Drawing.Size(169, 22);
            this.Koszty.TabIndex = 3;
            this.Koszty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj koszty (dot. B2B)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wybor
            // 
            this.wybor.FormattingEnabled = true;
            this.wybor.Items.AddRange(new object[] {
            "Umowa o pracę",
            "Umowa zlecenie",
            "Umowa o dzieło",
            "B2B"});
            this.wybor.Location = new System.Drawing.Point(211, 97);
            this.wybor.Name = "wybor";
            this.wybor.Size = new System.Drawing.Size(171, 24);
            this.wybor.TabIndex = 6;
            this.wybor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wybierz typ umowy";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(380, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Twoja wypłata netto to:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(620, 270);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(150, 22);
            this.Wynik.TabIndex = 9;
            this.Wynik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wybor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Koszty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brutto);
            this.Controls.Add(this.Przycisk_1_ok);
            this.Name = "form2";
            this.Text = "Wypłata netto";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Przycisk_1_ok;
        private System.Windows.Forms.TextBox Brutto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Koszty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wybor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Wynik;
    }
}