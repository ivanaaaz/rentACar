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
    public partial class PretragaKlijenata : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PretragaKlijenata()
        {
            InitializeComponent();
        }

        private void PretragaKlijenata_Load(object sender, EventArgs e)
        {
            kki.pretraziRentiranja(txtKlijent, dataGridView1);
        }

        private void txtKlijent_TextChanged(object sender, EventArgs e)
        {
            kki.pretraziRentiranja(txtKlijent, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajRentiranja(dataGridView1)) new DetaljiRentiranja().ShowDialog();
            txtKlijent_TextChanged(sender, e);
        }
    }
}
