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
    public partial class CadastraUsuario : System.Web.UI.UserControl
    {
        #region .:property da classe:.
        private UsuarioTO clsUsuario = new UsuarioTO();
        

        public UsuarioTO Usuario
        {
            get
            {
                clsUsuario = (UsuarioTO)this.ViewState["clsUsuario"];
                if (clsUsuario == null)
                    clsUsuario = new UsuarioTO();
                return clsUsuario;
            }
            set
            {
                clsUsuario = value;
                this.ViewState["clsUsuario"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<TipoUsuarioTO> clsTipoUsuario = new List<TipoUsuarioTO>();

                clsTipoUsuario = TipoUsuarioBLL.listaTipoUsuario();

                ddlTipoUsuario.DataSource = clsTipoUsuario;
                ddlTipoUsuario.DataTextField = "tipo";// Visualização
                ddlTipoUsuario.DataValueField = "idtipousuario"; //Valor

                ddlTipoUsuario.DataBind();
                ddlTipoUsuario.Items.Insert(0, new ListItem("Selecione", "0"));
            }

        }
        public void Salvar()
        {
            Load();
            if (clsUsuario.ID == 0)
            {
                UsuarioBLL.insert(clsUsuario);
            }
            else
            {
                UsuarioBLL.Update(clsUsuario);
            }


        }

        protected void Load()
        {
            clsUsuario = this.Usuario;
            clsUsuario.Nome = txtNome.Text;
            clsUsuario.Password = txtSenha.Text;
            clsUsuario.Email = txtEmail.Text;
            int intIdTipoUsuario = 0;
            int.TryParse(ddlTipoUsuario.SelectedValue, out intIdTipoUsuario);
            clsUsuario.IDTipoUsuario = intIdTipoUsuario;
        }


        private void PopulaDados()
        {

            clsUsuario = this.Usuario;
            txtNome.Text = clsUsuario.Nome;
            txtSenha.Text = clsUsuario.Password;
            txtEmail.Text = clsUsuario.Email;

            if (clsUsuario.IDTipoUsuario != 0)
            {
                ddlTipoUsuario.SelectedValue = clsUsuario.IDTipoUsuario.ToString();
            }
            else
            {
                ddlTipoUsuario.SelectedValue = null;
            }

        }
    }
}