using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transportadora;
using TipoUsuario;

namespace gerenciadornf.UserControl.Transportadora
{
    public partial class CadastraTransportadora : System.Web.UI.UserControl
    {
        
        #region .:property da classe:.

        private TransportadoraTO clsTransportadora = new TransportadoraTO();
        private List<TipoUsuarioTO> clsTipoUsuario = new List<TipoUsuarioTO>();

        public TransportadoraTO Transportadora
        {
            get
            {
                clsTransportadora = (TransportadoraTO)this.ViewState["clsTransportadora"];
                if (clsTransportadora == null)
                    clsTransportadora = new TransportadoraTO();
                return clsTransportadora;
            }
            set
            {
                clsTransportadora = value;
                this.ViewState["clsTransportadora"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Salvar()
        {
            Load();
            if (clsTransportadora.IDTransportadora == 0)
            {
                TransportadoraBLL.insert(clsTransportadora);
            }
            else
            {
                TransportadoraBLL.Update(clsTransportadora);
            }


        }

        protected void Load()
        {
            clsTransportadora = this.Transportadora;
            clsTransportadora.Nome = txtNome.Text;
            clsTransportadora.RazaoSocial = txtRazaoSocial.Text;
            clsTransportadora.Cep = txtCep.Text;
            clsTransportadora.Logradura = txtLogradura.Text;
            clsTransportadora.Numero = txtNumero.Text;
            clsTransportadora.Complemento = txtComplemento.Text;
            clsTransportadora.Uf = txtUf.Text;
            clsTransportadora.Cidade = txtCidade.Text;
            clsTransportadora.Telefone = txtTelefone.Text;
            clsTransportadora.Cnpj = txtCnpj.Text;

            clsTransportadora.InscricaoEstadual = txtInscricaoEstadual.Text;


        }


        private void PopulaDados()
        {

            clsTransportadora = this.Transportadora;

            txtNome.Text = clsTransportadora.Nome;
            txtRazaoSocial.Text = clsTransportadora.RazaoSocial;

            txtCep.Text = clsTransportadora.Cep;
            txtLogradura.Text = clsTransportadora.Logradura;
            txtNumero.Text = clsTransportadora.Numero;
            txtComplemento.Text = clsTransportadora.Complemento;
            txtUf.Text = clsTransportadora.Uf;
            txtCidade.Text = clsTransportadora.Cidade;
            txtTelefone.Text = clsTransportadora.Telefone;
            txtCnpj.Text = clsTransportadora.Cnpj;

            txtInscricaoEstadual.Text = clsTransportadora.InscricaoEstadual;


        }
    }
}