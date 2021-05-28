using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public partial class DetaljiVozila : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public DetaljiVozila()
        {
            InitializeComponent();
        }

        private void DetaljiVozila_Load(object sender, EventArgs e)
        {
            kki.popuniPolja(txtMarka,txtModel,txtRegBR,cmbTip, txtCena);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiVozilo(txtMarka, txtModel, txtRegBR, cmbTip,txtCena)) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.obrisiVozilo()) this.Close();
        }
    }
}
