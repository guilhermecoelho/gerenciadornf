<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="gerenciadornf.UserControl.Menu.Menu" %>
<asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false"
    IncludeStyleBlock="false" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" />
        <asp:MenuItem NavigateUrl="~/NotaFiscal/Default.aspx" Text="Nota Fiscal" />
        <asp:MenuItem NavigateUrl="~/Cliente/Default.aspx" Text="Cliente" />
        <asp:MenuItem NavigateUrl="~/Emitente/Default.aspx" Text="Emitente" />
        <asp:MenuItem NavigateUrl="~/Transportadora/Default.aspx" Text="Transportadora" />
        <asp:MenuItem NavigateUrl="~/FormaPagamento/Default.aspx" Text="Formas de Pagamento" />
        <asp:MenuItem NavigateUrl="~/Produto/Default.aspx" Text="Produtos" />
        <asp:MenuItem NavigateUrl="~/Usuario/Default.aspx" Text="Usuários" />
    </Items>
</asp:Menu>
