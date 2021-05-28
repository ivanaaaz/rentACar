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
    public partial class UnosRentiranja : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public UnosRentiranja()
        {
            InitializeComponent();
        }

        private void UnosRentiranja_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaRentiranje(cmbVozilo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.dodajRentiranje(txtBrDana, dtpDAtu, cmbVozilo)) this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
