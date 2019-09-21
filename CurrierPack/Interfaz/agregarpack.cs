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
using Datos;
using System.Data.SqlClient;

namespace Interfaz
{
    public partial class agregarpack : Form
    {

        CPaquetes consultarpack = new CPaquetes();
        public bool editar = false;

        public agregarpack()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;

            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        private void agregarpack_Load(object sender, EventArgs e)
        {
            actualizarPaquetes();
           
        }

        public void actualizarPaquetes()
        {
            CPaquetes paquetes = new CPaquetes();
            tablaagregarpack.DataSource = paquetes.mostrarpaquetes();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (txtnombre.Text != "" && txtcorreo.Text != "" && txtcodigous.Text != "" && txtid.Text != "")
                {

                    try
                    {
                        consultarpack.insertarpack(txtnombre.Text, txtcodigous.Text, cbcontenido.Text, txtid.Text, cbproveedor.Text, txtlibra.Text, cbestado.Text, txtcorreo.Text);
                        MessageBox.Show("paquete agregado con exito");
                        actualizarPaquetes();

                        txtnombre.Clear();
                        txtcodigous.Clear();
                        cbcontenido.Text = "";
                        txtid.Clear();
                        cbproveedor.Text = "";
                        txtlibra.Clear();
                        cbestado.Text = "";
                        txtcorreo.Clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar paquete:  " + ex);
                    }
                }
                else { MessageBox.Show("Hay datos obligatorios que debes llenar: nombre, correo, codigo de usuario y la id del paquete"); }
            }

            if (editar == true)
            {
                if (txtnombre.Text != "" && txtcorreo.Text != "" && txtcodigous.Text != "" && txtid.Text != "")
                {
                    try
                    {
                        consultarpack.editarrpack(txtnombre.Text, txtcodigous.Text, cbcontenido.Text, txtid.Text, cbproveedor.Text, txtlibra.Text, cbestado.Text, txtcorreo.Text);
                        MessageBox.Show("Paquete editado correctamente");
                        actualizarPaquetes();
                        editar = false;

                        txtnombre.Clear();
                        txtcodigous.Clear();
                        cbcontenido.Text = "";
                        txtid.Clear();
                        cbproveedor.Text = "";
                        txtlibra.Clear();
                        cbestado.Text = "";
                        txtcorreo.Clear();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error al editar:  " + ex);
                    }

                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            
            if (tablaagregarpack.SelectedRows.Count > 0)
            {
                
                editar = true;
                txtnombre.Text = tablaagregarpack.CurrentRow.Cells["Nombre"].Value.ToString();
                txtcodigous.Text = tablaagregarpack.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                cbcontenido.Text = tablaagregarpack.CurrentRow.Cells["Contenido"].Value.ToString();
                txtid.Text = tablaagregarpack.CurrentRow.Cells["ID"].Value.ToString();
                cbproveedor.Text = tablaagregarpack.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtlibra.Text = tablaagregarpack.CurrentRow.Cells["Libras"].Value.ToString();
                cbestado.Text = tablaagregarpack.CurrentRow.Cells["Estado"].Value.ToString();
                txtcorreo.Text = tablaagregarpack.CurrentRow.Cells["Correo"].Value.ToString();


            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la lista");
            }

        
        
        }

    

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (tablaagregarpack.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Seguro que quieres eliminar al usiario: " + tablaagregarpack.CurrentRow.Cells["CodigoUsuario"].Value.ToString() + " Con el nombre de: " + tablaagregarpack.CurrentRow.Cells["Nombre"].Value.ToString() + " " + tablaagregarpack.CurrentRow.Cells["ID"].Value.ToString(), "advertencia", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                         consultarpack.borrarpack(tablaagregarpack.CurrentRow.Cells["ID"].Value.ToString());
                    }
                    actualizarPaquetes();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error al borrar  "+ex);
                }

            }

            else
            {
                MessageBox.Show("Debes seleccionar un usuario");
            }
        }

        private void Buscarcliente_Click(object sender, EventArgs e)
        {
            Agregar buscarcliente = new Agregar();
            AddOwnedForm(buscarcliente);
            buscarcliente.TopLevel = false;
            buscarcliente.Dock = DockStyle.Fill;
            this.Controls.Add(buscarcliente);
            this.Tag = buscarcliente;
            buscarcliente.BringToFront();
            buscarcliente.Show();




        }
    }
}
