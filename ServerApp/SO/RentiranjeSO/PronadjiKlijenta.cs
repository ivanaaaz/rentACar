using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.RentiranjeSO
{
    public class PronadjiKlijenta : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Klijent k = odo as Klijent;

            k.Zemlja = Broker.dajSesiju().vratiJedanZaID(k.Zemlja) as Zemlja;

            Rentiranje re = new Rentiranje();
            re.USLOV = " KlijentID="+k.Id;
            List<Rentiranje> lista = Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(re).OfType<Rentiranje>().ToList<Rentiranje>();

            foreach (Rentiranje r in lista)
            {

                r.Vozilo = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Vozilo) as Vozilo;
                r.Klijent = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Klijent) as Klijent;
                k.SpisakRentiranja.Add(r);
            }
            return k;
        }
    }
}
