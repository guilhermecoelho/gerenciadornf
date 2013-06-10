<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraUsuario.ascx.cs" Inherits="gerenciadornf.UserControl.Usuario.CadastraUsuario" %>

 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Cadastro" />
                            <br />
<asp:RequiredFieldValidator id="rfvNome" ControlToValidate="txtNome" ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe o Nome" Display="Dynamic">*</asp:RequiredFieldValidator>
Nome<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />

<asp:RequiredFieldValidator id="RequiredFieldValidator1" ControlToValidate="txtEmail" ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe um Email" Display="Dynamic">*</asp:RequiredFieldValidator>
Emails<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
<asp:RequiredFieldValidator id="RequiredFieldValidator2" ControlToValidate="txtSenha" ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe uma Senha" Display="Dynamic">*</asp:RequiredFieldValidator>
Senha<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />

Tipo usuario<asp:DropDownList ID="ddlTipoUsuario" runat="server">
            </asp:DropDownList><br />