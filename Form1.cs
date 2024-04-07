using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_PrograIV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Establecer la posición de inicio del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase_Conexion.Abrir_Conexion();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridViewDatos.DataSource = Obetener_Datos();
        }

        public DataTable Obetener_Datos()
        {
            Clase_Conexion.Abrir_Conexion();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Empleados";
            SqlCommand cmd = new SqlCommand(consulta, Clase_Conexion.Abrir_Conexion());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

