using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Usuario;

namespace gerenciadornf.UserControl.Login
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            UsuarioTO clsUsuario = new UsuarioTO();
            clsUsuario = UsuarioBLL.GetUsuarioByNomeAndPassword(Login1.UserName, Login1.Password);

            if (!String.IsNullOrEmpty(clsUsuario.Nome))
            {
                e.Authenticated = true;
                HttpCookie cookie = new HttpCookie("tipoUsuario");
                cookie.Value = clsUsuario.IDTipoUsuario.ToString();
                TimeSpan somarTempo = new TimeSpan(0, 10, 0, 0);
                cookie.Expires = DateTime.Now + somarTempo;
                Response.Cookies.Add(cookie);

            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}