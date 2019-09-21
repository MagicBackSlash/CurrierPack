using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Codigo;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            CEmpleado objempleado = new CEmpleado();
            SqlDataReader logear;
            objempleado.Usuario = txtusuario.Text;
            objempleado.Password = txtcontraseña.Text;
            logear = objempleado.Iniciarsesion();

            try
            {
                if (logear.Read() == true)
                {
                    this.Hide();
                    Pestañaprincipal abrir = new Pestañaprincipal();
                    Program.TipoUsuario = logear["TipoUsuario"].ToString();
                    Program.Usuario = logear["Usuario"].ToString();
                    abrir.ShowDialog();
                    this.Close();
                }
                else

                    MessageBox.Show("Usuario o contraseña son invalidos");


            }

            catch(Exception)
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }


    }
}
