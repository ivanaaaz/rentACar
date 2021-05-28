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

namespace ServerApp
{
    public  class Server
    {
        Socket soket;
        Thread nit;
        public static List<NetworkStream> listaTokovaKlijenata = new List<NetworkStream>();
        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 11000);
                soket.Bind(ep);

                ThreadStart nitDelgat = osluskuj;
                nit = new Thread(nitDelgat);
                nit.Start();


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool zaustaviServer()
        {
            try
            {
                soket.Close();                
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        void osluskuj()
        {
            while (true)
            {
                try
                {
                    soket.Listen(5);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new NitiKlijenta(tok);
                    listaTokovaKlijenata.Add(tok);
                }
                catch (Exception)
                {

                    
                }
            }
        }
    }
}
