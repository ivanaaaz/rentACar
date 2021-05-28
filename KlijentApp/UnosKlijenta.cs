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
    public partial class UnosKlijenta : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public UnosKlijenta()
        {
            InitializeComponent();
        }

        private void UnosKlijenta_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.kreirajKlijenta(txtID,btnKreiraj,gbUnos,dataGridView1,cmbZemlja);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UnosRentiranja().ShowDialog();
            kki.prikaziIznos(txtIznos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kki.obrisiRentiranje(dataGridView1);
            kki.prikaziIznos(txtIznos);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiKlijenta(txtIme,txtJMBG,txtKontakt,txtMail,txtPrezime,cmbZemlja)) this.Close();
        }
    }
}
