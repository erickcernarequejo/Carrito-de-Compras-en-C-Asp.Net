<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista_Comprado.aspx.cs" Inherits="CarritoCompras.Lista_Comprado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 88%">
        <tr>
            <td colspan="3" style="text-align: center; color: #9999FF; font-size: large">
                <strong>Mi Carrito de Compras</strong></td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px">
                <asp:TextBox ID="txtCodigo" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                <strong>Fecha :</strong></td>
            <td style="width: 397px">
                <asp:Label ID="lblFecha" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                Cliente :</td>
            <td style="width: 397px">
                <asp:TextBox ID="txtCliente" runat="server" Width="332px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                Email :</td>
            <td style="width: 397px">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Width="329px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Width="505px" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Quitar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" 
                                    ImageUrl="~/Imagenes/borrar.jpg" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="codproducto" HeaderText="Codigo" />
                        <asp:BoundField DataField="desproducto" HeaderText="Descripcion" />
                        <asp:BoundField DataField="preproducto" HeaderText="Precio" />
                        <asp:TemplateField HeaderText="Cantidad">
                            <ItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="73px">1</asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="subtotal" HeaderText="Sub Total" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                SubTotal S/ :&nbsp; 
                <asp:Label ID="lblSubTotal" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                IGV S/ :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblIGV" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px; text-align: right">
                Total S/ :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 77px">
                &nbsp;</td>
            <td style="width: 397px">
                <asp:Button ID="Button1" runat="server" Text="Actualizar" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Continuar Compras" 
                    style="margin-left: 111px" Width="157px" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" style="margin-left: 34px" 
                    Text="Comprar" Width="120px" OnClick="Button3_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
