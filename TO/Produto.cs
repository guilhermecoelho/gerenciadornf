using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    [Serializable]
    public class ProdutoTO
    {
        public int IDProduto{get; set;}
        public String Descricao{get; set;}
        public String NCM { get; set; }
        public String CFOP { get; set; }
        public String UnidadeComercializada { get; set; }
        public Double ValorUnitario { get; set; }
        public String UnidadeTributaria { get; set; }
    }
}
