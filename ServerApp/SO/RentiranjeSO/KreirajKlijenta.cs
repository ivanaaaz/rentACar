using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.RentiranjeSO
{
    public class KreirajKlijenta : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Klijent k = new Klijent();
            k.Id = Sesija.Broker.dajSesiju().vratiSifru(k);
            Sesija.Broker.dajSesiju().insert(k);
            return k;
        }
    }
}
