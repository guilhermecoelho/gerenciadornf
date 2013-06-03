<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaEmitente.ascx.cs"
    Inherits="gerenciadornf.UserControl.Emitente.ListaEmitente" %>
<%@ Register Src="CadastraEmitente.ascx" TagName="CadastraEmitente" TagPrefix="uc1" %>
<asp:MultiView ID="mvwEmitente" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaEmitente" runat="server">
        <asp:GridView ID="gvwEmitente" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwEmitente_RowDeleting"
            OnRowEditing="gvwEmitente_RowEditing" DataKeyNames="IDEmitente">
            <Columns>
                <asp:TemplateField HeaderText="IDEmitente">
                    <ItemTemplate>
                        <%# Eval("IDEmitente")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOME">
                    <ItemTemplate>
                        <%# Eval("NOME")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOMEFANTASIA">
                    <ItemTemplate>
                        <%# Eval("NOMEFANTASIA")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LOGRADURA">
                    <ItemTemplate>
                        <%# Eval("LOGRADURA")%>
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
                        <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Incluir" CausesValidation="False"
                            CommandName="Delete" ImageUrl="~/Util/Imagens/Icones/excluir.png" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnMostrarTudo" runat="server" Text="Mostrar Tudo" OnClick="btnMostrarTudo_Click" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
    </asp:View>
    <asp:View ID="vwCadastraEmitente" runat="server">
        <uc1:CadastraEmitente ID="CadastraEmitente1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>
