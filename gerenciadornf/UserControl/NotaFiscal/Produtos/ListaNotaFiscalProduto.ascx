<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaNotaFiscalProduto.ascx.cs"
    Inherits="gerenciadornf.UserControl.NotaFiscal.Produtos.ListaNotaFiscalProduto" %>
<asp:GridView ID="gvNotaFiscal" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanging="gvNotaFiscal_SelectedIndexChanging "
    DataKeyNames="idNotaFiscal">
    <Columns>
        <asp:TemplateField HeaderText="Numero">
            <ItemTemplate>
                <%# Eval("idNotaFiscal")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Emitente">
            <ItemTemplate>
                <%# Eval("Idemitente")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="cliente">
            <ItemTemplate>
                <%# Eval("idCliente")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Data">
            <ItemTemplate>
                <%# Eval("datacadastro")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Selecionar" ShowHeader="False">
            <ItemTemplate>
                <div align="center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Incluir" CausesValidation="False"
                        CommandName="Select" ImageUrl="~/util/imagens/icones/selecionar.png" />
                </div>
            </ItemTemplate>
            <ItemStyle Width="5%" />
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Cadastro" />
<table>
    <tr>
        <td>
            Produto:
        </td>
        <td>
            <asp:DropDownList ID="ddlProdutos" runat="server" Visible="false">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Quantidade:
            <asp:RequiredFieldValidator ID="rfvQuantidade" ControlToValidate="txtQuantidade"
                ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe o Nome" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtQuantidade" runat="server" Visible="false" ></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Aliquota ICMS:
            <asp:RequiredFieldValidator ID="rfvIcms" ControlToValidate="txtICMS" ValidationGroup="Cadastro"
                runat="server" ErrorMessage="Informe a aliquita de ICMS" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtICMS" runat="server" Visible="false"></asp:TextBox><br />
        </td>
    </tr>
    <tr>
        <td>
            Aliquota IPI:
            <asp:RequiredFieldValidator ID="rfvIpi" ControlToValidate="txtIPI"
                ValidationGroup="Cadastro" runat="server" ErrorMessage="Informe a aliquota de IPI" Display="Dynamic">*</asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:TextBox ID="txtIPI" runat="server" Visible="false" ></asp:TextBox><br />
            
        </td>
    </tr>
</table>
<br />
<asp:Button ID="btnIncluirProduto" runat="server" Text="Incluir Produto" OnClick="btnIncluirProduto_Click" ValidationGroup="Cadastro"/>
<asp:GridView ID="gvwNotaFiscalProduto" AutoGenerateColumns="false" runat="server">
    <Columns>
        <asp:TemplateField HeaderText="Numero">
            <ItemTemplate>
                <%# Eval("idNotaFiscal")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Produto">
            <ItemTemplate>
                <%# Eval("NomeProduto")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantidade">
            <ItemTemplate>
                <%# Eval("QtdProduto")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Valor Unitario">
            <ItemTemplate>
                <%# Eval("ValorUnitario")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ICMS">
            <ItemTemplate>
                <%# Eval("Icms")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="IPI">
            <ItemTemplate>
                <%# Eval("Ipi")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Valor Total">
            <ItemTemplate>
                <%# Eval("ValorTotal")%>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
