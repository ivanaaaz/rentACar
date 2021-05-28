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
    public partial class PocetnaForma : Form
    {
        
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.poveziSeNaServer();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.kraj();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosVozila().ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaVozila().ShowDialog();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UnosKlijenta().ShowDialog();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PretragaKlijenata().ShowDialog();
        }
    }
}
