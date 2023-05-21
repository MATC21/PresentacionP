using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosD;
using EntidadesE;

namespace NegociosN
{
    public class ProductosN
    {
        ProductosD productosD = new ProductosD();

        public bool? InsertarProductos(string @strNombre_Producto, string @strDescripcion_Producto, int @strCantidad_Producto, decimal @strPrecioxUnidad_Producto, int @strId_Categoria) 
        {
            productosD = new ProductosD();
            return productosD.InsertarProductos(strNombre_Producto, strDescripcion_Producto, strCantidad_Producto, strPrecioxUnidad_Producto, strId_Categoria);
        }

        public List<ProductosE> ListadoProductos(string @strFiltro)
        {
            productosD = new ProductosD();
            return productosD.ListadoProductos(strFiltro);
        }

        public bool? ActualizarProducto(int @Id_Producto, string @strNombre_Producto, string @strDescripcion_Producto, int @strCantidad_Producto, decimal @strPrecioxUnidad_Producto, int @strId_Categoria)
        {
            productosD = new ProductosD();
            return productosD.ActualizarProducto(Id_Producto, strNombre_Producto, strDescripcion_Producto, strCantidad_Producto, strPrecioxUnidad_Producto, strId_Categoria);
        }

    }
}
