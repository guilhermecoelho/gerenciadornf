<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraFormaPagamento.ascx.cs" Inherits="gerenciadornf.UserControl.FormaPagamento.CadastraFormaPagamento" %>
Descrição:<asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox><br />
Quantidade de dias:<asp:TextBox ID="txtQtdDias" runat="server"></asp:TextBox><br />
Quantidade de parcelas:<asp:TextBox ID="txtQtdParcela" runat="server"></asp:TextBox><br />
<asp:RadioButton ID="radVista"  Text="A vista" runat="server" />
<asp:RadioButton ID="radParcelado" Text="Parcelado" runat="server" />