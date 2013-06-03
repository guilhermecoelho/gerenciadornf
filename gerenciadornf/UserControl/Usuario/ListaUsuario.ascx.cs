using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Usuario;
using TipoUsuario;

namespace gerenciadornf.UserControl.Usuario
{
    public partial class ListaUsuario : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwUsuario.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<UsuarioTO> clsUsuarios = new List<UsuarioTO>();
            clsUsuarios = UsuarioBLL.listaUsuarioAll();
            gvwUsuario.DataSource = clsUsuarios;
            gvwUsuario.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwUsuario.ActiveViewIndex = 1;
        }
        protected void gvwUsuario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            UsuarioTO clsUsuario = new UsuarioTO();
            Int32 ID = (Int32)gvwUsuario.DataKeys[e.RowIndex].Value;
            clsUsuario = UsuarioBLL.GetUsuarioByID(ID);
            UsuarioBLL.Delete(clsUsuario);
            LoadGrid();


        }
        protected void gvwUsuario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwUsuario.DataKeys[e.NewEditIndex].Value;
            CadastraUsuario1.Usuario = UsuarioBLL.GetUsuarioByID(ID);
            mvwUsuario.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraUsuario1.Salvar();
                CadastraUsuario1.Usuario = new UsuarioTO();
                mvwUsuario.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    }
}