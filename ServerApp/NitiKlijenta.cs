using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using ServerApp.SO.VoziloSO;
using ServerApp.SO.RentiranjeSO;

namespace ServerApp
{
    class NitiKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitiKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart nitDelegat = obradiZahtev;
            new Thread(nitDelegat).Start();
        }

        void obradiZahtev()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {
                        case Operacije.KreirajVozilo:
                            KreirajVozilo kv = new SO.VoziloSO.KreirajVozilo();
                            transfer.Rezultat = kv.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiVozilo:
                            ZapamtiVozilo zv = new ZapamtiVozilo();
                            transfer.Rezultat = zv.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiVozilo:
                            ObrisiVozilo ov = new ObrisiVozilo();
                            transfer.Rezultat = ov.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveZemlje:
                            VratiSveZemlje vsz = new VratiSveZemlje();
                            transfer.Rezultat = vsz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziVozila:
                            PretraziVozila pv = new PretraziVozila();
                            transfer.Rezultat = pv.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajVozilo:
                            UcitajVozilo uv = new UcitajVozilo();
                            transfer.Rezultat = uv.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiRentiranje:
                            ZapamtiKlijenta zr = new ZapamtiKlijenta();
                            transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziRentiranja:
                            PretraziKlijente pr = new PretraziKlijente();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajRentiranje:
                            PronadjiKlijenta ur = new PronadjiKlijenta();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSvaVozila:
                            VratiSvaVozila vsv = new VratiSvaVozila();
                            transfer.Rezultat = vsv.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveKlijente:
                            VratiSveKljente vsk = new VratiSveKljente();
                            transfer.Rezultat = vsk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;



                        case Operacije.VratiSveTipove:
                            VratiSveTipoveVozila vst = new VratiSveTipoveVozila();
                            transfer.Rezultat = vst.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajKlijenta:
                            KreirajKlijenta kk = new KreirajKlijenta();
                            transfer.Rezultat = kk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiKlijenta:
                            ObrisiKlijenta ok = new ObrisiKlijenta();
                            transfer.Rezultat = ok.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokovaKlijenata.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.listaTokovaKlijenata.Remove(tok);
                }
                catch (Exception)
                {

                   
                }
               
            }
        }
    }
}
