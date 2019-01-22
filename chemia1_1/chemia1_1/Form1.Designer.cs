namespace chemia1_1
{
    partial class Form1
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
            this.tabChemia = new System.Windows.Forms.TabControl();
            this.tabSpoz = new System.Windows.Forms.TabPage();
            this.tabKosmetyki = new System.Windows.Forms.TabPage();
            this.tabSrodkiCzyszcz = new System.Windows.Forms.TabPage();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtDzialanie = new System.Windows.Forms.TextBox();
            this.txtZastosowanie = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.tabEdytor = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtKodEdytor = new System.Windows.Forms.TextBox();
            this.txtZastosowanieEdytor = new System.Windows.Forms.TextBox();
            this.txtDzialanieEdytor = new System.Windows.Forms.TextBox();
            this.txtOpisEdytor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNazwaEdytor = new System.Windows.Forms.TextBox();
            this.btnDodajDoBazy = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.tabChemia.SuspendLayout();
            this.tabSpoz.SuspendLayout();
            this.tabEdytor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChemia
            // 
            this.tabChemia.Controls.Add(this.tabSpoz);
            this.tabChemia.Controls.Add(this.tabKosmetyki);
            this.tabChemia.Controls.Add(this.tabSrodkiCzyszcz);
            this.tabChemia.Controls.Add(this.tabEdytor);
            this.tabChemia.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabChemia.ItemSize = new System.Drawing.Size(100, 50);
            this.tabChemia.Location = new System.Drawing.Point(0, 0);
            this.tabChemia.Multiline = true;
            this.tabChemia.Name = "tabChemia";
            this.tabChemia.SelectedIndex = 0;
            this.tabChemia.Size = new System.Drawing.Size(785, 456);
            this.tabChemia.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabChemia.TabIndex = 0;
            // 
            // tabSpoz
            // 
            this.tabSpoz.BackColor = System.Drawing.Color.Yellow;
            this.tabSpoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSpoz.Controls.Add(this.txtKod);
            this.tabSpoz.Controls.Add(this.txtZastosowanie);
            this.tabSpoz.Controls.Add(this.txtDzialanie);
            this.tabSpoz.Controls.Add(this.txtOpis);
            this.tabSpoz.Controls.Add(this.label5);
            this.tabSpoz.Controls.Add(this.label4);
            this.tabSpoz.Controls.Add(this.label3);
            this.tabSpoz.Controls.Add(this.label2);
            this.tabSpoz.Controls.Add(this.label1);
            this.tabSpoz.Controls.Add(this.txtNazwa);
            this.tabSpoz.ForeColor = System.Drawing.Color.Black;
            this.tabSpoz.Location = new System.Drawing.Point(4, 54);
            this.tabSpoz.Name = "tabSpoz";
            this.tabSpoz.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpoz.Size = new System.Drawing.Size(777, 324);
            this.tabSpoz.TabIndex = 0;
            this.tabSpoz.Text = "ArtSpożywcze";
            // 
            // tabKosmetyki
            // 
            this.tabKosmetyki.Location = new System.Drawing.Point(4, 54);
            this.tabKosmetyki.Name = "tabKosmetyki";
            this.tabKosmetyki.Padding = new System.Windows.Forms.Padding(3);
            this.tabKosmetyki.Size = new System.Drawing.Size(777, 324);
            this.tabKosmetyki.TabIndex = 1;
            this.tabKosmetyki.Text = "Kosmetyki";
            this.tabKosmetyki.UseVisualStyleBackColor = true;
            // 
            // tabSrodkiCzyszcz
            // 
            this.tabSrodkiCzyszcz.Location = new System.Drawing.Point(4, 54);
            this.tabSrodkiCzyszcz.Name = "tabSrodkiCzyszcz";
            this.tabSrodkiCzyszcz.Size = new System.Drawing.Size(777, 324);
            this.tabSrodkiCzyszcz.TabIndex = 2;
            this.tabSrodkiCzyszcz.Text = "Środki Czyszczące";
            this.tabSrodkiCzyszcz.UseVisualStyleBackColor = true;
            // 
            // txtNazwa
            // 
            this.txtNazwa.AutoCompleteCustomSource.AddRange(new string[] {
            "jan",
            "tomek",
            "tomasz",
            "janek",
            "romek"});
            this.txtNazwa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNazwa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNazwa.Location = new System.Drawing.Point(54, 24);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(335, 20);
            this.txtNazwa.TabIndex = 0;
            this.txtNazwa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "działanie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "zastosowanie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "opis";
            // 
            // txtOpis
            // 
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.Enabled = false;
            this.txtOpis.Location = new System.Drawing.Point(23, 115);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(214, 194);
            this.txtOpis.TabIndex = 6;
            // 
            // txtDzialanie
            // 
            this.txtDzialanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDzialanie.Enabled = false;
            this.txtDzialanie.Location = new System.Drawing.Point(271, 115);
            this.txtDzialanie.Multiline = true;
            this.txtDzialanie.Name = "txtDzialanie";
            this.txtDzialanie.Size = new System.Drawing.Size(231, 194);
            this.txtDzialanie.TabIndex = 7;
            // 
            // txtZastosowanie
            // 
            this.txtZastosowanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZastosowanie.Enabled = false;
            this.txtZastosowanie.Location = new System.Drawing.Point(519, 115);
            this.txtZastosowanie.Multiline = true;
            this.txtZastosowanie.Name = "txtZastosowanie";
            this.txtZastosowanie.Size = new System.Drawing.Size(228, 194);
            this.txtZastosowanie.TabIndex = 8;
            // 
            // txtKod
            // 
            this.txtKod.AutoCompleteCustomSource.AddRange(new string[] {
            "E100",
            "E101",
            "E102",
            "E103",
            "E104",
            "E105",
            "E106",
            "E107",
            "E108"});
            this.txtKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKod.Location = new System.Drawing.Point(463, 27);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(184, 20);
            this.txtKod.TabIndex = 9;
            // 
            // tabEdytor
            // 
            this.tabEdytor.Controls.Add(this.btnZapisz);
            this.tabEdytor.Controls.Add(this.btnDodajDoBazy);
            this.tabEdytor.Controls.Add(this.txtKodEdytor);
            this.tabEdytor.Controls.Add(this.txtZastosowanieEdytor);
            this.tabEdytor.Controls.Add(this.txtDzialanieEdytor);
            this.tabEdytor.Controls.Add(this.txtOpisEdytor);
            this.tabEdytor.Controls.Add(this.label6);
            this.tabEdytor.Controls.Add(this.label7);
            this.tabEdytor.Controls.Add(this.label8);
            this.tabEdytor.Controls.Add(this.label9);
            this.tabEdytor.Controls.Add(this.label10);
            this.tabEdytor.Controls.Add(this.txtNazwaEdytor);
            this.tabEdytor.Controls.Add(this.comboBox1);
            this.tabEdytor.Location = new System.Drawing.Point(4, 54);
            this.tabEdytor.Name = "tabEdytor";
            this.tabEdytor.Size = new System.Drawing.Size(777, 398);
            this.tabEdytor.TabIndex = 3;
            this.tabEdytor.Text = "Edytor";
            this.tabEdytor.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Artykuły spożywcze",
            "Kosmetyki",
            "Środki Czyszczące"});
            this.comboBox1.Location = new System.Drawing.Point(63, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // txtKodEdytor
            // 
            this.txtKodEdytor.Location = new System.Drawing.Point(517, 95);
            this.txtKodEdytor.Name = "txtKodEdytor";
            this.txtKodEdytor.Size = new System.Drawing.Size(184, 20);
            this.txtKodEdytor.TabIndex = 19;
            // 
            // txtZastosowanieEdytor
            // 
            this.txtZastosowanieEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZastosowanieEdytor.Location = new System.Drawing.Point(517, 176);
            this.txtZastosowanieEdytor.Multiline = true;
            this.txtZastosowanieEdytor.Name = "txtZastosowanieEdytor";
            this.txtZastosowanieEdytor.Size = new System.Drawing.Size(228, 180);
            this.txtZastosowanieEdytor.TabIndex = 18;
            // 
            // txtDzialanieEdytor
            // 
            this.txtDzialanieEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDzialanieEdytor.Location = new System.Drawing.Point(269, 176);
            this.txtDzialanieEdytor.Multiline = true;
            this.txtDzialanieEdytor.Name = "txtDzialanieEdytor";
            this.txtDzialanieEdytor.Size = new System.Drawing.Size(231, 180);
            this.txtDzialanieEdytor.TabIndex = 17;
            // 
            // txtOpisEdytor
            // 
            this.txtOpisEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpisEdytor.Location = new System.Drawing.Point(30, 176);
            this.txtOpisEdytor.Multiline = true;
            this.txtOpisEdytor.Name = "txtOpisEdytor";
            this.txtOpisEdytor.Size = new System.Drawing.Size(214, 180);
            this.txtOpisEdytor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "opis";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "zastosowanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "działanie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "kod";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nazwa";
            // 
            // txtNazwaEdytor
            // 
            this.txtNazwaEdytor.Location = new System.Drawing.Point(102, 88);
            this.txtNazwaEdytor.Name = "txtNazwaEdytor";
            this.txtNazwaEdytor.Size = new System.Drawing.Size(335, 20);
            this.txtNazwaEdytor.TabIndex = 10;
            // 
            // btnDodajDoBazy
            // 
            this.btnDodajDoBazy.Location = new System.Drawing.Point(409, 372);
            this.btnDodajDoBazy.Name = "btnDodajDoBazy";
            this.btnDodajDoBazy.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoBazy.TabIndex = 20;
            this.btnDodajDoBazy.Text = "Dodaj";
            this.btnDodajDoBazy.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(544, 372);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 21;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 491);
            this.Controls.Add(this.tabChemia);
            this.Name = "Form1";
            this.Text = "Chemia";
            this.tabChemia.ResumeLayout(false);
            this.tabSpoz.ResumeLayout(false);
            this.tabSpoz.PerformLayout();
            this.tabEdytor.ResumeLayout(false);
            this.tabEdytor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChemia;
        private System.Windows.Forms.TabPage tabSpoz;
        private System.Windows.Forms.TabPage tabKosmetyki;
        private System.Windows.Forms.TabPage tabSrodkiCzyszcz;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZastosowanie;
        private System.Windows.Forms.TextBox txtDzialanie;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TabPage tabEdytor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtKodEdytor;
        private System.Windows.Forms.TextBox txtZastosowanieEdytor;
        private System.Windows.Forms.TextBox txtDzialanieEdytor;
        private System.Windows.Forms.TextBox txtOpisEdytor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNazwaEdytor;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnDodajDoBazy;
    }
}

