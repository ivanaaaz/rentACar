using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class ServerForma : Form
    {
        Server s;
       
        public ServerForma()
        {
            InitializeComponent();
           
        }

        private void ServerForma_Load(object sender, EventArgs e)
        {

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new ServerApp.Server();
            if (s.pokreniServer())
            {
                this.Text = "Server je pokrenut!";
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokovaKlijenata.Count > 0)
            {
                MessageBox.Show("Ima jos ulogovanih klijenata!");
                return;
            }

            if (s.zaustaviServer())
            {
                this.Text = "Server nije pokrenut!";
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
