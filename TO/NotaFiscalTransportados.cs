using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalTransportados
{
    [Serializable]
    public class NotaFiscalTransportadosTO
    {
        public int IDNotaFiscalTransportados{get; set;}
        public int IDNotaFiscal { get; set; }
        public int Qtd { get; set; }
        public String Especie { get; set; }
        public String Marca { get; set; }
        public String Numero { get; set; }
        public Double PesoBruto { get; set; }
        public Double PesoLiquido { get; set; }
    }
}
