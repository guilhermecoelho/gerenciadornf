<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Emitente.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Emitente/ListaEmitente.ascx" TagName="ListaEmitente"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaEmitente ID="ListaEmitente1" runat="server" />
</asp:Content>
