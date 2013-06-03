using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportadora
{
    [Serializable]
    public class TransportadoraTO
    {
        public int IDTransportadora { get; set; }
        public String Nome { get; set; }
        public String RazaoSocial { get; set; }
        public String Cep { get; set; }
        public String Logradura { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Uf { get; set; }
        public String Cidade { get; set; }
        public String Telefone { get; set; }
        public String Cnpj { get; set; }
        public String InscricaoEstadual { get; set; }
        public String Endereco { get; set; }

    }
}
