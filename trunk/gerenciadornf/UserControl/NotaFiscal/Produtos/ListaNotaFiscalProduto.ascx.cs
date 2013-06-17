using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotaFiscalProduto;
using NotaFiscal;
using Produto;

namespace gerenciadornf.UserControl.NotaFiscal.Produtos
{
    public partial class ListaNotaFiscalProduto : System.Web.UI.UserControl
    {
        private List<NotaFiscalProdutoTO> clsNotaFiscalProduto = new List<NotaFiscalProdutoTO>();
        private List<NotaFiscalTO> clsNotasFiscais = new List<NotaFiscalTO>();
        private NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

        public int idNotaFiscal
        {
            get
            {
                object id = this.ViewState["idNotaFiscal"];
                if (id == null)
                    return new int();
                else
                    return (int)id;
            }

            set
            {
                this.ViewState["idNotaFiscal"] = value;
            }
        }

        public List<NotaFiscalProdutoTO> NotaFiscalProduto
        {
            get
            {
                clsNotaFiscalProduto = (List<NotaFiscalProdutoTO>)this.ViewState["clsNotaFiscalProduto"];
                if (clsNotaFiscalProduto == null)
                    clsNotaFiscalProduto = new List<NotaFiscalProdutoTO>();
                return clsNotaFiscalProduto;
            }
            set
            {
                clsNotaFiscalProduto = value;
                this.ViewState["clsNotaFiscalProduto"] = value;
            }

        }
        public List<NotaFiscalTO> NotasFiscais
        {
            get
            {
                clsNotasFiscais = (List<NotaFiscalTO>)this.ViewState["clsNotasFiscais"];
                if (clsNotaFiscalProduto == null)
                    clsNotasFiscais = new List<NotaFiscalTO>();
                return clsNotasFiscais;
            }
            set
            {
                clsNotasFiscais = value;
                this.ViewState["clsNotasFiscais"] = value;
            }

        }
        public NotaFiscalTO NotaFiscal
        {
            get
            {
                clsNotaFiscal = (NotaFiscalTO)this.ViewState["clsNotaFiscal"];
                if (clsNotaFiscalProduto == null)
                    clsNotaFiscal = new NotaFiscalTO();
                return clsNotaFiscal;
            }
            set
            {
                clsNotaFiscal = value;
                this.ViewState["clsNotaFiscal"] = value;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void LoadGrid()
        {
            List<NotaFiscalTO> clsNotaFiscal = new List<NotaFiscalTO>();
            clsNotaFiscal = NotaFiscalBLL.listaNotaFiscalAll();
            gvNotaFiscal.DataSource = clsNotaFiscal;
            gvNotaFiscal.DataBind();
        }


        protected void gvNotaFiscal_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            this.idNotaFiscal = (int)gvNotaFiscal.DataKeys[e.NewSelectedIndex].Value;

            this.NotaFiscalProduto = NotaFiscalProdutoBLL.getNotaFiscalProdutoByNF(idNotaFiscal);

            LoadGrid();
            LoadGridNotaFiscalProduto();
        }
        public void LoadGridNotaFiscalProduto()
        {

                ddlProdutos.Visible = true;
                txtICMS.Visible = true;
                txtIPI.Visible = true;
                txtQuantidade.Visible = true;

                lblIcms.Visible = true;
                lblIpi.Visible = true;
                lblProduto.Visible = true;
                lblQuantidade.Visible = true;
                btnIncluirProduto.Visible = true;

                List<ProdutoTO> clsProdutos = new List<ProdutoTO>();
                clsProdutos = ProdutoBLL.listaProdutoAll();

                ddlProdutos.DataSource = clsProdutos;
                ddlProdutos.DataTextField = "descricao";// Visualização
                ddlProdutos.DataValueField = "idproduto"; //Valor

                ddlProdutos.DataBind();

                gvwNotaFiscalProduto.DataSource = this.NotaFiscalProduto;
                gvwNotaFiscalProduto.DataBind();


        }

        protected void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            NotaFiscalProdutoTO clsNotaFiscalProduto = new NotaFiscalProdutoTO();
            ProdutoTO clsProduto = new ProdutoTO();

            clsNotaFiscalProduto.IDNotaFiscal = this.idNotaFiscal;
            int idProduto = 0;
            int.TryParse(ddlProdutos.SelectedValue, out idProduto);
            clsNotaFiscalProduto.IDProduto = idProduto;

            clsProduto = ProdutoBLL.GetProdutoByID(idProduto);
            clsNotaFiscalProduto.ValorUnitario = clsProduto.ValorUnitario;
            
            clsNotaFiscalProduto.QtdProduto = Convert.ToInt32(txtQuantidade.Text); 
            clsNotaFiscalProduto.Icms = Convert.ToDouble(txtICMS.Text);
            clsNotaFiscalProduto.Ipi = Convert.ToDouble(txtIPI.Text);

            NotaFiscalProdutoBLL.insert(clsNotaFiscalProduto);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('produto incluido com sucesso')", true);

            LoadGridNotaFiscalProduto();
        }

        protected void gvwNotaFiscalProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            NotaFiscalProdutoTO clsNotaFiscalProduto = new NotaFiscalProdutoTO();
            Int32 ID = (Int32)gvwNotaFiscalProduto.DataKeys[e.RowIndex].Value;
            clsNotaFiscalProduto = NotaFiscalProdutoBLL.GetNotaFiscalProdutoByID(ID);
            NotaFiscalProdutoBLL.Delete(clsNotaFiscalProduto);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('produto excluido com sucesso')", true);

            LoadGrid();
            LoadGridNotaFiscalProduto();
            
        }
    }
}