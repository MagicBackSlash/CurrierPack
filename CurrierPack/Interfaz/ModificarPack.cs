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
using System.Net.Mail;
using System.Net;


namespace Interfaz
{
    public partial class brpaquete : Form
    {
        CPaquetes paquetes = new CPaquetes();
        DataView dv = new DataView();


        public brpaquete()
        {
            InitializeComponent();
            MaterialSkinManager M = MaterialSkinManager.Instance;

            M.Theme = MaterialSkinManager.Themes.DARK;
            M.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red600, Accent.Red400, TextShade.WHITE);
        }

        public void actualizarPaquetes()
        {
            CPaquetes paquetes = new CPaquetes();
            tablapaquetes.DataSource = paquetes.mostrarpaquetes();

        }

        private void ModificarPack_Load(object sender, EventArgs e)
        {
            actualizarPaquetes();
        }




        private void filtrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (brnombre.Checked == true)
            {
                try
                {
                    CPaquetes paquete = new CPaquetes();
                    tablapaquetes.DataSource = paquete.buscarpaquetes(txtfiltrar.Text,"Nombre");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error  " + ex);
                }
            }

            if(brestado.Checked == true)
            {
                try
                {
                    CPaquetes paquete = new CPaquetes();
                    tablapaquetes.DataSource = paquete.buscarpaquetes(txtfiltrar.Text,"Estado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error  " + ex);
                }

            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (tablapaquetes.SelectedRows.Count > 0)
            {
                cbestado.Text = tablapaquetes.CurrentRow.Cells["Estado"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la lista");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    paquetes.editarstate(cbestado.Text, tablapaquetes.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                if (cbestado.Text == "Entregado")
                {
                    paquetes.ponerfecha(Ponerfecha.Text, tablapaquetes.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                    cbestado.Text = " ";

                    MessageBox.Show("Datos actualizados: " + tablapaquetes.CurrentRow.Cells["Correo"].Value.ToString());

                    actualizarPaquetes();
                }

                if (cbestado.Text == "Disponible")
                    {
                        string to = tablapaquetes.CurrentRow.Cells["Correo"].Value.ToString();
                        try
                        {


                         

                                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                                msg.To.Add(to);
                                msg.Subject = "Entrega de paquete";
                                msg.SubjectEncoding = System.Text.Encoding.UTF8;


                                msg.Body = string.Format("Ha llegado su paquete No.{0}", tablapaquetes.CurrentRow.Cells["ID"].Value.ToString());
                                msg.BodyEncoding = System.Text.Encoding.UTF8;
                                msg.IsBodyHtml = true;
                                msg.From = new System.Net.Mail.MailAddress("currierpack99@gmail.com");

                                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                                cliente.UseDefaultCredentials = false;
                                cliente.Credentials = new System.Net.NetworkCredential("currierpack99@gmail.com", "Proyectop1");
                                cliente.Port = 587;
                                cliente.EnableSsl = true;
                                cliente.Host = "smtp.gmail.com";

                                cliente.Send(msg);
                            MessageBox.Show("Datos actualizados: " + tablapaquetes.CurrentRow.Cells["Correo"].Value.ToString());
                        }




                            //var client = new SmtpClient("smtp.gmail.com", 587)
                            //{
                            //    Credentials = new NetworkCredential("currierpack99@gmail.com", "Proyectop1"),
                            //    EnableSsl = true
                            //};
                            //client.Send("currierpack99@gmail.com", "e.cabrera99@hotmail.com", "test", "testbody");


                        




                        catch (Exception EX)
                        {
                            MessageBox.Show("Mensaje no enviado:" + EX);
                        }
                    }

                



                    



                    else
                    {
                        cbestado.Text = " ";
                        MessageBox.Show("Datos actualizados");
                        actualizarPaquetes();
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("error;  " + ex);
                }
            
        }

        private void txtfiltrar_Click(object sender, EventArgs e)
        {


        }
        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
