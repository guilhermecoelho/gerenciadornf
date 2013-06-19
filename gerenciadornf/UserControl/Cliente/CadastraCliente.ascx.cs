using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cliente;
using TipoUsuario;

namespace gerenciadornf.UserControl.Cliente
{
    public partial class CadastraCliente : System.Web.UI.UserControl
    {
        
        #region .:property da classe:.

        private ClienteTO clsCliente = new ClienteTO();
        private List<TipoUsuarioTO> clsTipoUsuario = new List<TipoUsuarioTO>();

        public ClienteTO Cliente
        {
            get
            {
                clsCliente = (ClienteTO)this.ViewState["clsCliente"];
                if (clsCliente == null)
                    clsCliente = new ClienteTO();
                return clsCliente;
            }
            set
            {
                clsCliente = value;
                this.ViewState["clsCliente"] = value;
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
            if (clsCliente.IDCliente == 0)
            {
                ClienteBLL.insert(clsCliente);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Cliente salvo com sucesso')", true);
            }
            else
            {
                ClienteBLL.Update(clsCliente);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Cliente editado com sucesso')", true);
            }


        }

        protected void Load()
        {
            clsCliente = this.Cliente;
            clsCliente.Nome = txtNome.Text;
            clsCliente.Email = txtEmail.Text;
            clsCliente.Tipo = txtTipo.Text;
            clsCliente.NomeFantasia = txtNomeFantasia.Text;
            clsCliente.Cep = txtCep.Text;
            clsCliente.Logradura = txtLogradura.Text;
            clsCliente.Numero = txtNumero.Text;
            clsCliente.Complemento = txtComplemento.Text;
            clsCliente.Uf = txtUf.Text;
            clsCliente.Cidade = txtCidade.Text;
            clsCliente.Telefone = txtTelefone.Text;
            clsCliente.Cnpj = txtCnpj.Text;
            clsCliente.Cpf = txtCpf.Text;
            clsCliente.InscricaoEstadual = txtInscricaoEstadual.Text;
            clsCliente.InscricaoMunicipal = txtInscricaoMunicipal.Text;

        }


        private void PopulaDados()
        {

            clsCliente = this.Cliente;

            txtNome.Text = clsCliente.Nome;
            txtEmail.Text = clsCliente.Email;
            txtTipo.Text = Convert.ToString(clsCliente.Tipo);
            txtNomeFantasia.Text = clsCliente.NomeFantasia;
            txtCep.Text = clsCliente.Cep;
            txtLogradura.Text = clsCliente.Logradura;
            txtNumero.Text = clsCliente.Numero;
            txtComplemento.Text = clsCliente.Complemento;
            txtUf.Text = clsCliente.Uf;
            txtCidade.Text = clsCliente.Cidade;
            txtTelefone.Text = clsCliente.Telefone;
            txtCnpj.Text = clsCliente.Cnpj;
            txtCpf.Text = clsCliente.Cpf;
            txtInscricaoEstadual.Text = clsCliente.InscricaoEstadual;
            txtInscricaoMunicipal.Text = clsCliente.InscricaoMunicipal;

        }
    }
}