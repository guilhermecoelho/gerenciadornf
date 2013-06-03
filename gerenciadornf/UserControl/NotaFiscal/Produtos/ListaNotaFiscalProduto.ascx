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
        <asp:TemplateField HeaderText="Incluir" ShowHeader="False">
            <ItemTemplate>
                <div align="center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Incluir" CausesValidation="False"
                        CommandName="Select" ImageUrl="~/util/imagens/icones/mais.png" />
                </div>
            </ItemTemplate>
            <ItemStyle Width="5%" />
        </asp:TemplateField>
        
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <div align="center">
                            <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Incluir" CausesValidation="False"
                                CommandName="Edit" ImageUrl="~/Util/Imagens/Icones/alterar.png" />
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Excluir">
                    <ItemTemplate>
                        <div align="center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Incluir" CausesValidation="False"
                                CommandName="Delete" ImageUrl="~/Util/Imagens/Icones/excluir.png" />
                        </div>
                    </ItemTemplate>
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
<asp:Button ID="btnIncluirProduto" runat="server" Text="Incluir Produto" 
    onclick="btnIncluirProduto_Click" />
<asp:GridView ID="gvwNotaFiscalProduto" AutoGenerateColumns="false" runat="server">
    <Columns>
        <asp:TemplateField HeaderText="Numero">
            <ItemTemplate>
                <%# Eval("idNotaFiscal")%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="produto">
            <ItemTemplate>
                <%# Eval("idproduto")%>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
