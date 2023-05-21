using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosD;
using EntidadesE;

namespace NegociosN
{
    public class ClientesN
    {
        ClientesD clientesD = new ClientesD();

        public bool? InsertarClientes(String @strCedula_Cliente, String @strNombre_Cliente, String @strApellido_Cliente, String @strTelefono_Cliente, String @strDireccion_Cliente, String @strCorreo_Cliente) 
        {
            clientesD = new ClientesD();

            return clientesD.InsertarClientes(strCedula_Cliente, strNombre_Cliente, strApellido_Cliente, strTelefono_Cliente, strDireccion_Cliente, strCorreo_Cliente);

        }

        public List<ClientesE> ListadoClientes(string @strFiltro)
        {
            clientesD = new ClientesD();
            return clientesD.ListadoClientes(strFiltro);
        }

        public bool? ActualizarCliente(string @strCedula, string @strNombre, string @strApellido, string @strTelefono, string @strDireccion, string @strEmail)
        {
            clientesD = new ClientesD();
            return clientesD.ActualizarCliente(strCedula, strNombre, strApellido, strTelefono, strDireccion, strEmail);
        }


    }
}
