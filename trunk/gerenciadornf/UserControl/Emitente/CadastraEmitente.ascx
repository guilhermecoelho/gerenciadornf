<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraEmitente.ascx.cs"
    Inherits="gerenciadornf.UserControl.Emitente.CadastraEmitente" %>
<table width="100%">
    <tr>
        <td colspan="2" valign="top">
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Nome:
        </td>
        <td>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Nome Fantasia:
        </td>
        <td>
            <asp:TextBox ID="txtNomeFantasia" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Cep:
        </td>
        <td>
            <asp:TextBox ID="txtCep" class="cep" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Logradura:
        </td>
        <td>
            <asp:TextBox ID="txtLogradura" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Número:
        </td>
        <td>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Complemento:
        </td>
        <td>
            <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Uf:
        </td>
        <td>
            <asp:TextBox ID="txtUf" class="UF" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Cidade:
        </td>
        <td>
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Telefone:
        </td>
        <td>
            <asp:TextBox ID="txtTelefone" class="telefone" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Cnpj:
        </td>
        <td>
            <asp:TextBox ID="txtCnpj" class="cnpj" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Inscrição Estadual:
        </td>
        <td>
            <asp:TextBox ID="txtInscricaoEstadual" class="inscricaoEstadual" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Certificado Digital:
        </td>
        <td>
            <asp:TextBox ID="txtCertDigital" runat="server"></asp:TextBox><br />
        </td>
    </tr>
</table>
