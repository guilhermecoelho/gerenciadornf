<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Usuario.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Usuario/ListaUsuario.ascx" TagName="ListaUsuario"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaUsuario ID="ListaUsuario1" runat="server" />
</asp:Content>
