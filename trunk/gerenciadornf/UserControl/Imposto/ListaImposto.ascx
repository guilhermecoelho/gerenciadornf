<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaImposto.ascx.cs"
    Inherits="gerenciadornf.UserControl.Imposto.ListaImposto" %>
<%@ Register Src="CadastraImposto.ascx" TagName="CadastraImposto" TagPrefix="uc1" %>
<asp:MultiView ID="mvwImposto" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaImposto" runat="server">
        <asp:GridView ID="gvwImposto" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwImposto_RowDeleting"
            OnRowEditing="gvwImposto_RowEditing" DataKeyNames="IDImposto">
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
                <asp:TemplateField HeaderText="Valor">
                    <ItemTemplate>
                        <%# Eval("valor")%>
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
    <asp:View ID="vwCadastraImposto" runat="server">
        <uc1:CadastraImposto ID="CadastraImposto1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>
