using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_PrograIV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Establecer la posición de inicio del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        SqlConnection con = new SqlConnection("Server=JAFET\\SQLEXPRESS;Database=Db_Login;Integrated Security=True;");

        public void Logear(string usuario, string contra)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM tblUsuarios WHERE Usuario = @usuario AND Contrasena = @pas", con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pas", contra);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Crear un formulario de carga
                PantallaDeCarga pantalladeCarga = new PantallaDeCarga();

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        // Mostrar formulario de carga
                        pantalladeCarga.Show();

                        // Configurar un temporizador para cerrar el formulario de carga después de 5 segundos
                        Timer timer = new Timer();
                        timer.Interval = 5000; // 5000 milisegundos = 5 segundos
                        timer.Tick += (s, ev) =>
                        {
                            // Detener el temporizador
                            timer.Stop();

                            // Cerrar el formulario de carga
                            pantalladeCarga.Close();

                            // Abrir formulario de ControlADM
                            this.Hide();
                            ControlADM controlADM = new ControlADM();
                            controlADM.ShowDialog();
                            this.Close();
                        };
                        timer.Start();
                    }
                    else if (dt.Rows[0][1].ToString() == "Tecnico")
                    {
                        // Mostrar formulario de carga
                        pantalladeCarga.Show();

                        // Configurar un temporizador para cerrar el formulario de carga después de 5 segundos
                        Timer timer = new Timer();
                        timer.Interval = 5000; // 5000 milisegundos = 5 segundos
                        timer.Tick += (s, ev) =>
                        {
                            // Detener el temporizador
                            timer.Stop();

                            // Cerrar el formulario de carga
                            pantalladeCarga.Close();

                            // Abrir formulario de MenuTecnico
                            this.Hide();
                            MenuTecnico menuTecnico = new MenuTecnico();
                            menuTecnico.ShowDialog();
                            this.Close();
                        };
                        timer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        } 




        /*private void txtCedula_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCedula.Text == "Digite su Cedula")
            {
                txtCedula.Text = "";
            }
        }*/



        //CARGA DEL LOAD
        private void Login_Load(object sender, EventArgs e)
        {

            // Obtener la fecha y hora actual
            DateTime fechaHoraActual = DateTime.Now;

            // Mostrar la fecha y hora en el formato deseado en un Label
            label1.Text = fechaHoraActual.ToString("dd/MM/yyyy HH:mm");
        }



            private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Digite su cédula")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.DimGray;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Digite su cédula";
                txtCedula.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ejemplo123")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ejemplo123";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logear(this.txtCedula.Text, this.txtPassword.Text);

            /*String cedulaADM = txtCedula.Text;
            String contraADM = txtPassword.Text;
            string cedulaValidaADM = "1";
            string contraValidaADM = "1";

      

            String cedulaTEC = txtCedula.Text;
            String contraTEC = txtPassword.Text;
            string cedulaValidaTEC = "2";
            string contraValidaTEC = "2";


            // Crear un formulario de carga
            PantallaDeCarga pantalladeCarga = new PantallaDeCarga();

            if (cedulaADM == cedulaValidaADM && contraADM == contraValidaADM)
            {
                // Mostrar formulario de carga
                pantalladeCarga.Show();

                // Configurar un temporizador para cerrar el formulario de carga después de 5 segundos
                Timer timer = new Timer();
                timer.Interval = 5000; // 5000 milisegundos = 5 segundos
                timer.Tick += (s, ev) =>
                {
                    // Detener el temporizador
                    timer.Stop();

                    // Cerrar el formulario de carga
                    pantalladeCarga.Close();

                    // Abrir formulario de ControlADM
                    this.Hide();
                    ControlADM controlADM = new ControlADM();
                    controlADM.ShowDialog();
                    this.Close();
                };
                timer.Start();
            }
            else if (cedulaTEC == cedulaValidaTEC && contraTEC == contraValidaTEC)
            {
                // Mostrar formulario de carga
                pantalladeCarga.Show();

                // Configurar un temporizador para cerrar el formulario de carga después de 5 segundos
                Timer timer = new Timer();
                timer.Interval = 5000; // 5000 milisegundos = 5 segundos
                timer.Tick += (s, ev) =>
                {
                    // Detener el temporizador
                    timer.Stop();

                    // Cerrar el formulario de carga
                    pantalladeCarga.Close();

                    // Abrir formulario de MenuTecnico
                    this.Hide();
                    MenuTecnico menuTecnico = new MenuTecnico();
                    menuTecnico.ShowDialog();
                    this.Close();
                };
                timer.Start();
            }
            else
            {
                // Cerrar el formulario de carga si las credenciales son incorrectas
                pantalladeCarga.Close();

                MessageBox.Show("Cédula o Contraseña incorrecta.\n " +
                    "O dejo campos vacíos.\n " +
                    "Por favor, inténtelo de nuevo.\n",
                    "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Form1 form1 = new Form1();
            //form1.Show();*/
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked == true)

            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
            }
        }
    }
}


    




    
