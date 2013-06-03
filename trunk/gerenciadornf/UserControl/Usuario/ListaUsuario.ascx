<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuario.ascx.cs"
    Inherits="gerenciadornf.UserControl.Usuario.ListaUsuario" %>
<%@ Register Src="CadastraUsuario.ascx" TagName="CadastraUsuario" TagPrefix="uc1" %>
<asp:MultiView ID="mvwUsuario" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaUsuario" runat="server">
        <asp:GridView ID="gvwUsuario" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwUsuario_RowDeleting"
            OnRowEditing="gvwUsuario_RowEditing" DataKeyNames="ID">
            <Columns>
                <asp:TemplateField HeaderText="Nome">
                    <ItemTemplate>
                        <%# Eval("Nome")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Empresa">
                    <ItemTemplate>
                        <%# Eval("Email")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cargo">
                    <ItemTemplate>
                        <%# Eval("idTipoUsuario")%>
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
    <asp:View ID="vwCadastraUsuario" runat="server">
        <uc1:CadastraUsuario ID="CadastraUsuario1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>