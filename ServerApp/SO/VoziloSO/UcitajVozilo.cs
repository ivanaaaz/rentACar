using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.VoziloSO
{
    public class UcitajVozilo : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Vozilo v = odo as Vozilo;
            v.Tip = Sesija.Broker.dajSesiju().vratiJedanZaID(v.Tip) as TipVozila;
            return v;
        }
    }
}
