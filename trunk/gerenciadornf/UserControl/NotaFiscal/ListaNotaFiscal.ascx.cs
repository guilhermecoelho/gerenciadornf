using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotaFiscal;
using Cliente;
using Emitente;


namespace gerenciadornf.UserControl.NotaFiscal
{
    public partial class ListaNotaFiscal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populaEmitente();
                populaCliente();
            }

        }
        protected void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            mvwNotaFiscal.ActiveViewIndex = 0;

            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<NotaFiscalTO> clsNotaFiscals = new List<NotaFiscalTO>();
            clsNotaFiscals = NotaFiscalBLL.getNotaFiscalALL();
            gvwNotaFiscal.DataSource = clsNotaFiscals;
            gvwNotaFiscal.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            mvwNotaFiscal.ActiveViewIndex = 1;
        }
        protected void gvwNotaFiscal_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();
            Int32 ID = (Int32)gvwNotaFiscal.DataKeys[e.RowIndex].Value;
            clsNotaFiscal = NotaFiscalBLL.GetNotaFiscalByID(ID);
            NotaFiscalBLL.Delete(clsNotaFiscal);
            LoadGrid();
        }
        protected void gvwNotaFiscal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 ID = (Int32)gvwNotaFiscal.DataKeys[e.NewEditIndex].Value;
            CadastraNotaFiscal1.NotaFiscal = NotaFiscalBLL.GetNotaFiscalByID(ID);
            mvwNotaFiscal.ActiveViewIndex = 1;
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CadastraNotaFiscal1.Salvar();
                CadastraNotaFiscal1.NotaFiscal = new NotaFiscalTO();
                mvwNotaFiscal.ActiveViewIndex = 0;
                LoadGrid();
            }

        }
        protected void gvwNotaFiscal_SelectedIndexChanged(object sender, GridViewSelectEventArgs e)
        {
            Int32 intIDNotaFiscal = (Int32)gvwNotaFiscal.DataKeys[e.NewSelectedIndex].Value;

            notaFiscalImpressao1.idNotaFiscal = intIDNotaFiscal;
            notaFiscalImpressao1.LoadNF();
            mvwNotaFiscal.ActiveViewIndex = 2;
        }

        protected void populaEmitente()
        {
            List<EmitenteTO> clsEmitentes = new List<EmitenteTO>();
            clsEmitentes = EmitenteBLL.listaEmitenteAll();
            ddlEmitente.DataSource = clsEmitentes;
            ddlEmitente.DataTextField = "nome";// Visualização
            ddlEmitente.DataValueField = "idEmitente"; //Valor
            ddlEmitente.DataBind();
            ddlEmitente.Items.Insert(0, new ListItem("Selecione", "0"));

        }
        protected void populaCliente()
        {
            List<ClienteTO> clsClientes = new List<ClienteTO>();
            clsClientes = ClienteBLL.listaClienteAll();
            ddlCliente.DataSource = clsClientes;
            ddlCliente.DataTextField = "NOME";// Visualização
            ddlCliente.DataValueField = "IDCLIENTE"; //Valor
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0, new ListItem("Selecione", "0"));
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String strNumeroNota = txtnumeroNF.Text;
            Int32 intIDEmitente = 0;
            Int32.TryParse(ddlEmitente.SelectedValue, out intIDEmitente);
            Int32 intIDCliente = 0;
            Int32.TryParse(ddlCliente.SelectedValue, out intIDCliente);
            List<NotaFiscalTO> clsNotaFiscals = new List<NotaFiscalTO>();
            clsNotaFiscals = NotaFiscalBLL.GetNotaFiscalBusca(strNumeroNota, intIDEmitente, intIDCliente);
            LoadGridBusca(clsNotaFiscals);
        }

        protected void LoadGridBusca(List<NotaFiscalTO> clsNotaFiscals)
        {
            gvwNotaFiscal.DataSource = clsNotaFiscals;
            gvwNotaFiscal.DataBind();
        }

        protected void btnInserirProduto_Click(object sender, EventArgs e)
        {
            mvwNotaFiscal.ActiveViewIndex = 3;
        }
    }
}