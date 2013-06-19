<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaTransportadora.ascx.cs"
    Inherits="gerenciadornf.UserControl.Transportadora.ListaTransportadora" %>
<%@ Register Src="CadastraTransportadora.ascx" TagName="CadastraTransportadora" TagPrefix="uc1" %>
<h2>
    Transportadora</h2>
<asp:MultiView ID="mvwTransportadora" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaTransportadora" runat="server">
       <p><asp:Button ID="btnMostrarTudo" runat="server" Text="Mostrar Tudo" OnClick="btnMostrarTudo_Click" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
        </p>
        <asp:GridView ID="gvwTransportadora" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwTransportadora_RowDeleting"
            OnRowEditing="gvwTransportadora_RowEditing" DataKeyNames="IDTransportadora">
            <Columns>
                <asp:TemplateField HeaderText="IDTransportadora">
                    <ItemTemplate>
                        <%# Eval("IDTransportadora")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOME">
                    <ItemTemplate>
                        <%# Eval("NOME")%>
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
    </asp:View>
    <asp:View ID="vwCadastraTransportadora" runat="server">
        <uc1:CadastraTransportadora ID="CadastraTransportadora1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    </asp:View>
</asp:MultiView>