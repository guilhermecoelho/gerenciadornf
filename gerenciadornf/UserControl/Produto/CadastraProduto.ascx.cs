using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Produto;

namespace gerenciadornf.UserControl.Produto
{
    public partial class CadastraProduto : System.Web.UI.UserControl
    {
        #region .:property da classe:.
        private ProdutoTO clsProduto = new ProdutoTO();

        public ProdutoTO Produto
        {
            get
            {
                clsProduto = (ProdutoTO)this.ViewState["clsProduto"];
                if (clsProduto == null)
                    clsProduto = new ProdutoTO();
                return clsProduto;
            }
            set
            {
                clsProduto = value;
                this.ViewState["clsProduto"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCFOP.Items.Insert(0, new ListItem("TesteCFOP", "TesteCFOP"));
            ddlCFOP.Items.Insert(1, new ListItem("TesteCFOP2", "TesteCFOP2"));
            ddlUnidadeComercializada.Items.Insert(0, new ListItem("TesteUC", "TesteUC"));
            ddlUnidadeTributaria.Items.Insert(0, new ListItem("TesteUT", "TesteUT"));

        }
        public void Salvar()
        {
            Load();
            if (clsProduto.IDProduto == 0)
            {
                ProdutoBLL.insert(clsProduto);
            }
            else
            {
                ProdutoBLL.Update(clsProduto);
            }


        }

        protected void Load()
        {
            clsProduto = this.Produto;
            clsProduto.Descricao = txtDescricao.Text;
            clsProduto.NCM = txtNCM.Text;
            clsProduto.CFOP = ddlCFOP.SelectedValue;
            clsProduto.UnidadeComercializada = ddlUnidadeComercializada.SelectedValue;
            clsProduto.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);
            clsProduto.UnidadeTributaria = ddlUnidadeTributaria.SelectedValue;

            
        }


        private void PopulaDados()
        {
            clsProduto = this.Produto;
            txtDescricao.Text = clsProduto.Descricao;
            txtNCM.Text = clsProduto.NCM;
            ddlCFOP.SelectedValue = clsProduto.CFOP;
            ddlUnidadeComercializada.SelectedValue = clsProduto.UnidadeComercializada;
            txtValorUnitario.Text = clsProduto.ValorUnitario.ToString();
            ddlUnidadeTributaria.SelectedValue = clsProduto.UnidadeTributaria;
        }
    }
}