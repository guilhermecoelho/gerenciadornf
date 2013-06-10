using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gerenciadornf
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //if (Request.Cookies["tipoUsuario"] != null)
                //{
                //    HttpCookie myCookie = new HttpCookie("tipoUsuario");
                //    myCookie.Expires = DateTime.Now.AddDays(-1d);
                //    Response.Cookies.Add(myCookie);
                //}
                //Session.Abandon();
            }
        }

        protected void HeadLoginStatus_LoggedOut(object sender, EventArgs e)
        {
            if (Request.Cookies["tipoUsuario"] != null)
            {
                HttpCookie myCookie = new HttpCookie("tipoUsuario");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
        }
    }
}
