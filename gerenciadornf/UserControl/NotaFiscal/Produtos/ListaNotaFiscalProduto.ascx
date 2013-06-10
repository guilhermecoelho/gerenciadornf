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
Produto:
<asp:DropDownList ID="ddlProdutos" runat="server" Visible="false">
</asp:DropDownList>
<br />
Quantidade:
<asp:TextBox ID="txtQuantidade" runat="server" Visible="false"></asp:TextBox><br />
Aliquota ICMS:
<asp:TextBox ID="txtICMS" runat="server" Visible="false"></asp:TextBox><br />
Aliquota IPI:
<asp:TextBox ID="txtIPI" runat="server" Visible="false"></asp:TextBox><br />
<asp:Button ID="btnIncluirProduto" runat="server" Text="Incluir Produto" OnClick="btnIncluirProduto_Click" />
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
