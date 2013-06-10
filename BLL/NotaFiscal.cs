using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscal;

namespace NotaFiscal
{
    public class NotaFiscalBLL
    {
        public static List<NotaFiscalTO> listaNotaFiscalAll()
        {
            return NotaFiscalDAL.listaNotaFiscalAll();
        }
        public static List<NotaFiscalTO> getNotaFiscalALL()
        {
            return NotaFiscalDAL.GetNotaFiscalAll();
        }
        public static NotaFiscalTO GetNotaFiscalByID(int ID)
        {
            return NotaFiscalDAL.GetNotaFiscalByID(ID);
        }

        public static List<NotaFiscalTO> GetNotaFiscalBusca(String strNumeroNota, int intIDEmitente, int intIDCliente)
        {
            return NotaFiscalDAL.GetNotaFiscalBusca( strNumeroNota,  intIDEmitente,  intIDCliente);
        }
        public static void insert(NotaFiscalTO clsNotaFiscal)
        {
            NotaFiscalDAL.insert(clsNotaFiscal);
        }
        public static Boolean Delete(NotaFiscalTO clsNotaFiscal)
        {
            return NotaFiscalDAL.Delete(clsNotaFiscal);
        }
        public static Boolean Update(NotaFiscalTO clsNotaFiscal)
        {
            return NotaFiscalDAL.Update(clsNotaFiscal);
        }
        
        
    }
}
