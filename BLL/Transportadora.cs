using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportadora;

namespace Transportadora
{
    public class TransportadoraBLL
    {
        public static List<TransportadoraTO> listaTransportadoraAll()
        {
            return TransportadoraDAL.listaTransportadoraAll();
        }
        public static TransportadoraTO GetTransportadoraByID(int ID)
        {
            return TransportadoraDAL.GetTransportadoraByID(ID);
        }
        public static void insert(TransportadoraTO clsTransportadora)
        {
            TransportadoraDAL.insert(clsTransportadora);
        }
        public static Boolean Delete(TransportadoraTO clsTransportadora)
        {
            return TransportadoraDAL.Delete(clsTransportadora);
        }
        public static Boolean Update(TransportadoraTO clsTransportadora)
        {
            return TransportadoraDAL.Update(clsTransportadora);
        }
        
    }
}
