<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaFormaPagamento.ascx.cs"
    Inherits="gerenciadornf.UserControl.FormaPagamento.ListaFormaPagamento" %>
<%@ Register Src="CadastraFormaPagamento.ascx" TagName="CadastraFormaPagamento" TagPrefix="uc1" %>
<asp:MultiView ID="mvwFormaPagamento" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaFormaPagamento" runat="server">
        <asp:GridView ID="gvwFormaPagamento" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwFormaPagamento_RowDeleting"
            OnRowEditing="gvwFormaPagamento_RowEditing" DataKeyNames="IDFormaPagamento">
            <Columns>
                <asp:TemplateField HeaderText="IDFormaPagamento">
                    <ItemTemplate>
                        <%# Eval("IDFormaPagamento")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipo">
                    <ItemTemplate>
                        <%# Eval("Indicador")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="QTDPARCELA">
                    <ItemTemplate>
                        <%# Eval("QTDPARCELA")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="QTDDIAS">
                    <ItemTemplate>
                        <%# Eval("QTDDIAS")%>
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
    <asp:View ID="vwCadastraFormaPagamento" runat="server">
        <uc1:CadastraFormaPagamento ID="CadastraFormaPagamento1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>