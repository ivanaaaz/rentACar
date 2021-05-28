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
    public partial class PretragaVozila : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PretragaVozila()
        {
            InitializeComponent();
        }

        private void PretragaVozila_Load(object sender, EventArgs e)
        {
            kki.pretraziVozila(txtFilter,dataGridView1);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            kki.pretraziVozila(txtFilter, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajVozilo(dataGridView1)) new DetaljiVozila().ShowDialog();
            txtFilter_TextChanged(sender, e);
        }
    }
}
