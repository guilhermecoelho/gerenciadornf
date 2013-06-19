<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaNotaFiscal.ascx.cs"
    Inherits="gerenciadornf.UserControl.NotaFiscal.ListaNotaFiscal" %>
<%@ Register Src="CadastraNotaFiscal.ascx" TagName="CadastraNotaFiscal" TagPrefix="uc1" %>
<%@ Register Src="Impressao/notaFiscalImpressao.ascx" TagName="notaFiscalImpressao"
    TagPrefix="uc2" %>
<%@ Register Src="Produtos/ListaNotaFiscalProduto.ascx" TagName="ListaNotaFiscalProduto"
    TagPrefix="uc3" %>
<h2>
    Nota Fiscal
</h2>
<asp:MultiView ID="mvwNotaFiscal" runat="server" ActiveViewIndex="0">
    <asp:View ID="vwListaNotaFiscal" runat="server">
        <table width="100%">
            <tr>
                <td colspan="2" valign="top">
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="right" width="7%">
                    Número NF:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtnumeroNF"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" width="7%">
                    Emitente:
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmitente" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" width="7%">
                    Cliente:
                </td>
                <td>
                    <asp:DropDownList ID="ddlCliente" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <asp:Button ID="btnMostrarTudo" runat="server" Text="Mostrar Tudo" OnClick="btnMostrarTudo_Click" />
        <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
        <asp:Button ID="btnInserirProduto" runat="server" OnClick="btnInserirProduto_Click"
            Text="Editar Produtos das NF" />
        <br />
        <asp:GridView ID="gvwNotaFiscal" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvwNotaFiscal_RowDeleting"
            OnRowEditing="gvwNotaFiscal_RowEditing" DataKeyNames="IDnotafiscal" OnSelectedIndexChanging="gvwNotaFiscal_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Numero">
                    <ItemTemplate>
                        <%# Eval("idnotafiscal")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Emitente">
                    <ItemTemplate>
                        <%# Eval("nomeEmitente")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="cliente">
                    <ItemTemplate>
                        <%# Eval("nomeCliente")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Data">
                    <ItemTemplate>
                        <%# Eval("datacadastro")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Selecionar">
                    <ItemTemplate>
                        <div align="center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Selecionar" CausesValidation="False"
                                CommandName="Select" ImageUrl="~/util/imagens/icones/selecionar.png" />
                        </div>
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
                            <asp:ImageButton ID="ImageButton3" runat="server" ToolTip="Incluir" CausesValidation="False"
                                CommandName="Delete" ImageUrl="~/Util/Imagens/Icones/excluir.png" />
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:View>
    <asp:View ID="vwCadastraNotaFiscal" runat="server">
        <uc1:CadastraNotaFiscal ID="CadastraNotaFiscal1" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <asp:Button ID="btnVoltarCadastro" runat="server" Text="Voltar" OnClick="btnVoltarCadastro_Click" />
    </asp:View>
    <asp:View ID="vwExibeNF" runat="server">
        <uc2:notaFiscalImpressao ID="notaFiscalImpressao1" runat="server" />
        <asp:Button ID="btnVoltarImpressao" runat="server" Text="Voltar" OnClick="btnVoltarImpressao_Click" />
    </asp:View>
    <asp:View ID="vwListaProdutos" runat="server">
        <uc3:ListaNotaFiscalProduto ID="ListaNotaFiscalProduto1" runat="server" />
        <asp:Button ID="btnVoltarNotaFiscalProduto" runat="server" Text="Voltar" OnClick="btnVoltarNotaFiscalProduto_Click" />
    </asp:View>
</asp:MultiView>
<p>
</p>
