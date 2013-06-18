using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotaFiscal;
using Emitente;
using Transportadora;
using Cliente;
using FormaPagamento;
namespace gerenciadornf.UserControl.NotaFiscal
{
    public partial class CadastraNotaFiscal : System.Web.UI.UserControl
    {
        #region .:property da classe:.
        private NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();
        private List<EmitenteTO> clsEmitentes = new List<EmitenteTO>();
        private List<TransportadoraTO> clsTransportadoras = new List<TransportadoraTO>();
        private List<ClienteTO> clsClientes = new List<ClienteTO>();
        private List<FormaPagamentoTO> clsFormasPagamentos = new List<FormaPagamentoTO>();

        public NotaFiscalTO NotaFiscal
        {
            get
            {
                clsNotaFiscal = (NotaFiscalTO)this.ViewState["clsNotaFiscal"];
                if (clsNotaFiscal == null)
                    clsNotaFiscal = new NotaFiscalTO();
                return clsNotaFiscal;
            }
            set
            {
                clsNotaFiscal = value;
                this.ViewState["clsNotaFiscal"] = value;
                PopulaDados();
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                populaEmitente();

                populaTransportadora();

                populaCliente();

                populaPagamento();

            }
        }

        protected void populaEmitente()
        {
            clsEmitentes = EmitenteBLL.listaEmitenteAll();
            ddlEmitente.DataSource = clsEmitentes;
            ddlEmitente.DataTextField = "nome";// Visualização
            ddlEmitente.DataValueField = "idEmitente"; //Valor
            ddlEmitente.DataBind();
        }
        protected void populaTransportadora()
        {
            clsTransportadoras = TransportadoraBLL.listaTransportadoraAll();
            ddlTransportadora.DataSource = clsTransportadoras;
            ddlTransportadora.DataTextField = "nome";// Visualização
            ddlTransportadora.DataValueField = "idTransportadora"; //Valor
            ddlTransportadora.DataBind();
        }
        protected void populaCliente()
        {
            clsClientes = ClienteBLL.listaClienteAll();
            ddlCliente.DataSource = clsClientes;
            ddlCliente.DataTextField = "NOME";// Visualização
            ddlCliente.DataValueField = "IDCLIENTE"; //Valor
            ddlCliente.DataBind();
        }
        protected void populaPagamento()
        {
            clsFormasPagamentos = FormaPagamentoBLL.listaFormaPagamentoAll();
            ddlFormaDePagamento.DataSource = clsFormasPagamentos;
            ddlFormaDePagamento.DataTextField = "descricao";// Visualização
            ddlFormaDePagamento.DataValueField = "idformapagamento"; //Valor
            ddlFormaDePagamento.DataBind();
        }



        public void Salvar()
        {
            Load();
            if (clsNotaFiscal.IDNotaFiscal == 0)
            {
                NotaFiscalBLL.insert(clsNotaFiscal);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('nota salva com sucesso')", true);
            }
            else
            {
                NotaFiscalBLL.Update(clsNotaFiscal);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "sucesso", "alert('nota atualizada com sucesso')", true);
            }
        }

        protected void Load()
        {
            clsNotaFiscal = this.NotaFiscal;
            int intEmitente = 0;
            int.TryParse(ddlEmitente.SelectedValue, out intEmitente);
            clsNotaFiscal.IDEmitente = intEmitente;
            int intTransportadora = 0;
            int.TryParse(ddlTransportadora.SelectedValue, out intTransportadora);
            clsNotaFiscal.IDTransportadora = intTransportadora;
            int intCliente = 0;
            int.TryParse(ddlCliente.SelectedValue, out intCliente);
            clsNotaFiscal.IDCliente = intCliente;
            int intFormaPagamento = 0;
            int.TryParse(ddlFormaDePagamento.SelectedValue, out intFormaPagamento);
            clsNotaFiscal.iDFormaPagamento = intFormaPagamento;

            clsNotaFiscal.DataCadastro = DateTime.Now;

            if (radSaida.Checked)
            {
                clsNotaFiscal.TipoSaidaEntrada = "Saída";
            }
            if (radEntrada.Checked)
            {
                clsNotaFiscal.TipoSaidaEntrada = "Entrada";
            }


            if (radEmitente.Checked)
            {
                clsNotaFiscal.TipoTransporte = "Emitente";
            }
            if (radDestinatario.Checked)
            {
                clsNotaFiscal.TipoTransporte = "Destinatário";
            }

           // clsNotaFiscal.QtdTransporte = Convert.ToInt32(txtQtdTransporte.Text);
            clsNotaFiscal.EspecieTransporte = txtEspecieTransporte.Text;
            clsNotaFiscal.MarcaTransporte = txtMarcaTransporte.Text;
            clsNotaFiscal.NumeroTransporte = Convert.ToInt32(txtNumeroTransporte.Text);
            clsNotaFiscal.PesoBruto = Convert.ToDouble(txtPesoBruto.Text);
            clsNotaFiscal.PesoLiquido = Convert.ToDouble(txtPesoLiquido.Text);
        }


        private void PopulaDados()
        {

            clsNotaFiscal = this.NotaFiscal;

            populaEmitente();

            populaTransportadora();

            populaCliente();

            populaPagamento();


            if (clsNotaFiscal.TipoSaidaEntrada == "Saída")
            {
                radSaida.Checked = true;
            }
            if (clsNotaFiscal.TipoSaidaEntrada == "Entrada")
            {
                radEntrada.Checked = true;
            }

            if (clsNotaFiscal.TipoTransporte == "Emitente")
            {
                radEmitente.Checked = true;
            }
            if (clsNotaFiscal.TipoTransporte == "Destinatário")
            {
                radDestinatario.Checked = true;
            }

           // txtQtdTransporte.Text = clsNotaFiscal.QtdTransporte.ToString();
            txtEspecieTransporte.Text = clsNotaFiscal.EspecieTransporte;
            txtMarcaTransporte.Text = clsNotaFiscal.MarcaTransporte;
            txtNumeroTransporte.Text = clsNotaFiscal.NumeroTransporte.ToString();
            txtPesoBruto.Text = clsNotaFiscal.PesoBruto.ToString();
            txtPesoLiquido.Text =  clsNotaFiscal.PesoLiquido.ToString();
        }
    }
}