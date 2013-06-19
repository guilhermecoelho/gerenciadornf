using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormaPagamento;
namespace gerenciadornf.UserControl.FormaPagamento
{
    public partial class CadastraFormaPagamento : System.Web.UI.UserControl
    {
        private FormaPagamentoTO clsFormaPagamento = new FormaPagamentoTO();

        public FormaPagamentoTO FormaPagamento
        {
            get
            {
                clsFormaPagamento = (FormaPagamentoTO)this.ViewState["clsFormaPagamento"];
                if (clsFormaPagamento == null)
                    clsFormaPagamento = new FormaPagamentoTO();
                return clsFormaPagamento;
            }
            set
            {
                clsFormaPagamento = value;
                this.ViewState["clsFormaPagamento"] = value;
                PopulaDados();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Salvar()
        {
            Load();
            if (clsFormaPagamento.IDFormaPagamento == 0)
            {
                FormaPagamentoBLL.insert(clsFormaPagamento);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Forma de pagamento salva com sucesso')", true);
            }
            else
            {
                FormaPagamentoBLL.Update(clsFormaPagamento);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('Forma de pagamento salva com sucesso')", true);
            }
        }

        protected void Load()
        {
            clsFormaPagamento = this.FormaPagamento;

            clsFormaPagamento.Descricao = txtDescricao.Text;
            clsFormaPagamento.QtdDias = Convert.ToInt32(txtQtdDias.Text);
            clsFormaPagamento.QtdParcela = Convert.ToInt32(txtQtdParcela.Text);

            if (radParcelado.Checked)
            {
                clsFormaPagamento.Indicador = "Parcelado";
            }
            if (radVista.Checked)
            {
                clsFormaPagamento.Indicador = "A vista";
            }
        }


        private void PopulaDados()
        {

            clsFormaPagamento = this.FormaPagamento;

            txtDescricao.Text = clsFormaPagamento.Descricao;
            txtQtdParcela.Text = Convert.ToString(clsFormaPagamento.QtdParcela);
            txtQtdDias.Text = Convert.ToString(clsFormaPagamento.QtdDias);

            if (clsFormaPagamento.Indicador == "Parcelado")
            {
                radParcelado.Checked = true;
            }
            if (clsFormaPagamento.Indicador == "A vista")
            {
                radVista.Checked = true;
            }
        }
    }
}