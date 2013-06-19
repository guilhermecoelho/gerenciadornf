using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transportadora;

namespace gerenciadornf.UserControl.Transportadora
{
    public partial class ListaTransportadora : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwTransportadora.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<TransportadoraTO> clsTransportadoras = new List<TransportadoraTO>();
            clsTransportadoras = TransportadoraBLL.listaTransportadoraAll();
            gvwTransportadora.DataSource = clsTransportadoras;
            gvwTransportadora.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwTransportadora.ActiveViewIndex = 1;
        }
        protected void gvwTransportadora_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TransportadoraTO clsTransportadora = new TransportadoraTO();
            Int32 ID = (Int32)gvwTransportadora.DataKeys[e.RowIndex].Value;
            clsTransportadora = TransportadoraBLL.GetTransportadoraByID(ID);
            TransportadoraBLL.Delete(clsTransportadora);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Transportadora excluida com sucesso')", true);
            LoadGrid();


        }
        protected void gvwTransportadora_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwTransportadora.DataKeys[e.NewEditIndex].Value;
            CadastraTransportadora1.Transportadora = TransportadoraBLL.GetTransportadoraByID(ID);
            mvwTransportadora.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraTransportadora1.Salvar();
                CadastraTransportadora1.Transportadora = new TransportadoraTO();
                mvwTransportadora.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    }
}