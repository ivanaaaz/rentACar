using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string Tabela { get; }
        string ID { get; }
        string UslovID { get; }
        string UslovOpsti { get; }
        string Insert { get; }
        string Update { get; }
        OpstiDomenskiObjekat procitajRed(DataRow red);
    }
}
