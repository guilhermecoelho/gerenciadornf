<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gerenciadornf.Item.Default" MasterPageFile="~/Site.master"%>

<%@ Register src="../UserControl/Item/ListaItem.ascx" tagname="ListaItem" tagprefix="uc1" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
     <uc1:ListaItem ID="ListaItem1" runat="server" />
</asp:Content>
       
    

