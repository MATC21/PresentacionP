using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesE;

namespace AccesoDatosD
{
    public class ClientesD
    {

        public bool? InsertarClientes(String @strCedula_Cliente, String @strNombre_Cliente, String @strApellido_Cliente, String @strTelefono_Cliente, String @strDireccion_Cliente, String @strCorreo_Cliente)
        {
            bool? respuesta = false;

            try
            {
                using (IngresoClientesEntities context = new AccesoDatosD.IngresoClientesEntities())
                {
                    var sp = context.sp_Ingreso_Clientes(strCedula_Cliente, strNombre_Cliente, strApellido_Cliente, strTelefono_Cliente, strDireccion_Cliente, strCorreo_Cliente);
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

        public List<ClientesE> ListadoClientes(string @strFiltro) 
        {
            List<ClientesE> Doc = new List<ClientesE>();
            using (IngresoClientesEntities context = new AccesoDatosD.IngresoClientesEntities()) 
            { 
                var sp = context.sp_listar_clientes(@strFiltro);
                foreach(var item in sp)
                {
                    ClientesE doc = new ClientesE();
                    doc.Id_Cliente = item.Id_Cliente;
                    doc.Nombre_Cliente = item.Nombre_Cliente;
                    doc.Apellido_Cliente = item.Apellido_Cliente;
                    doc.Telefono_Cliente = item.Telefono_Cliente;
                    doc.Direccion_Cliente = item.Direccion_Cliente;
                    doc.Correo_Cliente = item.Correo_Cliente;
                    Doc.Add(doc);
                }
            }
            return Doc;
        }

        public bool? ActualizarCliente(string @strCedula, string @strNombre, string @strApellido,string @strTelefono, string @strDireccion, string @strEmail)
        {
            bool? respuesa = false;

            try 
            {
                using (IngresoClientesEntities context = new AccesoDatosD.IngresoClientesEntities())
                {
                    var sp = context.sp_actualizar_cliente(strCedula,strNombre,strApellido,strTelefono,strDireccion,strEmail);
                    foreach (var item in sp)
                    {
                        respuesa = item.Respuesta;
                    }
                }
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            return respuesa;
        }

    }

}
