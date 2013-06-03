using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Item;

namespace gerenciadornf.UserControl.Item
{
    public partial class CadastraItem : System.Web.UI.UserControl
    {
        #region .:property da classe:.
        private ItemTO clsItem = new ItemTO();

        public ItemTO Item
        {
            get
            {
                clsItem = (ItemTO)this.ViewState["clsItem"];
                if (clsItem == null)
                    clsItem = new ItemTO();
                return clsItem;
            }
            set
            {
                clsItem = value;
                this.ViewState["clsItem"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Salvar()
        {
            Load();
            if (clsItem.IDItem == 0)
            {
                ItemBLL.insert(clsItem);
            }
            else
            {
                ItemBLL.Update(clsItem);
            }


        }

        protected void Load()
        {
            clsItem = this.Item;
            clsItem.Nome = txtNome.Text;
            clsItem.Descricao = txtDescricao.Text;

            
        }


        private void PopulaDados()
        {
            clsItem = this.Item;
            txtNome.Text = clsItem.Nome;
            txtDescricao.Text = clsItem.Descricao;

        }
    }
}