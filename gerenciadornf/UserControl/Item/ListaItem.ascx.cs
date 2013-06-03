using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Item;
namespace gerenciadornf.UserControl.Item
{
    public partial class ListaItem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwItem.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<ItemTO> clsItems = new List<ItemTO>();
            clsItems = ItemBLL.listaItemAll();
            gvwItem.DataSource = clsItems;
            gvwItem.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwItem.ActiveViewIndex = 1;
        }
        protected void gvwItem_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ItemTO clsItem = new ItemTO();
            Int32 ID = (Int32)gvwItem.DataKeys[e.RowIndex].Value;
            clsItem = ItemBLL.GetItemByID(ID);
            ItemBLL.Delete(clsItem);
            LoadGrid();


        }
        protected void gvwItem_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwItem.DataKeys[e.NewEditIndex].Value;
            CadastraItem1.Item = ItemBLL.GetItemByID(ID);
            mvwItem.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraItem1.Salvar();
                CadastraItem1.Item = new ItemTO();
                mvwItem.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    
    }
}