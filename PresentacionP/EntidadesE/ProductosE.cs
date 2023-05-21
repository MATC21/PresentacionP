using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesE
{
    public class ProductosE
    {
        public string Nombre_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public decimal PrecioxUnidad_Producto { get;set; }
        public int Id_Categoria{ get; set; }

        public int Id_Producto { get; set; }

    }
}
