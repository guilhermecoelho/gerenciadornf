<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.NotaFiscal.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/NotaFiscal/ListaNotaFiscal.ascx" TagName="ListaNotaFiscal"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaNotaFiscal ID="ListaNotaFiscal1" runat="server" />
</asp:Content>
