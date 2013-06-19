<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraTransportadora.ascx.cs"
    Inherits="gerenciadornf.UserControl.Transportadora.CadastraTransportadora" %>
<table>
    <tr>
        <td>
            Nome:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Razão Social:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtRazaoSocial" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Cep:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtCep" class="cep" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Logradura
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtLogradura" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Numero
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Complemento
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Uf
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtUf" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Cidade
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Telefone
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtTelefone" class="telefone" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Cnpj
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtCnpj" runat="server" class="cnpj"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            InscricaoEstadual
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtInscricaoEstadual" class="inscricaoEstadual" runat="server"></asp:TextBox><br />
        </td>
    </tr>
</table>
