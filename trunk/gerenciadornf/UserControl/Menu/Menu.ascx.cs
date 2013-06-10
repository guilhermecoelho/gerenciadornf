using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gerenciadornf.UserControl.Menu
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          // String strIDTipoUsuario =  Session["tipoUsuario"].ToString();
            String strIDTipoUsuario = "";

            HttpCookie cookie = Request.Cookies["tipoUsuario"];
            if (cookie != null)
            {
                strIDTipoUsuario = cookie.Value.ToString();
            }
            if (!String.IsNullOrEmpty(strIDTipoUsuario))
            {

                if (String.Equals(strIDTipoUsuario, "1"))
                {
                    nmAdministrador.Visible = true;
                }
                else if (String.Equals(strIDTipoUsuario, "2"))
                {
                   nmFaturista.Visible = true;
                }
            }

        }
    }
}