using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        KreirajVozilo = 2,
        ZapamtiVozilo = 3,
        ObrisiVozilo = 4,
        PretraziVozila = 5,
        UcitajVozilo = 6,
        VratiSveTipove = 7,
        ZapamtiRentiranje = 8,
        PretraziRentiranja = 9,
        UcitajRentiranje = 10,
        VratiSvaVozila = 11,
        VratiSveKlijente = 12,
        KreirajKlijenta = 13,
        ObrisiKlijenta = 14,
        VratiSveZemlje = 15
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
