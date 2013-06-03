using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto;
using Produto;

namespace NotaFiscalProduto
{
    [Serializable]
    public class NotaFiscalProdutoTO
    {
        public int IDNotaFiscalProduto{get; set;}
        public int IDNotaFiscal { get; set; }
        public int IDProduto { get; set; }

        public ProdutoTO Produto { get; set; }
        
        public int QtdProduto { get; set; }
        public Double ValorTotal { get; set; }
        public Double Icms { get; set; }
        public Double Ipi { get; set; }

        public String NomeProduto { get; set; }
        public Double ValorUnitario { get; set; }

    }
}
