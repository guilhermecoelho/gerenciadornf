using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Emitente;

namespace gerenciadornf.UserControl.Emitente
{
    public partial class ListaEmitente : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwEmitente.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<EmitenteTO> clsEmitentes = new List<EmitenteTO>();
            clsEmitentes = EmitenteBLL.listaEmitenteAll();
            gvwEmitente.DataSource = clsEmitentes;
            gvwEmitente.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwEmitente.ActiveViewIndex = 1;
        }
        protected void gvwEmitente_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            EmitenteTO clsEmitente = new EmitenteTO();
            Int32 ID = (Int32)gvwEmitente.DataKeys[e.RowIndex].Value;
            clsEmitente = EmitenteBLL.GetEmitenteByID(ID);
            EmitenteBLL.Delete(clsEmitente);
            LoadGrid();


        }
        protected void gvwEmitente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwEmitente.DataKeys[e.NewEditIndex].Value;
            CadastraEmitente1.Emitente = EmitenteBLL.GetEmitenteByID(ID);
            mvwEmitente.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraEmitente1.Salvar();
                CadastraEmitente1.Emitente = new EmitenteTO();
                mvwEmitente.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    }
}