using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emitente;
using Transportadora;
using Cliente;
using FormaPagamento;

namespace NotaFiscal
{
    [Serializable]
    public class NotaFiscalTO
    {
        public int IDNotaFiscal { get; set; }
        public int IDEmitente { get; set; }
        public int IDTransportadora { get; set; }
        public int IDCliente { get; set; }
        public int iDFormaPagamento { get; set; }

        public Double ValorTotal { get; set; }
        public DateTime DataCadastro{get; set;}

        public EmitenteTO Emitente { get; set; }
        public TransportadoraTO Transportadora { get; set;}
        public ClienteTO Cliente { get; set; }
        public FormaPagamentoTO FormaPagamento { get; set; }

        public String TipoSaidaEntrada { get; set; }
        public DateTime DataSaidaEntrada { get; set; }

        public int QtdTransporte { get; set; }
        public String TipoTransporte { get; set; }
        public String EspecieTransporte {get; set;}
        public String MarcaTransporte { get; set; }
        public int NumeroTransporte { get; set; }
        public Double PesoBruto { get; set; }
        public Double PesoLiquido { get; set; }

        public String NomeEmitente { get; set; }
        public String NomeCliente { get; set; }


    }
}
