<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Produto.Default"
    MasterPageFile="~/Site.master" %>

<%@ Register Src="../UserControl/Produto/ListaProduto.ascx" TagName="ListaProduto"
    TagPrefix="uc1" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <uc1:ListaProduto ID="ListaProduto1" runat="server" />
</asp:Content>
