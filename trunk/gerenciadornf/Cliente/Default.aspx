<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Cliente.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Cliente/ListaCliente.ascx" TagName="ListaCliente"
    TagPrefix="uc1" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Clientes</h2>
    <br />
    <uc1:ListaCliente ID="ListaCliente1" runat="server" />
</asp:Content>
