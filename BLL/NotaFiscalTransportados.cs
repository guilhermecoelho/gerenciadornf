using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscalTransportados;

namespace NotaFiscalTransportados
{
    public class NotaFiscalTransportadosBLL
    {
        public static List<NotaFiscalTransportadosTO> listaNotaFiscalTransportadosAll()
        {
            return NotaFiscalTransportadosDAL.listaNotaFiscalTransportadosAll();
        }
        public static NotaFiscalTransportadosTO GetNotaFiscalTransportadosByID(int ID)
        {
            return NotaFiscalTransportadosDAL.GetNotaFiscalTransportadosByID(ID);
        }
        public static void insert(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {
            NotaFiscalTransportadosDAL.insert(clsNotaFiscalTransportados);
        }
        public static Boolean Delete(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {
            return NotaFiscalTransportadosDAL.Delete(clsNotaFiscalTransportados);
        }
        public static Boolean Update(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {
            return NotaFiscalTransportadosDAL.Update(clsNotaFiscalTransportados);
        }
        
    }
}
