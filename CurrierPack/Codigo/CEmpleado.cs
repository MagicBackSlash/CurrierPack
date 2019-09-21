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
    public class CEmpleado
    {
        private Dempleados obj = new Dempleados();

        private string _usuario;
        private string _password;


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }

        }

        public CEmpleado(){}

        public SqlDataReader Iniciarsesion()
        {
            SqlDataReader logear;

            logear = obj.iniciar(Usuario, Password);
            return logear;
        }

    }
}
