using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormaPagamento;

namespace FormaPagamento
{
    public class FormaPagamentoBLL
    {
        public static List<FormaPagamentoTO> listaFormaPagamentoAll()
        {
            return FormaPagamentoDAL.listaFormaPagamentoAll();
        }
        public static FormaPagamentoTO GetFormaPagamentoByID(int ID)
        {
            return FormaPagamentoDAL.GetFormaPagamentoByID(ID);
        }
        public static void insert(FormaPagamentoTO clsFormaPagamento)
        {
            FormaPagamentoDAL.insert(clsFormaPagamento);
        }
        public static Boolean Delete(FormaPagamentoTO clsFormaPagamento)
        {
            return FormaPagamentoDAL.Delete(clsFormaPagamento);
        }
        public static Boolean Update(FormaPagamentoTO clsFormaPagamento)
        {
            return FormaPagamentoDAL.Update(clsFormaPagamento);
        }
    }
}
