using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;

namespace Cliente
{
    public class ClienteBLL
    {
        public static List<ClienteTO> listaClienteAll()
        {
            return ClienteDAL.listaClienteAll();
        }
        public static ClienteTO GetClienteByID(int ID)
        {
            return ClienteDAL.GetClienteByID(ID);
        }
        public static void insert(ClienteTO clsCliente)
        {
            ClienteDAL.insert(clsCliente);
        }
        public static Boolean Delete(ClienteTO clsCliente)
        {
            return ClienteDAL.Delete(clsCliente);
        }
        public static Boolean Update(ClienteTO clsCliente)
        {
            return ClienteDAL.Update(clsCliente);
        }
        
    }
}
