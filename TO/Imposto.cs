using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    [Serializable]
    public class ImpostoTO
    {
        public int IDImposto{get; set;}
        public String Nome{get; set;}
        public String Descricao{get; set;}
        public int Valor{get; set;}
        public String ClassificacaoFiscal { get; set; }
        public String OrigemMercadoria { get; set; }
        public String SituacaoTributaria { get; set; }
        public String Modalidade { get; set; }
        public String CodigoIPI { get; set; }
        public double AliquitaICMS { get; set; }
        public double AliquitaIPI { get; set; }
    }
}
