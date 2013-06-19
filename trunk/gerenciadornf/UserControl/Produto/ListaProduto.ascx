<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaProduto.ascx.cs" Inherits="gerenciadornf.UserControl.Produto.ListaProduto" %>
<%@ Register Src="CadastraProduto.ascx" TagName="CadastraProduto" TagPrefix="uc1" %>
<asp:MultiView ID="mvwProduto" runat="server" ActiveViewIndex="0">

    <asp:View ID="vwListaProduto" runat="server">

        <asp:GridView ID="gvwProduto" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwProduto_RowDeleting" OnRowEditing="gvwProduto_RowEditing" DataKeyNames="IDProduto">
            <Columns>

                <asp:TemplateField HeaderText="Descrição">
                    <ItemTemplate>
                        <%# Eval("Descricao")%>
                    </ItemTemplate>
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
        <asp:Button ID="btnMostrarTudo" runat="server" Text="Mostrar Tudo" OnClick="btnMostrarTudo_Click" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
    </asp:View>

    <asp:View ID="vwCadastraProduto" runat="server">

        <uc1:CadastraProduto ID="CadastraProduto1" runat="server" /><br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>
