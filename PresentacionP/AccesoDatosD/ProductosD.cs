using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesE;

namespace AccesoDatosD
{
    public class ProductosD
    {

        public bool? InsertarProductos(string @strNombre_Producto,string @strDescripcion_Producto, int @strCantidad_Producto,decimal @strPrecioxUnidad_Producto,int @strId_Categoria)
        {
            bool? respuesta = false;

            try
            {
                using (ProductosEntities context = new AccesoDatosD.ProductosEntities())
                {
                    var sp = context.sp_Ingreso_Producto(strNombre_Producto, strDescripcion_Producto, strCantidad_Producto,strPrecioxUnidad_Producto, strId_Categoria);
                    foreach (var item in sp)
                    {
                        respuesta = item.RESPUESTA;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return respuesta;
        }

        public List<ProductosE> ListadoProductos(string @strFiltro)
        {
            List<ProductosE> Doc = new List<ProductosE>();
            using (ProductosEntities context = new AccesoDatosD.ProductosEntities())
            {
                var sp = context.sp_listar_productos(@strFiltro);
                foreach (var item in sp)
                {
                    ProductosE doc = new ProductosE();
                    doc.Id_Producto = item.Id_Producto;
                    doc.Nombre_Producto = item.Nombre_Producto;
                    doc.Descripcion_Producto = item.Descripcion__Producto;
                    doc.Cantidad_Producto = (int)item.Cantidad_Producto;
                    doc.PrecioxUnidad_Producto =(decimal)item.PrecioxUnidad_Producto;
                    doc.Id_Categoria = (int)item.Id_Categoria;
                    Doc.Add(doc);
                }
            }
            return Doc;
        }

        public bool? ActualizarProducto(int @Id_Producto, string @strNombre_Producto, string @strDescripcion_Producto, int @strCantidad_Producto, decimal @strPrecioxUnidad_Producto, int @strId_Categoria)
        {
            bool? respuesa = false;

            try
            {
                using (ProductosEntities context = new AccesoDatosD.ProductosEntities())
                {
                    var sp = context.sp_Actualizar_Producto(Id_Producto,strNombre_Producto, strDescripcion_Producto, strCantidad_Producto, strPrecioxUnidad_Producto, strId_Categoria);
                    foreach (var item in sp)
                    {
                        respuesa = item.Respuesta;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return respuesa;
        }

    }
}
