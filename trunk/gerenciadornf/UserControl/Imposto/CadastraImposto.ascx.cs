using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Imposto;

namespace gerenciadornf.UserControl.Imposto
{
    public partial class CadastraImposto : System.Web.UI.UserControl
    {
        #region .:property da classe:.
        private ImpostoTO clsImposto = new ImpostoTO();

        public ImpostoTO Imposto
        {
            get
            {
                clsImposto = (ImpostoTO)this.ViewState["clsImposto"];
                if (clsImposto == null)
                    clsImposto = new ImpostoTO();
                return clsImposto;
            }
            set
            {
                clsImposto = value;
                this.ViewState["clsImposto"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlClassificacaoFiscal.Items.Insert(0, new ListItem("todos", string.Empty));
            ddlClassificacaoFiscal.Items.Insert(0, new ListItem("TesteCF", "TesteCF"));

            ddlOrigemMercadoria.Items.Insert(0, new ListItem("todos", string.Empty));
            ddlOrigemMercadoria.Items.Insert(0, new ListItem("TesteOM", "TesteOM"));

            ddlSituacaoTributaria.Items.Insert(0, new ListItem("todos", string.Empty));
            ddlSituacaoTributaria.Items.Insert(0, new ListItem("TesteST", "TesteST"));

            ddlModalidade.Items.Insert(0, new ListItem("todos", string.Empty));
            ddlModalidade.Items.Insert(0, new ListItem("TesteM", "TesteM"));

        }
        public void Salvar()
        {
            Load();
            if (clsImposto.IDImposto == 0)
            {
                ImpostoBLL.insert(clsImposto);
            }
            else
            {
                ImpostoBLL.Update(clsImposto);
            }


        }

        protected void Load()
        {
            clsImposto = this.Imposto;
            clsImposto.Nome = txtNome.Text;
            clsImposto.Descricao = txtDescricao.Text;
            clsImposto.Valor = Convert.ToInt32(txtValor.Text);
            clsImposto.SituacaoTributaria = ddlSituacaoTributaria.SelectedValue;
            clsImposto.OrigemMercadoria = ddlOrigemMercadoria.SelectedValue;
            clsImposto.ClassificacaoFiscal = ddlClassificacaoFiscal.SelectedValue;
            clsImposto.Modalidade = ddlModalidade.SelectedValue;
            clsImposto.AliquitaICMS = Convert.ToDouble(txtAliquitaICMS.Text);
            clsImposto.AliquitaIPI = Convert.ToDouble(txtAliquitaIPI.Text);
            
        }


        private void PopulaDados()
        {
            clsImposto = this.Imposto;
            txtNome.Text = clsImposto.Nome;
            txtDescricao.Text = clsImposto.Descricao;
            txtValor.Text = clsImposto.Valor.ToString();
            ddlSituacaoTributaria.SelectedValue = clsImposto.SituacaoTributaria;
            ddlOrigemMercadoria.SelectedValue = clsImposto.OrigemMercadoria;
            ddlClassificacaoFiscal.SelectedValue = clsImposto.ClassificacaoFiscal;
            ddlModalidade.SelectedValue =  clsImposto.Modalidade;
            txtAliquitaIPI.Text = clsImposto.AliquitaIPI.ToString();
            txtAliquitaICMS.Text = clsImposto.AliquitaICMS.ToString();

        }
    }
}