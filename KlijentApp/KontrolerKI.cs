using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public class KontrolerKI
    {
        static Komunikacija komunikacija;
        static Vozilo vozilo;
        static Klijent klijent;

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if( komunikacija.poveziSeNaServer())
            {
                return "Klijent je povezan na server!";
            }
            else return "Klijent nije povezan na server!";
        }

        internal void prikaziDetaljeRentiranja(TextBox txtIme, TextBox txtIznos, TextBox txtJMBG, TextBox txtKontakt, TextBox txtMail, TextBox txtPrezime, DataGridView dataGridView1, ComboBox cmbZemlja)
        {
            cmbZemlja.DataSource = komunikacija.vratiSveZemlje();

            txtIme.Text = klijent.Ime;
            txtIznos.Text = klijent.IznosZaNaplatu.ToString("N02");
            txtJMBG.Text = klijent.Jmbg;
            txtKontakt.Text = klijent.Kontakt;
            txtMail.Text = klijent.Email;
            txtPrezime.Text = klijent.Prezime;
            cmbZemlja.Text = klijent.Zemlja.ToString();

            dataGridView1.DataSource = klijent.SpisakRentiranja;
        }

        internal bool obrisiKlijenta()
        {
            Object rez = komunikacija.obrisiKlijenta(klijent);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise klijenta!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao klijenta!");
                return true;
            }
        }

        internal void pretraziRentiranja(TextBox txtKlijent, DataGridView dataGridView1)
        {
            klijent = new Klijent ();
            klijent.USLOV = " Ime like '"+txtKlijent.Text+"%' or Prezime like '"+txtKlijent.Text+"%'";
            List<Klijent> lista = komunikacija.pretraziRentiranja(klijent) as List<Klijent>;
            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje klijente!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje klijente za kriterijum!");
                return;
            }
           // MessageBox.Show("Sistem je pronasao klijente!");
        }

        internal bool ucitajRentiranja(DataGridView dataGridView1)
        {
            try
            {
                klijent = dataGridView1.CurrentRow.DataBoundItem as Klijent;

                klijent = komunikacija.ucitajRentiranje(klijent) as Klijent;

                if (klijent == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita rentiranja!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao rentiranja!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali!");
                return false;
            }
        }

        internal void kreirajKlijenta(TextBox txtID, Button btnKreiraj, GroupBox gbUnos, DataGridView dgv, ComboBox cmbZemlja)
        {
            klijent = komunikacija.kreirajKlijenta() as Klijent;

            if (klijent == null)
            {
                MessageBox.Show("Sistem ne moze da kreira klijenta!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao klijneta!");
                txtID.Text = klijent.Id.ToString();
                btnKreiraj.Enabled = false;
                gbUnos.Enabled = true;
                dgv.DataSource = klijent.SpisakRentiranja;
                cmbZemlja.DataSource = komunikacija.vratiSveZemlje();
            }
        }

        internal bool zapamtiKlijenta(TextBox txtIme, TextBox txtJMBG, TextBox txtKontakt, TextBox txtMail, TextBox txtPrezime, ComboBox cmbZemlja)
        {
            klijent.Ime = txtIme.Text;         

            klijent.Prezime = txtPrezime.Text;

            if (klijent.Ime == "" || klijent.Prezime == "")
            {
                MessageBox.Show("Ime i prezime klijenta je obavezno!");
                return false;
            }

            klijent.Jmbg = txtJMBG.Text;
            klijent.Kontakt = txtKontakt.Text;
            klijent.Email = txtMail.Text;
            klijent.Zemlja = cmbZemlja.SelectedItem as Zemlja;


            Object rez = komunikacija.zapamtiRentiranja(klijent);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti klijenta!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio klijenta!");
                return true;
            }

        }

        internal void prikaziIznos(TextBox txtIznos)
        {
            txtIznos.Text = klijent.IznosZaNaplatu.ToString("N02");
        }

        internal bool dodajRentiranje(TextBox txtBrDana, DateTimePicker dtpDAtu, ComboBox cmbVozilo)
        {
            Rentiranje r = new Rentiranje();
            r.Status = Status.Dodato;
            r.Datum = dtpDAtu.Value;
            if (r.Datum.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ne moze retroaktivno rentiranje!");
                return false;
            }

            try
            {
                r.BrDana = Convert.ToInt32(txtBrDana.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nisu ispravo uneti dani!");
                txtBrDana.Focus();
                return false;
            }

            if (r.BrDana <= 0)
            {
                MessageBox.Show("Min rentiranja je jedan dan!");
                txtBrDana.Focus();
                return false;
            }

            r.Vozilo = cmbVozilo.SelectedItem as Vozilo;
            r.Klijent = klijent;

            foreach (Rentiranje re in klijent.SpisakRentiranja)
            {
                if (r.Vozilo.Id == re.Vozilo.Id)
                {
                    if (r.Datum.Date <= re.Datum.Date && r.Datum.AddDays(r.BrDana) > re.Datum.Date)
                    {
                        MessageBox.Show("Preklapaju se rentiranja!");
                        return false;
                    }

                    if (r.Datum.Date > re.Datum.Date && re.Datum.AddDays(re.BrDana) > r.Datum.Date)
                    {
                        MessageBox.Show("Preklapaju se rentiranja!");
                        return false;
                    }
                }
            }

            klijent.IznosZaNaplatu += r.BrDana * r.Vozilo.Cena;

            klijent.SpisakRentiranja.Add(r);
            return true;
        }

      

        internal void obrisiRentiranje(DataGridView dataGridView1)
        {
            try
            {
                Rentiranje r = dataGridView1.CurrentRow.DataBoundItem as Rentiranje;
                if (r.Status == Status.Dodato) klijent.SpisakRentiranja.Remove(r);
                else r.Status = Status.Obrisano;
                klijent.IznosZaNaplatu -= r.Vozilo.Cena * r.BrDana;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali rentiranje");
            }
        }

        internal void popuniPoljaRentiranje( ComboBox cmbVozilo)
        {
           
            cmbVozilo.DataSource = komunikacija.vratiSvaVozila();
            cmbVozilo.Text = "Izaberi!";
           
        }

        internal void popuniPolja(TextBox txtMarka, TextBox txtModel, TextBox txtRegBR, ComboBox cmbTip, TextBox txtCena)
        {
            cmbTip.DataSource = komunikacija.vratiSveTipove();

            txtMarka.Text = vozilo.Marka;
            txtModel.Text = vozilo.Model;
            txtRegBR.Text = vozilo.RegBr;
            txtCena.Text = vozilo.Cena.ToString();
            cmbTip.Text = vozilo.Tip.ToString();
        }

        internal bool obrisiVozilo()
        {
            Object rez = komunikacija.obrisiVozilo(vozilo);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise vozilo!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao vozilo!");
                return true;
            }
        }

        internal void pretraziVozila(TextBox txtFilter, DataGridView dataGridView1)
        {
            vozilo = new Vozilo();
            vozilo.Marka = txtFilter.Text;
            vozilo.Model = txtFilter.Text;
            vozilo.RegBr = txtFilter.Text;

          

            List<Vozilo> lista = komunikacija.pretraziVozila(vozilo) as List<Vozilo>;
            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje vozila!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje vozila za zadati  kriterijum!");
                return;

            }
           
            MessageBox.Show("Sistem je pronasao vozila!");

        }

        internal bool ucitajVozilo(DataGridView dataGridView1)
        {
            try
            {
                vozilo = dataGridView1.CurrentRow.DataBoundItem as Vozilo;
                vozilo = komunikacija.ucitajVozilo(vozilo) as Vozilo;

                if (vozilo == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita vozilo!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao vozilo!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali!");
                return false;
            }
        }

        internal void kreirajVozilo(TextBox txtID, ComboBox cmbTip, Button btnKreiraj, GroupBox gbUnos)
        {
            vozilo = komunikacija.kreirajVozilo() as Vozilo;

            if (vozilo == null)
            {
                MessageBox.Show("Sistem ne moze da kreira vozilo!");

            }
            else
            {
                MessageBox.Show("Sistem je kreirao vozilo!");
                txtID.Text = vozilo.Id.ToString();
                cmbTip.DataSource = komunikacija.vratiSveTipove();
                cmbTip.Text = "Izaberi tip vozila!";
                btnKreiraj.Enabled = false;
                gbUnos.Enabled = true;
            }
        }

        internal bool zapamtiVozilo(TextBox txtMarka, TextBox txtModel, TextBox txtRegBR, ComboBox cmbTip, TextBox txtCena)
        {
            vozilo.RegBr = txtRegBR.Text;
            if (vozilo.RegBr == "")
            {
                MessageBox.Show("Fali ti reg br!");
                txtRegBR.Focus();
                return false;
            }

            vozilo.Model = txtModel.Text;
            if (vozilo.Model == "")
            {
                MessageBox.Show("Fali ti model!");
                txtModel.Focus();
                return false;
            }

            vozilo.Marka = txtMarka.Text;
            if (vozilo.Marka == "")
            {
                MessageBox.Show("Fali ti marka!");
                txtMarka.Focus();
                return false;
            }

            vozilo.Tip = cmbTip.SelectedItem as TipVozila;
            if (vozilo.Tip == null)
            {
                MessageBox.Show("Fali tip!");
                return false;
            }

            try
            {
                vozilo.Cena = Convert.ToDouble(txtCena.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Cena vozila nije validno uneta!");
                return false;
            }

            Object rez = komunikacija.zapamtiVozilo(vozilo);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti vozilo!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio vozilo!");
                return true;
            }
        }

        public static void kraj()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception)
            {


            }
        }
    }
}
