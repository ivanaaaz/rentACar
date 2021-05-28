namespace KlijentApp
{
    partial class UnosRentiranja
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.dtpDAtu = new System.Windows.Forms.DateTimePicker();
            this.txtBrDana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vozilo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj dana:";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(105, 15);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(298, 21);
            this.cmbVozilo.TabIndex = 5;
            // 
            // dtpDAtu
            // 
            this.dtpDAtu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDAtu.Location = new System.Drawing.Point(105, 43);
            this.dtpDAtu.Name = "dtpDAtu";
            this.dtpDAtu.Size = new System.Drawing.Size(106, 20);
            this.dtpDAtu.TabIndex = 6;
            // 
            // txtBrDana
            // 
            this.txtBrDana.Location = new System.Drawing.Point(105, 69);
            this.txtBrDana.Name = "txtBrDana";
            this.txtBrDana.Size = new System.Drawing.Size(106, 20);
            this.txtBrDana.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj rentiranje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnosRentiranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBrDana);
            this.Controls.Add(this.dtpDAtu);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UnosRentiranja";
            this.Text = "UnosRentiranja";
            this.Load += new System.EventHandler(this.UnosRentiranja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.DateTimePicker dtpDAtu;
        private System.Windows.Forms.TextBox txtBrDana;
        private System.Windows.Forms.Button button1;
    }
}