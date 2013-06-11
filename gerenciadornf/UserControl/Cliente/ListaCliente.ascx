<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaCliente.ascx.cs"
    Inherits="gerenciadornf.UserControl.Cliente.ListaCliente" %>
<%@ Register Src="CadastraCliente.ascx" TagName="CadastraCliente" TagPrefix="uc1" %>

<asp:MultiView ID="mvwCliente" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaCliente" runat="server">
        <asp:GridView ID="gvwCliente" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwCliente_RowDeleting"
            OnRowEditing="gvwCliente_RowEditing" DataKeyNames="IDCliente">
            <Columns>
                <asp:TemplateField HeaderText="IDCliente">
                    <ItemTemplate>
                        <%# Eval("IDCliente")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOME">
                    <ItemTemplate>
                        <%# Eval("NOME")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EMAIL">
                    <ItemTemplate>
                        <%# Eval("EMAIL")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TIPO">
                    <ItemTemplate>
                        <%# Eval("TIPO")%>
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
    <asp:View ID="vwCadastraCliente" runat="server">
        <uc1:CadastraCliente ID="CadastraCliente1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Button" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>