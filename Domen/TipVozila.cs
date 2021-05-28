using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class TipVozila : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv + " " + BrSedista;
        }



        int id;
        string naziv;
        string opis;
        string brSedista;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string BrSedista
        {
            get
            {
                return brSedista;
            }

            set
            {
                brSedista = value;
            }
        }

        #region ODO
        public string Tabela
        {
            get
            {
                return "TipVozila";
            }
        }

        public string ID
        {
            get
            {
                return "ID";
            }
        }

        public string UslovID
        {
            get
            {
                return "ID="+Id;
            }
        }

      
        public string UslovOpsti
        {
            get
            {
                return " Naziv like '"+Naziv+"%'";
            }
        }

        public string Insert
        {
            get
            {
                return null;
            }
        }

        public string Update
        {
            get
            {
                return null;
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            TipVozila t = new TipVozila();
            t.Id = Convert.ToInt32(red["ID"]);
            t.Naziv = red["Naziv"].ToString();
            t.Opis = red["Opis"].ToString();
            t.BrSedista = red["BrSedista"].ToString();

            return t;
        }
        #endregion ODO
    }
}

