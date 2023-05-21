<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductosP.aspx.cs" Inherits="PresentacionP.ProductosP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <style>
        * {
            padding: 0;
            margin: 0;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 50vh;
        }

        .principal {
            text-align: center;
            align-items: center;
        }

        .input-box {
            display: flex;
            justify-content: space-between;
        }

            .input-box label {
                margin: 0 150px;
            }

        h2 {
            text-align: center;
        }

        .buttons {
            display: flex;
            justify-content: space-between;
        }
    </style>

    <form id="form1" runat="server">

        <div class="principal">

            <asp:Panel ID="pnlListadoProductos" runat="server" Width="100%">
                <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                <asp:Button ID="btnbuscar" runat="server" Text="Buscar Productos" OnClick="btnbuscar_Click" />
                <br />
                <br />
                <br />
                <asp:GridView ID="dtgListadoProductos" runat="server"
                    AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanged="dtgListadoProductos_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id_Producto" HeaderText="Id" />
                        <asp:BoundField DataField="Nombre_Producto" HeaderText="Nombre" />
                        <asp:BoundField DataField="Descripcion_Producto" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Cantidad_Producto" HeaderText="Cantidad" />
                        <asp:BoundField DataField="PrecioxUnidad_Producto" HeaderText="Precio" />
                        <asp:BoundField DataField="Id_Categoria" HeaderText="Categoria" />
                    </Columns>

                </asp:GridView>

            </asp:Panel>
            <br />
            <asp:Label ID="lblCorrecto" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <asp:Panel ID="pnlingresar" runat="server" Visible="false">
                <h2 class="tittle">PRODUCTOS</h2>
                <br />

                <div class="input-box">
                    <asp:Label ID="lblId_Producto" runat="server" Text="Id Productos: "></asp:Label>
                    <asp:TextBox ID="txtId_Producto" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblNombre_Productos" runat="server" Text="Nombre Productos: "></asp:Label>
                    <asp:TextBox ID="txtNombre_Productos" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblDescripcion_Productos" runat="server" Text="Descripcion: "></asp:Label>
                    <asp:TextBox ID="txtDescripcion_Productos" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblCantidad_Productos" runat="server" Text="Cantidad: "></asp:Label>
                    <asp:TextBox ID="txtCantidad_Productos" runat="server" Onkeypress="return isNumberKey(evt)"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblPrecio_Productos" runat="server" Text="Precio: "></asp:Label>
                    <asp:TextBox ID="txtPrecio_Productos" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblCategoria" runat="server" Text="Categoria: "></asp:Label>
                    <asp:DropDownList ID="ddlCategoria" runat="server">
                        <asp:ListItem Value="1" Text="GASEOSAS"></asp:ListItem>
                        <asp:ListItem Value="2" Text="LACTEOS"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <br />

                <div class="btx">
                    <asp:Button ID="btnguardarProducto" runat="server" Text="GUARDAR" OnClick="btnguardarProducto_Click" />
                </div>

                <div class="buttons">
                    <div class="btx">
                        <asp:Button ID="btnactualizar_Producto" runat="server" Text="Actualizar" OnClick="btnactualizar_Producto_Click" />
                    </div>

                    <div class="btx">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </div>
                </div>
            </asp:Panel>
            <br />
            <br />
            <asp:Button ID="btnIngresar_Producto" runat="server" Text="Ingresar Producto" OnClick="btnIngresar_Producto_Click" />
        </div>

    </form>
</body>
</html>
