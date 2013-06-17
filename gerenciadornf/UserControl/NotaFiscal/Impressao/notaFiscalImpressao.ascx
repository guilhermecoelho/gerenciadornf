<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="notaFiscalImpressao.ascx.cs"
    Inherits="gerenciadornf.UserControl.NotaFiscal.Impressao.notaFiscalImpressao" %>
<table border="1" width="100%">
    <tbody>
        <tr>
            <td>
                <fieldset>
                    <legend>NF-E</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    NFE<br />
                                    <asp:Literal ID="lblNumeroNF" runat="server"></asp:Literal>
                                </td>
                                <td align="left" width="10%">
                                    Versão<br />
                                    1
                                </td>
                                <td align="left" width="10%">
                                    Data Emissão<br />
                                    <asp:Literal ID="lblDataEmissao" runat="server"></asp:Literal>
                                </td>
                                <td align="left" width="10%">

                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    natureza operação<br />
                                    <asp:Literal ID="lblNaturezaOperacao" runat="server"></asp:Literal>
                                </td>
                                <td align="left" width="10%">
                                    Forma de pagamento<br />
                                    <asp:Literal ID="lblFormaPagamento" runat="server"></asp:Literal>
                                </td>
                                <td align="left" width="10%">
                                    Data Saída/Entrada<br />
                                    <asp:Literal ID="lblDataSaidaEntrada" runat="server"></asp:Literal>
                                </td>
                                <td align="left" width="10%">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend>Emitente</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Nome Emitente:<br />
                                    <asp:Literal ID="lblNomeEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    CNPJ<br />
                                    <asp:Literal ID="lblCNPJEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Inscrição Estadual<br />
                                    <asp:Literal ID="lblIEEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    CEP<br />
                                    <asp:Literal ID="lblCepEmitente" runat="server"></asp:Literal><br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Logradura<br />
                                    <asp:Literal ID="lblLograduraEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Número<br />
                                    Número
                                </td>
                                <td align="left" width="10%">
                                    Complemento<br />
                                    <asp:Literal ID="lblNumeroEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Bairro<br />
                                    <asp:Literal ID="lblBairroEmitente" runat="server"></asp:Literal><br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Municipio<br />
                                    <asp:Literal ID="lblCidadeEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    UF<br />
                                    <asp:Literal ID="lblUFEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    telefone<br />
                                    <asp:Literal ID="lblTelefoneEmitente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                </td>
                                <td align="left" width="10%">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend>Destinatário</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                Nome Destinatário:<br />
                                    <asp:Literal ID="lblNomeCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    CNPJ<br />
                                    <asp:Literal ID="lblCNPJCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Inscrição Estadual<br />
                                    <asp:Literal ID="lblIECliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    CEP<br />
                                    <asp:Literal ID="lblCepCliente" runat="server"></asp:Literal><br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Logradura<br />
                                    <asp:Literal ID="lblLograduraCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Número<br />
                                    <asp:Literal ID="lblNumeroCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Complemento<br />
                                    <asp:Literal ID="lblComplementoCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Bairro<br />
                                    <asp:Literal ID="lblBairroCliente" runat="server"></asp:Literal><br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Municipio<br />
                                    <asp:Literal ID="lblCidadeCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    UF<br />
                                    <asp:Literal ID="lblUFCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    telefone<br />
                                    <asp:Literal ID="lblTelefoneCliente" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                </td>
                                <td align="left" width="10%">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend>Valores Totais NF-e</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Base de Cálculo do ICMS<br />
                                    <asp:Literal ID="lblBaseCalculoICMS" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Valor Total do ICMS<br />
                                    <asp:Literal ID="lblTotalICMS" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Valor Total do IPI<br />
                                    <asp:Literal ID="lblValorTotalIPI" runat="server"></asp:Literal><br />
                                </td>
                                <td align="left" width="10%">
                                    Valor Total dos produtos e serviços<br />
                                    <asp:Literal ID="lblValorTotalProduto" runat="server"></asp:Literal><br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend>Produtos</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td>
                                    <asp:GridView ID="gvNotaFiscalProduto" AutoGenerateColumns="false" runat="server">
                                        <Columns>
                                            
                                            <asp:TemplateField HeaderText="produto">
                                                <ItemTemplate>
                                                    <%# Eval("NomeProduto")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Quantidade">
                                                <ItemTemplate>
                                                    <%# Eval("QtdProduto")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Valor unitário">
                                                <ItemTemplate>
                                                    <%# Eval("ValorUnitario")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="IPI">
                                                <ItemTemplate>
                                                    <%# Eval("Ipi")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="ICMS">
                                                <ItemTemplate>
                                                    <%# Eval("Icms")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend>Dados Adicionais</legend>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr>
                                <td align="left" width="10%">
                                    Dados Adicionais<br />
                                    Dados Adicionais
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </fieldset>
            </td>
        </tr>
    </tbody>
</table>
