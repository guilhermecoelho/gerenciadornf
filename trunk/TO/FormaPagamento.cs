using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPagamento
{
    [Serializable]
    public class FormaPagamentoTO
    {
        public int IDFormaPagamento{get; set;}
        public String Descricao{get; set;}
        public int QtdParcela{get; set;}
        public int QtdDias{get; set;}
        public String Indicador { get; set; }

    }
}
