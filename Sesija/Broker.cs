using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;
        SqlDataReader citac;

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=RentACar2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                konekcija.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da uspostavi konekciju na bazu!");
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zapocne transakciju!");
                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da potvrdi transakciju!");
                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da ponisti transakciju!");
                throw;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne moze da zatvori konekciju!");
                throw;
            }
        }


        public void insert(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Insert into "+odo.Tabela+" "+odo.Insert;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void updateJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Update " + odo.Tabela + " set " + odo.Update+" where "+odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void updateVise(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Update " + odo.Tabela + " set " + odo.Update + " where " + odo.UslovOpsti;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Delete from " + odo.Tabela + " where " + odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteVise(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Delete from " + odo.Tabela + " where " + odo.UslovOpsti;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "Select * from " + odo.Tabela;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                   lista.Add( odo.procitajRed(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaUslovOpsti(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "Select * from " + odo.Tabela+" where "+odo.UslovOpsti;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.procitajRed(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
        {
          
            try
            {
                komanda.CommandText = "Select * from " + odo.Tabela+" where "+odo.UslovID;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);               
              
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public OpstiDomenskiObjekat vratiJedanZaOpstiUslov(OpstiDomenskiObjekat odo)
        {

            try
            {
                komanda.CommandText = "Select * from " + odo.Tabela + " where " + odo.UslovOpsti;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }


        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Select max("+odo.ID+") from "+odo.Tabela;
                Object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else return Convert.ToInt32(o) + 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
