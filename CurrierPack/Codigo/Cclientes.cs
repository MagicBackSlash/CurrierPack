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
    public class Cclientes
    {
        Consultadb  Consultorclientes = new Consultadb();
        public DataTable enseñar()
        {
            DataTable tabla = new DataTable();
            tabla = Consultorclientes.MostrarClientes();
            return tabla;

        }

        public void insertarcliente(string Nombre, string Apellido, string Direccion, string CodigoUsuario, string Correo, string Genero)
        {
            Consultorclientes.insertar(Nombre,Apellido,Direccion,CodigoUsuario,Correo,Genero);

        }

        public void borrarcliente(string CodigoUsuario)
        {
            Consultorclientes.Borrar(CodigoUsuario);
        }

        public void editarcliente(string Nombre, string Apellido, string Direccion, string CodigoUsuario, string Correo, string Genero)
        {

            Consultorclientes.Editar(Nombre, Apellido, Direccion, CodigoUsuario, Correo, Genero);

        }
    }
}
