<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraCliente.ascx.cs"
    Inherits="gerenciadornf.UserControl.Cliente.CadastraCliente" %>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Cadastro" />
<br />
<table width="100%">
    <tr>
        <td colspan="2" valign="top">
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Nome:<asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtNome" ValidationGroup="Cadastro"
    runat="server" ErrorMessage="Informe o Nome" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Email:<asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail"
    ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe um Email" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Tipo:
        </td>
        <td>
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Nome Fantasia:<asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtNomeFantasia"
    ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe o nome fantasia" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtNomeFantasia" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Cep:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCep"
    ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe o CEP" Display="Dynamic">*</asp:RequiredFieldValidator>
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
            Numero:
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
            UF:
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
            Cpf:
        </td>
        <td>
            <asp:TextBox ID="txtCpf" class="cpf" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Inscrição Estadual:
        </td>
        <td>
            <asp:TextBox ID="txtInscricaoEstadual" class="InscricaoEstadual" runat="server"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td align="right" width="7%">
            Inscrição Municipal:
        </td>
        <td>
            <asp:TextBox ID="txtInscricaoMunicipal" class="InscricaoMunicipal" runat="server"></asp:TextBox><br />
        </td>
    </tr>
</table>
