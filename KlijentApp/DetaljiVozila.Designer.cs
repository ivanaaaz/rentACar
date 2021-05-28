namespace KlijentApp
{
    partial class DetaljiVozila
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRegBR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbUnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUnos
            // 
            this.gbUnos.Controls.Add(this.txtCena);
            this.gbUnos.Controls.Add(this.label6);
            this.gbUnos.Controls.Add(this.button1);
            this.gbUnos.Controls.Add(this.btnSacuvaj);
            this.gbUnos.Controls.Add(this.cmbTip);
            this.gbUnos.Controls.Add(this.txtModel);
            this.gbUnos.Controls.Add(this.txtMarka);
            this.gbUnos.Controls.Add(this.txtRegBR);
            this.gbUnos.Controls.Add(this.label5);
            this.gbUnos.Controls.Add(this.label4);
            this.gbUnos.Controls.Add(this.label3);
            this.gbUnos.Controls.Add(this.label2);
            this.gbUnos.Location = new System.Drawing.Point(12, 12);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(404, 324);
            this.gbUnos.TabIndex = 4;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Izmena podataka o vozilu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Obrisi vozilo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(26, 217);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(354, 41);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Izmeni vozilo";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(106, 127);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(274, 21);
            this.cmbTip.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(106, 96);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(274, 20);
            this.txtModel.TabIndex = 10;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(106, 68);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(274, 20);
            this.txtMarka.TabIndex = 9;
            // 
            // txtRegBR
            // 
            this.txtRegBR.Location = new System.Drawing.Point(106, 38);
            this.txtRegBR.Name = "txtRegBR";
            this.txtRegBR.Size = new System.Drawing.Size(274, 20);
            this.txtRegBR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tip vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reg broj:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(106, 158);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(274, 20);
            this.txtCena.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cena po danu:";
            // 
            // DetaljiVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 348);
            this.Controls.Add(this.gbUnos);
            this.Name = "DetaljiVozila";
            this.Text = "DetaljiVozila";
            this.Load += new System.EventHandler(this.DetaljiVozila_Load);
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRegBR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label6;
    }
}