<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Imposto.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Imposto/ListaImposto.ascx" TagName="ListaImposto"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaImposto ID="ListaImposto1" runat="server" />
</asp:Content>
