﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.RentiranjeSO
{
    public class VratiSvaVozila : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Vozilo>().ToList<Vozilo>();
        }
    }
}
