using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegociosN;

namespace PresentacionP
{
    public partial class ClientesP : System.Web.UI.Page
    {
        ClientesN clientesN;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarClientes("%");
                lblCorrecto.Visible = false;
                lblError.Visible = false;
            }
        }
        protected void btnguardarCliente_Click(object sender, EventArgs e)
        {
            clientesN = new ClientesN();
            bool? respuesta = clientesN.InsertarClientes(txtId_Cliente.Text, txtNombre_Cliente.Text, txtApellido_Cliente.Text, txtTelefono_Cliente.Text, txtDireccion_Cliente.Text, txtCorreo_Cliente.Text);
            if (respuesta == true)
            {
                lblCorrecto.Text = "Se registro correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                Limpiar();
                CargarClientes("%");
            }
            else
            {
                lblError.Text = "Ocurrio un error no se registro.";
                lblError.Visible = true;
            }
        }

        public void CargarClientes(string strFiltro)
        {
            clientesN = new ClientesN();
            var items = clientesN.ListadoClientes(strFiltro);
            dtgListadoClientes.DataSource = items;
            dtgListadoClientes.DataBind();
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                CargarClientes(txtFiltro.Text);
            }
            else
            {
                lblError.Text = "Ocurrio un error no se registro.";
                lblError.Visible = true;
            }
        }

        protected void dtgListadoClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlingresar.Visible = true;
            btnactualizar.Visible = true;
            btnIngresarCliente.Visible = false;
            btnguardarCliente.Visible = false;
            txtId_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[1].Text);
            txtNombre_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[2].Text);
            txtApellido_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[3].Text);
            txtTelefono_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[4].Text);
            txtDireccion_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[5].Text);
            txtCorreo_Cliente.Text = HttpUtility.HtmlDecode(dtgListadoClientes.SelectedRow.Cells[6].Text);
        }

        public void Limpiar()
        {
            txtId_Cliente.Text = string.Empty;
            txtNombre_Cliente.Text = string.Empty;
            txtApellido_Cliente.Text = string.Empty;
            txtTelefono_Cliente.Text = string.Empty;
            txtDireccion_Cliente.Text = string.Empty;
            txtCorreo_Cliente.Text = string.Empty;
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            clientesN = new ClientesN();
            bool? respuesta = clientesN.ActualizarCliente(txtId_Cliente.Text, txtNombre_Cliente.Text, txtApellido_Cliente.Text, txtTelefono_Cliente.Text, txtDireccion_Cliente.Text, txtCorreo_Cliente.Text);
            if (respuesta == true)
            {
                lblCorrecto.Text = "El registro se actualizó correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                Limpiar();
                CargarClientes("%");
                btnIngresarCliente.Visible = true;
            }
            else
            {
                lblError.Text = "Ocurrio un error no se actualizó.";
            }
        }

        protected void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            pnlingresar.Visible = true;
            btnIngresarCliente.Visible = false;
            btnactualizar.Visible = false;

        }
    }
}