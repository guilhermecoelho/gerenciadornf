using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscalProduto;

namespace NotaFiscalProduto
{
    public class NotaFiscalProdutoBLL
    {
        public static List<NotaFiscalProdutoTO> listaNotaFiscalProdutoAll()
        {
            return NotaFiscalProdutoDAL.listaNotaFiscalProdutoAll();
        }
        public static NotaFiscalProdutoTO GetNotaFiscalProdutoByID(int ID)
        {
            return NotaFiscalProdutoDAL.GetNotaFiscalProdutoByID(ID);
        }

        public static List<NotaFiscalProdutoTO> getNotaFiscalProdutoByNF(int IDNotaFiscal)
        {
            return NotaFiscalProdutoDAL.getNotaFiscalProdutoByNF(IDNotaFiscal);
        }

        public static void insert(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {
            NotaFiscalProdutoDAL.insert(clsNotaFiscalProduto);
        }
        public static Boolean Delete(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {
            return NotaFiscalProdutoDAL.Delete(clsNotaFiscalProduto);
        }
        public static Boolean Update(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {
            return NotaFiscalProdutoDAL.Update(clsNotaFiscalProduto);
        }
        
    }
}
