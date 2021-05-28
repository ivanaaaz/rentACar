using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Status { NijeMenjano, Dodato, Izmenjeno, Obrisano}
    [Serializable]
    public class Rentiranje : OpstiDomenskiObjekat
    {

        int id;
        Klijent klijent;
        Vozilo vozilo;
        DateTime datum;
        int brDana;
        Status status;

        [Browsable(false)]
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
        [Browsable(false)]
        public Klijent Klijent
        {
            get
            {
                return klijent;
            }

            set
            {
                klijent = value;
            }
        }

        public Vozilo Vozilo
        {
            get
            {
                return vozilo;
            }

            set
            {
                vozilo = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public int BrDana
        {
            get
            {
                return brDana;
            }

            set
            {
                brDana = value;
            }
        }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Rentiranje";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "ID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "ID=" + Id;
            }
        }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " values ("+Id+","+klijent.Id+","+vozilo.Id+",'"+Datum.ToString("yyyy-MM-dd")+"',"+BrDana+")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Datum='"+datum.ToString("yyyy-MM-dd") +"', BrojDana="+BrDana+" ";
            }
        }

        public Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Rentiranje r = new Rentiranje();
            r.Id = Convert.ToInt32(red["ID"]);
            r.Klijent = new Domen.Klijent();
            r.Klijent.Id = Convert.ToInt32(red["KlijentID"]);
            r.Vozilo = new Domen.Vozilo();
            r.Vozilo.Id = Convert.ToInt32(red["VoziloID"]);
            r.Datum = Convert.ToDateTime(red["Datum"]);
            r.BrDana = Convert.ToInt32(red["BrojDana"]);
            
            return r;
        }
        #endregion ODO

    }
}
