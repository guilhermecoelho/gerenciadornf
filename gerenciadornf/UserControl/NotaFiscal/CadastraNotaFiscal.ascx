<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraNotaFiscal.ascx.cs"
    Inherits="gerenciadornf.UserControl.NotaFiscal.CadastraNotaFiscal" %>
<table width="100%">
    <tr>
        <td colspan="2" valign="top">
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Emitente:
        </td>
        <td>
            <asp:DropDownList ID="ddlEmitente" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Natureza:
        </td>
        <td>
            <asp:RadioButton ID="radSaida" Text="Saída" runat="server" />
            <asp:RadioButton ID="radEntrada" Text="Entrada" runat="server" /><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Data de saída/entrada:
        </td>
        <td>
            <asp:TextBox ID="txtDataSaidaEntrada" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Cliente:
        </td>
        <td>
            <asp:DropDownList ID="ddlCliente" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Transportador:
        </td>
        <td>
            <asp:DropDownList ID="ddlTransportadora" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Frete por conta de:
        </td>
        <td>
            <asp:RadioButton ID="radEmitente" Text="Emitente" runat="server" />
            <asp:RadioButton ID="radDestinatario" Text="Destinatário" runat="server" /><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Quantidade:
        </td>
        <td>
            <asp:TextBox ID="txtQtdTransporte" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Especie:
        </td>
        <td>
            <asp:TextBox ID="txtEspecieTransporte" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Marca:
        </td>
        <td>
            <asp:TextBox ID="txtMarcaTransporte" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Número:
        </td>
        <td>
            <asp:TextBox ID="txtNumeroTransporte" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Peso Bruto:
        </td>
        <td>
            <asp:TextBox ID="txtPesoBruto" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Peso Liquido:
        </td>
        <td>
            <asp:TextBox ID="txtPesoLiquido" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Forma de Pagamento:
        </td>
        <td>
            <asp:DropDownList ID="ddlFormaDePagamento" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
</table>
<br />
