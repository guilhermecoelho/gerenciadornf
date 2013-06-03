<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.NotaFiscal.Produtos.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../../UserControl/NotaFiscal/Produtos/ListaNotaFiscalProduto.ascx"
    TagName="ListaNotaFiscalProduto" TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaNotaFiscalProduto ID="ListaNotaFiscalProduto1" runat="server" />
</asp:Content>
