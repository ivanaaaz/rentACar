using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Klijent:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime+" "+prezime;
        }

        public Klijent()
        {
            spisakRentiranja = new BindingList<Domen.Rentiranje>();
        }

        int id;
        string ime;
        string prezime;
        string jmbg;
        string kontakt;
        string email;
        double iznosZaNaplatu;
        Zemlja zemlja;

        BindingList<Rentiranje> spisakRentiranja;
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

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
            }
        }

        public string Kontakt
        {
            get
            {
                return kontakt;
            }

            set
            {
                kontakt = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }


        public BindingList<Rentiranje> SpisakRentiranja
        {
            get
            {
                return spisakRentiranja;
            }

            set
            {
                spisakRentiranja = value;
            }
        }

        public double IznosZaNaplatu
        {
            get
            {
                return iznosZaNaplatu;
            }

            set
            {
                iznosZaNaplatu = value;
            }
        }

        [Browsable(false)]
        public Zemlja Zemlja
        {
            get
            {
                return zemlja;
            }

            set
            {
                zemlja = value;
            }
        }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Klijent";
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
                return " (ID) values ("+Id+")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='"+ime+"', Prezime='"+Prezime+"', JMBG='"+jmbg+ "', KOntakt='"+kontakt+"', EMail='"+Email+"', ZaNaplatu="+IznosZaNaplatu+", ZemljaID="+zemlja.Id+"";
            }
        }


        

        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Klijent k = new Klijent();
            k.Id = Convert.ToInt32(red["ID"]);
            k.Ime = red["Ime"].ToString();
            k.Prezime = red["Prezime"].ToString();
            k.Jmbg = red["JMBG"].ToString();
            k.Kontakt = red["Kontakt"].ToString();
            k.Email = red["EMail"].ToString();
            k.IznosZaNaplatu = Convert.ToDouble(red["ZaNaplatu"]);
            k.Zemlja = new Zemlja();
            k.Zemlja.Id = Convert.ToInt32(red["ZemljaID"]);


            return k;
        }
        #endregion ODO
    }
}
