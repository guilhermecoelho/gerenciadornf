using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cliente;

namespace gerenciadornf.UserControl.Cliente
{
    public partial class ListaCliente : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwCliente.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<ClienteTO> clsClientes = new List<ClienteTO>();
            clsClientes = ClienteBLL.listaClienteAll();
            gvwCliente.DataSource = clsClientes;
            gvwCliente.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwCliente.ActiveViewIndex = 1;
        }
        protected void gvwCliente_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ClienteTO clsCliente = new ClienteTO();
            Int32 ID = (Int32)gvwCliente.DataKeys[e.RowIndex].Value;
            clsCliente = ClienteBLL.GetClienteByID(ID);
            ClienteBLL.Delete(clsCliente);
            LoadGrid();


        }
        protected void gvwCliente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwCliente.DataKeys[e.NewEditIndex].Value;
            CadastraCliente1.Cliente = ClienteBLL.GetClienteByID(ID);
            mvwCliente.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraCliente1.Salvar();
                CadastraCliente1.Cliente = new ClienteTO();
                mvwCliente.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    }
}