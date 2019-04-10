<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito_Compra.aspx.cs" Inherits="CarritoCompras.Carrito_Compra" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-12">
			<div class="jumbotron"  style="background-color:white">
				<table class="table table-responsive">
				<tbody>     
                    <tr>
                        <td>
                            <h1>Lista de Productos</h1>                                                       
                            <asp:Label ID="lblAgregado" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" width="120" height="120" runat="server" ImageUrl="~/Imagenes/carro-de-compras.jpg" OnClick="ImageButton1_Click" />
                        </td>
                    </tr>               
					<tr>
						<td>							

						    <asp:DataList ID="DataList1" runat="server" DataKeyField="codproducto" DataSourceID="SqlDataSource1" RepeatColumns="3" OnItemCommand="DataList1_ItemCommand">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" width="140" height="120" runat="server" ImageUrl='<%# "~/Imagenes/"+Eval("imagen") %>' />
                                    <br />
                                    <br />
                                    Código :
                                    <asp:Label ID="codproductoLabel" runat="server" Text='<%# Eval("codproducto") %>' />
                                    <br />
                                    Producto :
                                    <asp:Label ID="desproductoLabel" runat="server" Text='<%# Eval("desproducto") %>' />
                                    <br />
                                    Categoria :
                                    <asp:Label ID="codcategoriaLabel" runat="server" Text='<%# Eval("codcategoria") %>' />
                                    <br />
                                    Precio :
                                    <asp:Label ID="preproductoLabel" runat="server" Text='<%# Eval("preproducto") %>' />
                                    <br />
                                    Cantidad :
                                    <asp:Label ID="canproductoLabel" runat="server" Text='<%# Eval("canproducto") %>' />
                                    <br />
                                    <asp:Button ID="Button1" runat="server" CommandName="Seleccionar" OnClick="Button1_Click" Text="Agregar al Carrito" />
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>

						    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDVENTAS_5ConnectionString %>" SelectCommand="SELECT * FROM [Productos]"></asp:SqlDataSource>

						</td>
                        						
					</tr>

					
				</tbody>
			</table>
			</div>
		</div>
	</div>
</div>
    
    

</asp:Content>

