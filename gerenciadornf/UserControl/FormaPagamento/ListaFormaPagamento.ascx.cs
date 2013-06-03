using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormaPagamento;

namespace gerenciadornf.UserControl.FormaPagamento
{
    public partial class ListaFormaPagamento : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwFormaPagamento.ActiveViewIndex = 0;
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<FormaPagamentoTO> clsFormaPagamentos = new List<FormaPagamentoTO>();
            clsFormaPagamentos = FormaPagamentoBLL.listaFormaPagamentoAll();
            gvwFormaPagamento.DataSource = clsFormaPagamentos;
            gvwFormaPagamento.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwFormaPagamento.ActiveViewIndex = 1;
        }
        protected void gvwFormaPagamento_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            FormaPagamentoTO clsFormaPagamento = new FormaPagamentoTO();
            Int32 ID = (Int32)gvwFormaPagamento.DataKeys[e.RowIndex].Value;
            clsFormaPagamento = FormaPagamentoBLL.GetFormaPagamentoByID(ID);
            FormaPagamentoBLL.Delete(clsFormaPagamento);
            LoadGrid();


        }
        protected void gvwFormaPagamento_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwFormaPagamento.DataKeys[e.NewEditIndex].Value;
            CadastraFormaPagamento1.FormaPagamento = FormaPagamentoBLL.GetFormaPagamentoByID(ID);
            mvwFormaPagamento.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraFormaPagamento1.Salvar();
                CadastraFormaPagamento1.FormaPagamento = new FormaPagamentoTO();
                mvwFormaPagamento.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
    }
}