<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.FormaPagamento.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/FormaPagamento/ListaFormaPagamento.ascx" TagName="ListaFormaPagamento"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaFormaPagamento ID="ListaFormaPagamento1" runat="server" />
</asp:Content>
