using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    [Serializable]
    public class ClienteTO
    {
        public int IDCliente{get; set;}
        public String Nome{get; set;}
        public String Email{get; set;}
        public int Tipo{get; set;}
        public String NomeFantasia{get; set;}
        public String Cep{get; set;}
        public String Logradura{get; set;}
        public String Numero{get; set;}
        public String Complemento{get; set;}
        public String Uf{get; set;}
        public String Cidade{get; set;}
        public String Telefone{get; set;}
        public String Cnpj{get; set;}
        public String Cpf{get; set;}
        public String InscricaoEstadual{get; set;}
        public String InscricaoMunicipal{get; set;}
        public String Endereco { get; set; }
    }
}
