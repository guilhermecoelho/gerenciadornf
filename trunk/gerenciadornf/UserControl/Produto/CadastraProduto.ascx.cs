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


        }
        public void Salvar()
        {
            Load();
            if (clsProduto.IDProduto == 0)
            {
                ProdutoBLL.insert(clsProduto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Produto salvo com sucesso')", true);
            }
            else
            {
                ProdutoBLL.Update(clsProduto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Produto editado com sucesso')", true);
            }


        }

        protected void Load()
        {
            clsProduto = this.Produto;
            clsProduto.Descricao = txtDescricao.Text;
            clsProduto.NCM = txtNCM.Text;
            clsProduto.CFOP = txtCFOP.Text;
            clsProduto.UnidadeComercializada = txtUnidadeComercializada.Text;
            clsProduto.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);
            clsProduto.UnidadeTributaria = txtUnidadeTributaria.Text;

            
        }


        private void PopulaDados()
        {
            clsProduto = this.Produto;
            txtDescricao.Text = clsProduto.Descricao;
            txtNCM.Text = clsProduto.NCM;
            txtCFOP.Text = clsProduto.CFOP;
            txtUnidadeComercializada.Text = clsProduto.UnidadeComercializada;
            txtValorUnitario.Text = clsProduto.ValorUnitario.ToString();
            txtUnidadeTributaria.Text = clsProduto.UnidadeTributaria;
        }
    }
}