using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.VoziloSO
{
    public class PretraziVozila : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Vozilo v = new Vozilo();
            //v.USLOV = "RegBr is null";
            //Sesija.Broker.dajSesiju().deleteVise(v);
            return Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<Vozilo>().ToList<Vozilo>();
        }
    }
}
