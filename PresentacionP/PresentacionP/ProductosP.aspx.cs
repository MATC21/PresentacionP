using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegociosN;

namespace PresentacionP
{
    public partial class ProductosP : System.Web.UI.Page
    {
        ProductosN productosN;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack) 
            {
                CargarProducto("%");
                lblId_Producto.Visible = false;
                txtId_Producto.Visible = false;
            }

        }

        public void CargarProducto(string strFiltro) 
        { 
            productosN = new ProductosN();
            var items = productosN.ListadoProductos(strFiltro);
            dtgListadoProductos.DataSource = items;
            dtgListadoProductos.DataBind();
        }
        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                CargarProducto(txtFiltro.Text);
            }
            else
            {
                lblError.Text = "Ocurrio un error no se registro.";
                lblError.Visible = true;
            }
        }

        protected void dtgListadoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlingresar.Visible = true;
            btnactualizar_Producto.Visible = true;
            btnIngresar_Producto.Visible = false;
            btnguardarProducto.Visible = false;
            txtId_Producto.Text = HttpUtility.HtmlDecode(dtgListadoProductos.SelectedRow.Cells[1].Text);
            txtNombre_Productos.Text = HttpUtility.HtmlDecode(dtgListadoProductos.SelectedRow.Cells[2].Text);
            txtDescripcion_Productos.Text = HttpUtility.HtmlDecode(dtgListadoProductos.SelectedRow.Cells[3].Text);
            txtCantidad_Productos.Text = HttpUtility.HtmlDecode(dtgListadoProductos.SelectedRow.Cells[4].Text);
            txtPrecio_Productos.Text = HttpUtility.HtmlDecode(dtgListadoProductos.SelectedRow.Cells[5].Text);
            ddlCategoria.SelectedValue = (dtgListadoProductos.SelectedRow.Cells[6].Text);
        }

        protected void btnguardarProducto_Click(object sender, EventArgs e)
        {
            productosN = new ProductosN();

            bool? respuesta = productosN.InsertarProductos(txtNombre_Productos.Text, txtDescripcion_Productos.Text, Convert.ToInt16(txtCantidad_Productos.Text), Convert.ToDecimal(txtPrecio_Productos.Text),Convert.ToInt16(ddlCategoria.SelectedValue));

            if(respuesta == true) 
            {
                lblCorrecto.Text = "Se registro correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                Limpiar();
                CargarProducto("%");
            }
            else 
            {
                lblError.Text = "Ocurrio un error no se registro.";
                lblError.Visible = true;
            }

        }

        protected void btnactualizar_Producto_Click(object sender, EventArgs e)
        {

            productosN = new ProductosN();
            bool? respuesta = productosN.ActualizarProducto(Convert.ToInt16(txtId_Producto.Text),txtNombre_Productos.Text, txtDescripcion_Productos.Text, Convert.ToInt16(txtCantidad_Productos.Text), Convert.ToDecimal(txtPrecio_Productos.Text), Convert.ToInt16(ddlCategoria.SelectedValue));
            if (respuesta == true)
            {
                lblCorrecto.Text = "El registro se actualizó correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                Limpiar();
                CargarProducto("%");
                btnIngresar_Producto.Visible = false;
            }
            else
            {
                lblError.Text = "Ocurrio un error no se actualizó.";
            }

        }

        protected void btnIngresar_Producto_Click(object sender, EventArgs e)
        {
            pnlingresar.Visible = true;
            btnIngresar_Producto.Visible = false;
            btnactualizar_Producto.Visible = false;
            btnEliminar.Visible = false;
        }

        public void Limpiar()
        {
            txtId_Producto.Text = string.Empty;
            txtNombre_Productos.Text = string.Empty;
            txtDescripcion_Productos.Text = string.Empty;
            txtCantidad_Productos.Text = string.Empty;
            txtPrecio_Productos.Text= string.Empty;
            ddlCategoria.SelectedIndex = 0;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}