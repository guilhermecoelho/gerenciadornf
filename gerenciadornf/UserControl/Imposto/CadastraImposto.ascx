<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CadastraImposto.ascx.cs" Inherits="gerenciadornf.UserControl.Imposto.CadastraImposto" %>
Nome<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
Descrição<asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox><br />
Valor<asp:TextBox ID="txtValor" runat="server"></asp:TextBox><br />
Classificação fiscal<asp:DropDownList ID="ddlClassificacaoFiscal" runat="server"></asp:DropDownList><br />
Origem mercadoria<asp:DropDownList ID="ddlOrigemMercadoria" runat="server"></asp:DropDownList><br />
Situação tributaria<asp:DropDownList ID="ddlSituacaoTributaria" runat="server"></asp:DropDownList><br />
Modalidade<asp:DropDownList ID="ddlModalidade" runat="server"></asp:DropDownList><br />
Aliquita ICMS<asp:TextBox ID="txtAliquitaICMS" runat="server"></asp:TextBox><br />
Aliquita IPI<asp:TextBox ID="txtAliquitaIPI" runat="server"></asp:TextBox><br />