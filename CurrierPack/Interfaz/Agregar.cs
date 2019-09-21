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
using Codigo;

namespace Interfaz
{
    public partial class Agregar : Form
    {
        Cclientes clientes = new Cclientes();
        public bool editar = false;

        public Agregar()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;
            
            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

            mostrarclientes();
        }

        public void mostrarclientes()
        {
            Cclientes cliente = new Cclientes();
            viewclientes.DataSource = cliente.enseñar();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {

                    if (txtcodigo.Text != "" && txtcorreo.Text != "") {
                        clientes.insertarcliente(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtcodigo.Text, txtcorreo.Text, txtgenero.Text);
                        MessageBox.Show("Datos insertados correctamente");
                        mostrarclientes();


                        txtnombre.Clear();
                        txtapellido.Clear();
                        txtcodigo.Clear();
                        txtcorreo.Clear();
                        txtdireccion.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("El cliente debe de poseer un codigo y un correo");
                    }

                }

                catch
                {
                    MessageBox.Show("Error al agregar");
                }
            }
            if(editar == true)
            {
                try
                {
                    if (txtcodigo.Text != "" && txtcorreo.Text != "")
                    {
                        clientes.editarcliente(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtcodigo.Text, txtcorreo.Text, txtgenero.Text);
                        mostrarclientes();
                        MessageBox.Show("Datos se editaron correctamente");
                        editar = false;

                        txtnombre.Clear();
                        txtapellido.Clear();
                        txtcodigo.Clear();
                        txtcorreo.Clear();
                        txtdireccion.Clear();
                        
                    }

                    else { MessageBox.Show("Error al editar: El cliente debe tener su codigo y su correo!"); }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al editar;   "+ex);
                }

            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(viewclientes.SelectedRows.Count > 0)
            {
                editar = true;
                txtnombre.Text = viewclientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = viewclientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtdireccion.Text = viewclientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtcodigo.Text= viewclientes.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                txtcorreo.Text= viewclientes.CurrentRow.Cells["Correo"].Value.ToString();
                txtgenero.Text= viewclientes.CurrentRow.Cells["Genero"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la lista");
            }

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (viewclientes.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar al usiario: " + viewclientes.CurrentRow.Cells["CodigoUsuario"].Value.ToString()+" Con el nombre de: "+ viewclientes.CurrentRow.Cells["Nombre"].Value.ToString() +" "+ viewclientes.CurrentRow.Cells["Apellido"].Value.ToString(), "advertencia", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        clientes.borrarcliente(viewclientes.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                    }
                    mostrarclientes();
                }

                catch
                {
                    MessageBox.Show("Error al borrar");
                }

            }

            else
            {
                MessageBox.Show("Debes seleccionar un usuario");
            }


        }

        private void Registro_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_Click(object sender, EventArgs e)
        {

        }

        private void viewclientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agregarpack buscarclientes = Owner as agregarpack;
            buscarclientes.txtnombre.Text = viewclientes.CurrentRow.Cells["Nombre"].Value.ToString();
            buscarclientes.txtcodigous.Text = viewclientes.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
            buscarclientes.txtcorreo.Text = viewclientes.CurrentRow.Cells["Correo"].Value.ToString();
            this.Close();
        }
    }
}
