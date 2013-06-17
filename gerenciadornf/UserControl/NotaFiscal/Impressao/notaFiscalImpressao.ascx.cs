using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cliente;
using Emitente;
using NotaFiscalProduto;
using NotaFiscal;
using Transportadora;
using FormaPagamento;

namespace gerenciadornf.UserControl.NotaFiscal.Impressao
{
    public partial class notaFiscalImpressao : System.Web.UI.UserControl
    {
        private ClienteTO clsCliente = new ClienteTO();
        private EmitenteTO clsEmitente = new EmitenteTO();
        private TransportadoraTO clsTransportadora = new TransportadoraTO();
        private FormaPagamentoTO  clsFormaPagamento = new FormaPagamentoTO();
        private List<NotaFiscalProdutoTO> clsNotaFiscalProduto = new List<NotaFiscalProdutoTO>();
        private NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

        public int idNotaFiscal
        {
            get
            {
                object id = this.ViewState["idNotaFiscal"];
                if (id == null)
                    return new int();
                else
                    return (int)id;
            }

            set
            {
                this.ViewState["idNotaFiscal"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LoadNF()
        {
            clsNotaFiscal = NotaFiscalBLL.GetNotaFiscalByID(idNotaFiscal);
            clsCliente = ClienteBLL.GetClienteByID(clsNotaFiscal.IDCliente);
            clsEmitente = EmitenteBLL.GetEmitenteByID(clsNotaFiscal.IDEmitente);
            clsTransportadora = TransportadoraBLL.GetTransportadoraByID(clsNotaFiscal.IDTransportadora);
            clsNotaFiscalProduto = NotaFiscalProdutoBLL.getNotaFiscalProdutoByNF(clsNotaFiscal.IDNotaFiscal);
            clsFormaPagamento = FormaPagamentoBLL.GetFormaPagamentoByID(clsNotaFiscal.iDFormaPagamento);

            lblNumeroNF.Text = clsNotaFiscal.IDNotaFiscal.ToString();
            lblDataEmissao.Text = clsNotaFiscal.DataCadastro.ToString();
            lblNaturezaOperacao.Text = clsNotaFiscal.TipoSaidaEntrada;
            lblFormaPagamento.Text = clsFormaPagamento.Descricao;
            lblDataSaidaEntrada.Text = clsNotaFiscal.DataSaidaEntrada.ToString();

            lblNomeEmitente.Text = clsEmitente.NomeFantasia;
            lblCNPJEmitente.Text = clsEmitente.Cnpj;
            lblIEEmitente.Text = clsEmitente.InscricaoEstadual;
            lblCepEmitente.Text = clsEmitente.Cep;
            lblLograduraEmitente.Text = clsEmitente.Logradura;
            lblNumeroEmitente.Text = clsEmitente.Numero;
            lblCidadeEmitente.Text = clsEmitente.Cidade;
            lblUFEmitente.Text = clsEmitente.Uf;
            lblTelefoneEmitente.Text = clsEmitente.Telefone;

            lblNomeCliente.Text = clsCliente.NomeFantasia;
            lblCNPJCliente.Text = clsCliente.Cnpj;
            lblIECliente.Text = clsCliente.InscricaoEstadual;
            lblCepCliente.Text = clsCliente.Cep;
            lblLograduraCliente.Text = clsCliente.Logradura;
            lblNumeroCliente.Text = clsCliente.Numero;
            lblCidadeCliente.Text = clsCliente.Cidade;
            lblUFCliente.Text = clsCliente.Uf;
            lblTelefoneCliente.Text = clsCliente.Telefone;

            Double dblTotalSemImpostos = 0;
            Double dblTotalFinal = 0;
            double dblTotalImpostos = 0;
            foreach (NotaFiscalProdutoTO _clsNotaFiscalProduto in clsNotaFiscalProduto)
            {
                dblTotalSemImpostos += (_clsNotaFiscalProduto.ValorUnitario * _clsNotaFiscalProduto.QtdProduto);
                dblTotalImpostos += _clsNotaFiscalProduto.ValorTotal;
            }
            dblTotalFinal = dblTotalImpostos + dblTotalSemImpostos;

            lblBaseCalculoICMS.Text = dblTotalSemImpostos.ToString();
            lblTotalICMS.Text = dblTotalImpostos.ToString();
           // lblValorTotalIPI.Text = "0";
            lblValorTotalProduto.Text = dblTotalFinal.ToString();

            gvNotaFiscalProduto.DataSource = this.clsNotaFiscalProduto;
            gvNotaFiscalProduto.DataBind();
        }
    }
}