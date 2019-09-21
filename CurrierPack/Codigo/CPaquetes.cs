using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;


namespace Codigo
{
    public class CPaquetes
    {
        Consultadb paquetes = new Consultadb();
        DataTable tabla = new DataTable();


        public DataTable mostrarpaquetes()
        {
            
            tabla = paquetes.MostrarPaquetes();
            return tabla;

        }

        public DataTable buscarpaquetes(string obj,string fliadb)
        {
            tabla = paquetes.Buscar(obj,fliadb);
            return tabla;
        }

        public void editarstate(string estado, string CodigoUsuario)
        {
            paquetes.Editarstate(estado, CodigoUsuario);
        }

        public void ponerfecha(string fecha, string CodigoUsuario)
        {
            paquetes.Ponerfecha(fecha, CodigoUsuario);
        }

        public void insertarpack(string Nombre, string CodigoUsuario, string Contenidon, string ID, string Proveedor, string Libras, string Estado, string Correo)
        {
            paquetes.insertarpack(Nombre,CodigoUsuario,Contenidon, ID, Proveedor,  Libras,  Estado,  Correo, "Null");

        }

        public void borrarpack(string ID)
        {
            paquetes.Borrarpack(ID);
        }

        public void editarrpack(string Nombre, string CodigoUsuario, string Contenidon, string ID, string Proveedor, string Libras, string Estado, string Correo)
        {
            paquetes.editarrpack(Nombre, CodigoUsuario, Contenidon, ID, Proveedor, Libras, Estado, Correo);
        }


    }
}
