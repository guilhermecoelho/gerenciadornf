<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaItem.ascx.cs" Inherits="gerenciadornf.UserControl.Item.ListaItem" %>
<%@ Register Src="CadastraItem.ascx" TagName="CadastraItem" TagPrefix="uc1" %>
<asp:MultiView ID="mvwItem" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaItem" runat="server">
        <asp:GridView ID="gvwItem" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwItem_RowDeleting"
            OnRowEditing="gvwItem_RowEditing" DataKeyNames="IDItem">
            <Columns>
                <asp:TemplateField HeaderText="Nome">
                    <ItemTemplate>
                        <%# Eval("Nome")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descrição">
                    <ItemTemplate>
                        <%# Eval("Descricao")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Incluir" CausesValidation="False"
                            CommandName="Edit" ImageUrl="~/Util/Imagens/Icones/alterar.png" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Excluir">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Incluir" CausesValidation="False"
                            CommandName="Delete" ImageUrl="~/Util/Imagens/Icones/excluir.png" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnMostrarTudo" runat="server" Text="Mostrar Tudo" OnClick="btnMostrarTudo_Click" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
    </asp:View>
    <asp:View ID="vwCadastraItem" runat="server">
        <uc1:CadastraItem ID="CadastraItem1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>
