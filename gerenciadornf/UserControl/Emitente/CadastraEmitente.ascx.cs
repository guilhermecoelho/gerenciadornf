using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Emitente;

namespace gerenciadornf.UserControl.Emitente
{
    public partial class CadastraEmitente : System.Web.UI.UserControl
    {
        private EmitenteTO clsEmitente = new EmitenteTO();

        public EmitenteTO Emitente
        {
            get
            {
                clsEmitente = (EmitenteTO)this.ViewState["clsEmitente"];
                if (clsEmitente == null)
                    clsEmitente = new EmitenteTO();
                return clsEmitente;
            }
            set
            {
                clsEmitente = value;
                this.ViewState["clsEmitente"] = value;
                PopulaDados();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Salvar()
        {
            Load();
            if (clsEmitente.IDEmitente == 0)
            {
                EmitenteBLL.insert(clsEmitente);
            }
            else
            {
                EmitenteBLL.Update(clsEmitente);
            }


        }

        protected void Load()
        {
            clsEmitente = this.Emitente;
            clsEmitente.Nome = txtNome.Text;
            clsEmitente.NomeFantasia = txtNomeFantasia.Text;
            clsEmitente.Cep = txtCep.Text;
            clsEmitente.Logradura = txtLogradura.Text;
            clsEmitente.Numero = txtNumero.Text;
            clsEmitente.Complemento = txtComplemento.Text;
            clsEmitente.Uf = txtUf.Text;
            clsEmitente.Cidade = txtCidade.Text;
            clsEmitente.Telefone = txtTelefone.Text;
            clsEmitente.Cnpj = txtCnpj.Text;
            clsEmitente.InscricaoEstadual = txtInscricaoEstadual.Text;
            clsEmitente.CertDigital = txtCertDigital.Text;

        }


        private void PopulaDados()
        {

            clsEmitente = this.Emitente;

            txtNome.Text = clsEmitente.Nome;
            txtNomeFantasia.Text = clsEmitente.NomeFantasia;
            txtCep.Text = clsEmitente.Cep;
            txtLogradura.Text = clsEmitente.Logradura;
            txtNumero.Text = clsEmitente.Numero;
            txtComplemento.Text = clsEmitente.Complemento;
            txtUf.Text = clsEmitente.Uf;
            txtCidade.Text = clsEmitente.Cidade;
            txtTelefone.Text = clsEmitente.Telefone;
            txtCnpj.Text = clsEmitente.Cnpj;
            txtInscricaoEstadual.Text = clsEmitente.InscricaoEstadual;
            txtCertDigital.Text = clsEmitente.CertDigital;

        }
    }
}