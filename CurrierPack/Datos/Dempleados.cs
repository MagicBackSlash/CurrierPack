using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dempleados
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;

        public SqlDataReader iniciar(string usuario, string password)
        {

            string sql = "select *from TablaEmpleado where CodigoEmpleado = '"+usuario+ "' and Password= '" + password+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrirconection();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
