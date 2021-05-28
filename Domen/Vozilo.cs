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
    public class Vozilo:OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return regBr + ", " + Marka + "-" + Model; 
        }

        int id;
        string regBr;
        string marka;
        string model;
        TipVozila tip;
        double cena;

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

        public string RegBr
        {
            get
            {
                return regBr;
            }

            set
            {
                regBr = value;
            }
        }

        public string Marka
        {
            get
            {
                return marka;
            }

            set
            {
                marka = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        [Browsable(false)]

        public TipVozila Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                cena = value;
            }
        }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Vozilo";
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
                if (USLOV == null) return " Marka like '" + Marka + "%' or RegBr like '" + RegBr + "%' or Model like '" + Model + "'";
                else return USLOV;
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
                return " RegBR='"+regBr+"', Marka='"+Marka+"', Model='"+Model+"', TipID="+Tip.Id+", CenaPoDanu="+Cena+"";
            }
        }

      

        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Vozilo v = new Vozilo();
            v.Id = Convert.ToInt32(red["ID"]);
            v.RegBr = red["RegBr"].ToString();
            v.Marka = red["Marka"].ToString();
            v.Model = red["Model"].ToString();
            v.Cena = Convert.ToDouble(red["CenaPoDanu"]);
            v.Tip = new TipVozila();
            v.Tip.Id = Convert.ToInt32(red["TipID"]);

            return v;
        }
        #endregion ODO
    }
}
