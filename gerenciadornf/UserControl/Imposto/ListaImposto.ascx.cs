using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Imposto;
namespace gerenciadornf.UserControl.Imposto
{
    public partial class ListaImposto : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwImposto.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<ImpostoTO> clsImpostos = new List<ImpostoTO>();
            clsImpostos = ImpostoBLL.listaImpostoAll();
            gvwImposto.DataSource = clsImpostos;
            gvwImposto.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwImposto.ActiveViewIndex = 1;
        }
        protected void gvwImposto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ImpostoTO clsImposto = new ImpostoTO();
            Int32 ID = (Int32)gvwImposto.DataKeys[e.RowIndex].Value;
            clsImposto = ImpostoBLL.GetImpostoByID(ID);
            ImpostoBLL.Delete(clsImposto);
            LoadGrid();


        }
        protected void gvwImposto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwImposto.DataKeys[e.NewEditIndex].Value;
            CadastraImposto1.Imposto = ImpostoBLL.GetImpostoByID(ID);
            mvwImposto.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraImposto1.Salvar();
                CadastraImposto1.Imposto = new ImpostoTO();
                mvwImposto.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    
    }
}