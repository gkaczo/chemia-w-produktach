namespace chemia1_1
{
    partial class Edytor
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
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnDodajDoBazy = new System.Windows.Forms.Button();
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRyzykoEdytor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNazwa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(265, 252);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(60, 24);
            this.btnUsun.TabIndex = 38;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(12, 250);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 36;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnDodajDoBazy
            // 
            this.btnDodajDoBazy.Location = new System.Drawing.Point(402, 253);
            this.btnDodajDoBazy.Name = "btnDodajDoBazy";
            this.btnDodajDoBazy.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoBazy.TabIndex = 35;
            this.btnDodajDoBazy.Text = "Dodaj";
            this.btnDodajDoBazy.UseVisualStyleBackColor = true;
            this.btnDodajDoBazy.Click += new System.EventHandler(this.btnDodajDoBazy_Click);
            // 
            // txtKodEdytor
            // 
            this.txtKodEdytor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKodEdytor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKodEdytor.Location = new System.Drawing.Point(265, 46);
            this.txtKodEdytor.Name = "txtKodEdytor";
            this.txtKodEdytor.Size = new System.Drawing.Size(115, 20);
            this.txtKodEdytor.TabIndex = 34;
            this.txtKodEdytor.TextChanged += new System.EventHandler(this.txtKodEdytor_TextChanged);
            // 
            // txtZastosowanieEdytor
            // 
            this.txtZastosowanieEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZastosowanieEdytor.Location = new System.Drawing.Point(265, 115);
            this.txtZastosowanieEdytor.Multiline = true;
            this.txtZastosowanieEdytor.Name = "txtZastosowanieEdytor";
            this.txtZastosowanieEdytor.Size = new System.Drawing.Size(214, 35);
            this.txtZastosowanieEdytor.TabIndex = 33;
            // 
            // txtDzialanieEdytor
            // 
            this.txtDzialanieEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDzialanieEdytor.Location = new System.Drawing.Point(265, 156);
            this.txtDzialanieEdytor.Multiline = true;
            this.txtDzialanieEdytor.Name = "txtDzialanieEdytor";
            this.txtDzialanieEdytor.Size = new System.Drawing.Size(215, 41);
            this.txtDzialanieEdytor.TabIndex = 32;
            // 
            // txtOpisEdytor
            // 
            this.txtOpisEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpisEdytor.Location = new System.Drawing.Point(265, 72);
            this.txtOpisEdytor.Multiline = true;
            this.txtOpisEdytor.Name = "txtOpisEdytor";
            this.txtOpisEdytor.Size = new System.Drawing.Size(214, 35);
            this.txtOpisEdytor.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(233, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(180, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "zastosowanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(204, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "działanie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(234, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "kod";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(219, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nazwa";
            // 
            // txtNazwaEdytor
            // 
            this.txtNazwaEdytor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNazwaEdytor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNazwaEdytor.Location = new System.Drawing.Point(265, 21);
            this.txtNazwaEdytor.Name = "txtNazwaEdytor";
            this.txtNazwaEdytor.Size = new System.Drawing.Size(215, 20);
            this.txtNazwaEdytor.TabIndex = 25;
            this.txtNazwaEdytor.TextChanged += new System.EventHandler(this.txtNazwaEdytor_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(104, 250);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 23);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRyzykoEdytor
            // 
            this.txtRyzykoEdytor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRyzykoEdytor.Location = new System.Drawing.Point(265, 206);
            this.txtRyzykoEdytor.Multiline = true;
            this.txtRyzykoEdytor.Name = "txtRyzykoEdytor";
            this.txtRyzykoEdytor.Size = new System.Drawing.Size(215, 41);
            this.txtRyzykoEdytor.TabIndex = 40;
            this.txtRyzykoEdytor.TextChanged += new System.EventHandler(this.txtRyzykoEdytor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(217, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ryzyko";
            // 
            // lstNazwa
            // 
            this.lstNazwa.FormattingEnabled = true;
            this.lstNazwa.Location = new System.Drawing.Point(12, 21);
            this.lstNazwa.Name = "lstNazwa";
            this.lstNazwa.Size = new System.Drawing.Size(160, 225);
            this.lstNazwa.TabIndex = 42;
            this.lstNazwa.SelectedIndexChanged += new System.EventHandler(this.lstNazwa_SelectedIndexChanged);
            // 
            // Edytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(508, 286);
            this.Controls.Add(this.lstNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRyzykoEdytor);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnDodajDoBazy);
            this.Controls.Add(this.txtKodEdytor);
            this.Controls.Add(this.txtZastosowanieEdytor);
            this.Controls.Add(this.txtDzialanieEdytor);
            this.Controls.Add(this.txtOpisEdytor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNazwaEdytor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edytor";
            this.Text = "Edytor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnDodajDoBazy;
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
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtRyzykoEdytor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNazwa;
    }
}