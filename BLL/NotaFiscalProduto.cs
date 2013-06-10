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
            Double dblValorTotalSemImposto = 0;
            Double dblValorIPI = 0;
            Double dblValorICMS = 0;

            dblValorTotalSemImposto = clsNotaFiscalProduto.ValorUnitario * clsNotaFiscalProduto.QtdProduto;

            if (clsNotaFiscalProduto.Ipi != 0)
            {
                dblValorIPI = dblValorTotalSemImposto * (clsNotaFiscalProduto.Ipi / 100);
            }
            if (clsNotaFiscalProduto.Icms != 0)
            {
                dblValorICMS = dblValorTotalSemImposto * (clsNotaFiscalProduto.Icms / 100);
            }

            clsNotaFiscalProduto.ValorTotal = dblValorTotalSemImposto + dblValorIPI + dblValorICMS;

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
