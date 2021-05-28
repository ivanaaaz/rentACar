namespace KlijentApp
{
    partial class UnosKlijenta
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
            this.gbUnos = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbZemlja = new System.Windows.Forms.ComboBox();
            this.gbUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUnos
            // 
            this.gbUnos.Controls.Add(this.cmbZemlja);
            this.gbUnos.Controls.Add(this.label9);
            this.gbUnos.Controls.Add(this.button2);
            this.gbUnos.Controls.Add(this.button1);
            this.gbUnos.Controls.Add(this.dataGridView1);
            this.gbUnos.Controls.Add(this.label8);
            this.gbUnos.Controls.Add(this.txtIznos);
            this.gbUnos.Controls.Add(this.label7);
            this.gbUnos.Controls.Add(this.txtMail);
            this.gbUnos.Controls.Add(this.label6);
            this.gbUnos.Controls.Add(this.txtKontakt);
            this.gbUnos.Controls.Add(this.btnSacuvaj);
            this.gbUnos.Controls.Add(this.txtJMBG);
            this.gbUnos.Controls.Add(this.txtPrezime);
            this.gbUnos.Controls.Add(this.txtIme);
            this.gbUnos.Controls.Add(this.label5);
            this.gbUnos.Controls.Add(this.label4);
            this.gbUnos.Controls.Add(this.label3);
            this.gbUnos.Controls.Add(this.label2);
            this.gbUnos.Enabled = false;
            this.gbUnos.Location = new System.Drawing.Point(13, 50);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(404, 494);
            this.gbUnos.TabIndex = 7;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Unos podataka o klijentu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Obrisi rentiranje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj rentiranje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "din.";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(89, 198);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(102, 20);
            this.txtIznos.TabIndex = 15;
            this.txtIznos.Text = "0.00";
            this.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Iznos:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(89, 139);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(291, 20);
            this.txtMail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(89, 113);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(291, 20);
            this.txtKontakt.TabIndex = 11;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(26, 445);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(354, 41);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj klijenta";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(89, 82);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(291, 20);
            this.txtJMBG.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(89, 54);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(291, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(89, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(291, 20);
            this.txtIme.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(244, 10);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(149, 23);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.Text = "Kreiraj klijenta";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(63, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Zemlja:";
            // 
            // cmbZemlja
            // 
            this.cmbZemlja.FormattingEnabled = true;
            this.cmbZemlja.Location = new System.Drawing.Point(89, 165);
            this.cmbZemlja.Name = "cmbZemlja";
            this.cmbZemlja.Size = new System.Drawing.Size(291, 21);
            this.cmbZemlja.TabIndex = 20;
            // 
            // UnosKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 558);
            this.Controls.Add(this.gbUnos);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "UnosKlijenta";
            this.Text = "UnosKlijenta";
            this.Load += new System.EventHandler(this.UnosKlijenta_Load);
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZemlja;
        private System.Windows.Forms.Label label9;
    }
}