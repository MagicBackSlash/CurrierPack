using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public class Consultadb
    {

        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarClientes()
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "select *from Cliente";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconection();
            return tabla;

        }

        public DataTable MostrarPaquetes()
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "select *from Paquete";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconection();
            return tabla;

        }

        public DataTable Buscar(string obj,string filadb)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = string.Format("select *from paquete where {1} like '%{0}%'", obj,filadb);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconection();
            return tabla;

        }

        public void insertarpack(string Nombre, string CodigoUsuario, string Contenidon, string ID, string Proveedor, string Libras, string Estado, string Correo, string FechaRecogida)
        {

            comando.Connection = conexion.abrirconection();
            comando.CommandText = "insert into paquete values('" + Nombre + "','" + CodigoUsuario + "','" + Contenidon + "','" + ID + "','" + Proveedor + "','" + Libras + "','"+Estado+"','"+Correo+"','"+ FechaRecogida + "')";
            comando.ExecuteNonQuery();

        }


        public void insertar(string Nombre, string Apellido, string Direccion, string CodigoUsuario, string Correo, string Genero)
        {

            comando.Connection = conexion.abrirconection();
            comando.CommandText = "insert into Cliente values('"+ Nombre + "','"+Apellido + "','"+ Direccion+ "','"+ CodigoUsuario + "','"+ Correo + "','"+ Genero + "')";
            comando.ExecuteNonQuery();

        }

        public void editarrpack(string Nombre, string CodigoUsuario, string Contenidon, string ID, string Proveedor, string Libras, string Estado, string Correo)
        {

            comando.Connection = conexion.abrirconection();
            comando.CommandText = "update paquete set Nombre='" + Nombre + "', CodigoUsuario='" + CodigoUsuario+ "', Contenido='" + Contenidon+"', ID='"+ID+ "', Proveedor='" + Proveedor+ "', Libras='" + Libras+"', Estado='"+Estado+"', Correo='"+ Correo + "' where ID='" +ID+ "' ";
            comando.ExecuteNonQuery();

        }

        public void Editar(string Nombre, string Apellido, string Direccion, string CodigoUsuario, string Correo, string Genero)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "update Cliente set Nombre='" + Nombre + "', Apellido='" + Apellido + "', Direccion='" + Direccion + "', CodigoUsuario='" + CodigoUsuario + "', Correo='" + Correo + "', Genero='" + Genero + "' where CodigoUsuario='" + CodigoUsuario + "'";
            comando.ExecuteNonQuery();
        
        }

        public void Editarstate(string estado, string CodigoUsuario)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "update paquete set Estado='" + estado + "' where CodigoUsuario='" + CodigoUsuario + "' ";
            comando.ExecuteNonQuery();

        }

        public void Ponerfecha( string fecha, string CodigoUsuario)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "update paquete set FechaRecogida='" + fecha + "' where CodigoUsuario='"+CodigoUsuario+"'";
            comando.ExecuteNonQuery();
        }

        public void Borrar(string CodigoUsuario)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "delete from Cliente where CodigoUsuario='" + CodigoUsuario + "'";
            comando.ExecuteNonQuery();
        }
        public void Borrarpack(string ID)
        {
            comando.Connection = conexion.abrirconection();
            comando.CommandText = "delete from paquete where ID='" + ID + "'";
            comando.ExecuteNonQuery();
        }


    }
}
