<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesP.aspx.cs" Inherits="PresentacionP.ClientesP" %>

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

        .btn{
            display: flex;
            justify-content: space-between;
        }

    </style>

    <form id="form1" runat="server">
        <div class="principal">

            <asp:Panel ID="pnlListadoClientes" runat="server" Width="100%">
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnbuscar" runat="server" Text="Buscar Cliente" OnClick="btnbuscar_Click"/>
            <br />
            <asp:GridView ID="dtgListadoClientes" runat="server"
                AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanged="dtgListadoClientes_SelectedIndexChanged"
                >
                <Columns>
                    <asp:BoundField DataField="Id_Cliente" HeaderText="Cédula" />
                    <asp:BoundField DataField="Nombre_Cliente" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellido_Cliente" HeaderText="Apellido" />
                    <asp:BoundField DataField="Telefono_Cliente" HeaderText="Teléfono" />
                    <asp:BoundField DataField="Direccion_Cliente" HeaderText="Dirección" />
                    <asp:BoundField DataField="Direccion_Cliente" HeaderText="Dirección" />
                </Columns>

            </asp:GridView>

        </asp:Panel>
            <asp:Label ID="lblCorrecto" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            
            <asp:Panel ID="pnlingresar" runat="server" Visible="false">
                <h2>INGRESO DE CLIENTES</h2>
                <br />
                <br />
                <div class="input-box">
                    <asp:Label ID="lblId_Cliente" runat="server" Text="CI CLIENTE: "></asp:Label>
                    <asp:TextBox ID="txtId_Cliente" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblNombre_Cliente" runat="server" Text="NOMBRE: "></asp:Label>
                    <asp:TextBox ID="txtNombre_Cliente" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblApellido_Cliente" runat="server" Text="APELLIDO: "></asp:Label>
                    <asp:TextBox ID="txtApellido_Cliente" runat="server" Onkeypress="return isNumberKey(evt)"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lbltelf" runat="server" Text="TELEFONO: "></asp:Label>
                    <asp:TextBox ID="txtTelefono_Cliente" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION: "></asp:Label>
                    <asp:TextBox ID="txtDireccion_Cliente" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <asp:Label ID="lblcorreo" runat="server" Text="CORREO: "></asp:Label>
                    <asp:TextBox ID="txtCorreo_Cliente" runat="server"></asp:TextBox>
                </div>

                <br />
                <div class="btn">
                    <asp:Button ID="btnguardarCliente" runat="server" Text="GUARDAR" OnClick="btnguardarCliente_Click"/>
                </div>
                <div class="btx">
                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click"/>
                </div>
            </asp:Panel>
            <br />
            <br />
            <asp:Button ID="btnIngresarCliente" runat="server" Text="Ingresar Cliente" OnClick="btnIngresarCliente_Click"/>
        </div>
    </form>
</body>
</html>
