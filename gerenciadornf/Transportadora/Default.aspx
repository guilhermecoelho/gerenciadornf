<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Transportadora.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Transportadora/ListaTransportadora.ascx" TagName="ListaTransportadora"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaTransportadora ID="ListaTransportadora1" runat="server" />
</asp:Content>
