using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zemlja : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        int id;
        string naziv;
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public string Tabela => "Zemlja";

        public string ID => "";

      

        public string UslovID => "ID="+id;

        public string UslovOpsti => "";

        public string Insert => "";

        public string Update => "";

       

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Zemlja z = new Zemlja();
            z.Id = Convert.ToInt32(red["ID"]);
            z.Naziv = red["Naziv"].ToString();
            return z;
        }
    }
}
