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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.tabKosmetyki = new System.Windows.Forms.TabPage();
            this.txtDzialanie = new System.Windows.Forms.TextBox();
            this.tabSrodkiCzyszcz = new System.Windows.Forms.TabPage();
            this.txtZastosowanie = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnEdytor = new System.Windows.Forms.Button();
            this.tabChemia.SuspendLayout();
            this.tabSpoz.SuspendLayout();
            this.tabKosmetyki.SuspendLayout();
            this.tabSrodkiCzyszcz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChemia
            // 
            this.tabChemia.Controls.Add(this.tabSpoz);
            this.tabChemia.Controls.Add(this.tabKosmetyki);
            this.tabChemia.Controls.Add(this.tabSrodkiCzyszcz);
            this.tabChemia.ItemSize = new System.Drawing.Size(100, 50);
            this.tabChemia.Location = new System.Drawing.Point(12, 35);
            this.tabChemia.Multiline = true;
            this.tabChemia.Name = "tabChemia";
            this.tabChemia.SelectedIndex = 0;
            this.tabChemia.Size = new System.Drawing.Size(388, 154);
            this.tabChemia.TabIndex = 0;
            // 
            // tabSpoz
            // 
            this.tabSpoz.BackColor = System.Drawing.SystemColors.Control;
            this.tabSpoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSpoz.Controls.Add(this.txtOpis);
            this.tabSpoz.ForeColor = System.Drawing.Color.Black;
            this.tabSpoz.Location = new System.Drawing.Point(4, 54);
            this.tabSpoz.Name = "tabSpoz";
            this.tabSpoz.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpoz.Size = new System.Drawing.Size(380, 96);
            this.tabSpoz.TabIndex = 0;
            this.tabSpoz.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.Enabled = false;
            this.txtOpis.Location = new System.Drawing.Point(0, 0);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(380, 100);
            this.txtOpis.TabIndex = 6;
            // 
            // tabKosmetyki
            // 
            this.tabKosmetyki.BackColor = System.Drawing.SystemColors.Control;
            this.tabKosmetyki.Controls.Add(this.txtDzialanie);
            this.tabKosmetyki.Location = new System.Drawing.Point(4, 54);
            this.tabKosmetyki.Name = "tabKosmetyki";
            this.tabKosmetyki.Padding = new System.Windows.Forms.Padding(3);
            this.tabKosmetyki.Size = new System.Drawing.Size(385, 113);
            this.tabKosmetyki.TabIndex = 1;
            this.tabKosmetyki.Text = "Działanie";
            // 
            // txtDzialanie
            // 
            this.txtDzialanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDzialanie.Enabled = false;
            this.txtDzialanie.Location = new System.Drawing.Point(0, 0);
            this.txtDzialanie.Multiline = true;
            this.txtDzialanie.Name = "txtDzialanie";
            this.txtDzialanie.Size = new System.Drawing.Size(380, 100);
            this.txtDzialanie.TabIndex = 8;
            // 
            // tabSrodkiCzyszcz
            // 
            this.tabSrodkiCzyszcz.BackColor = System.Drawing.SystemColors.Control;
            this.tabSrodkiCzyszcz.Controls.Add(this.txtZastosowanie);
            this.tabSrodkiCzyszcz.Location = new System.Drawing.Point(4, 54);
            this.tabSrodkiCzyszcz.Name = "tabSrodkiCzyszcz";
            this.tabSrodkiCzyszcz.Size = new System.Drawing.Size(385, 113);
            this.tabSrodkiCzyszcz.TabIndex = 2;
            this.tabSrodkiCzyszcz.Text = "Zastosowanie";
            // 
            // txtZastosowanie
            // 
            this.txtZastosowanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZastosowanie.Enabled = false;
            this.txtZastosowanie.Location = new System.Drawing.Point(0, 0);
            this.txtZastosowanie.Multiline = true;
            this.txtZastosowanie.Name = "txtZastosowanie";
            this.txtZastosowanie.Size = new System.Drawing.Size(380, 100);
            this.txtZastosowanie.TabIndex = 9;
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
            this.txtKod.Location = new System.Drawing.Point(312, 9);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(161, 20);
            this.txtKod.TabIndex = 9;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // txtNazwa
            // 
            this.txtNazwa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNazwa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNazwa.Location = new System.Drawing.Point(70, 6);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(195, 20);
            this.txtNazwa.TabIndex = 0;
            this.txtNazwa.TextChanged += new System.EventHandler(this.txtNazwa_TextChanged);
            // 
            // btnEdytor
            // 
            this.btnEdytor.Location = new System.Drawing.Point(399, 211);
            this.btnEdytor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytor.Name = "btnEdytor";
            this.btnEdytor.Size = new System.Drawing.Size(74, 31);
            this.btnEdytor.TabIndex = 10;
            this.btnEdytor.Text = "Edytor";
            this.btnEdytor.UseVisualStyleBackColor = true;
            this.btnEdytor.Click += new System.EventHandler(this.btnEdytor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(489, 249);
            this.Controls.Add(this.btnEdytor);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.tabChemia);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Chemia";
            this.tabChemia.ResumeLayout(false);
            this.tabSpoz.ResumeLayout(false);
            this.tabSpoz.PerformLayout();
            this.tabKosmetyki.ResumeLayout(false);
            this.tabKosmetyki.PerformLayout();
            this.tabSrodkiCzyszcz.ResumeLayout(false);
            this.tabSrodkiCzyszcz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabChemia;
        private System.Windows.Forms.TabPage tabSpoz;
        private System.Windows.Forms.TabPage tabKosmetyki;
        private System.Windows.Forms.TabPage tabSrodkiCzyszcz;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtDzialanie;
        private System.Windows.Forms.TextBox txtZastosowanie;
        private System.Windows.Forms.Button btnEdytor;
    }
}

