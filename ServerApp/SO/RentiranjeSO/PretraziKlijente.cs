using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.RentiranjeSO
{
    public class PretraziKlijente : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<Klijent>().ToList<Klijent>();
        }
    }
}
