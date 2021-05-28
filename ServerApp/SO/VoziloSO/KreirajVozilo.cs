using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.VoziloSO
{
    public class KreirajVozilo : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Vozilo v = new Vozilo();
            v.Id = Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(v);
            return v;
        }
    }
}
