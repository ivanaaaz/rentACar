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
    public partial class UnosVozila : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public UnosVozila()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.kreirajVozilo(txtID, cmbTip, btnKreiraj, gbUnos);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiVozilo(txtMarka,txtModel,txtRegBR,cmbTip,txtCena)) this.Close();
        }
    }
}
