using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Produto;
namespace gerenciadornf.UserControl.Produto
{
    public partial class ListaProduto : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwProduto.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<ProdutoTO> clsProdutos = new List<ProdutoTO>();
            clsProdutos = ProdutoBLL.listaProdutoAll();
            gvwProduto.DataSource = clsProdutos;
            gvwProduto.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwProduto.ActiveViewIndex = 1;
        }
        protected void gvwProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ProdutoTO clsProduto = new ProdutoTO();
            Int32 ID = (Int32)gvwProduto.DataKeys[e.RowIndex].Value;
            clsProduto = ProdutoBLL.GetProdutoByID(ID);
            ProdutoBLL.Delete(clsProduto);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Produto excluido com sucesso')", true);
            LoadGrid();


        }
        protected void gvwProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwProduto.DataKeys[e.NewEditIndex].Value;
            CadastraProduto1.Produto = ProdutoBLL.GetProdutoByID(ID);
            mvwProduto.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraProduto1.Salvar();
                CadastraProduto1.Produto = new ProdutoTO();
                mvwProduto.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    
    }
}