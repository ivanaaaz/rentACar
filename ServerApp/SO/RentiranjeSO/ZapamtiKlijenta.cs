using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.RentiranjeSO
{
    public class ZapamtiKlijenta : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Klijent k = odo as Klijent;

            Sesija.Broker.dajSesiju().updateJedan(k);

            foreach (Rentiranje r in k.SpisakRentiranja)
            {
                switch (r.Status)
                {
                   
                    case Status.Dodato:
                        r.Id = Sesija.Broker.dajSesiju().vratiSifru(r);
                        Sesija.Broker.dajSesiju().insert(r);
                        break;
                    case Status.Izmenjeno:
                        Sesija.Broker.dajSesiju().updateJedan(r);
                        break;
                    case Status.Obrisano:
                        Sesija.Broker.dajSesiju().deleteJedan(r);

                        break;
                    default:
                        break;
                }
            }

            return true;
        }
    }
}
