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
    public partial class DetaljiRentiranja : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public DetaljiRentiranja()
        {
            InitializeComponent();
        }

        private void DetaljiRentiranja_Load(object sender, EventArgs e)
        {
            kki.prikaziDetaljeRentiranja(txtIme,txtIznos,txtJMBG,txtKontakt,txtMail,txtPrezime,dataGridView1,cmbZemlja);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UnosRentiranja().ShowDialog();
            kki.prikaziIznos(txtIznos);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kki.obrisiRentiranje(dataGridView1);
            kki.prikaziIznos(txtIznos);
            dataGridView1.Refresh();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiKlijenta(txtIme, txtJMBG, txtKontakt, txtMail, txtPrezime,cmbZemlja)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kki.obrisiKlijenta()) this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
