using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_PrograIV
{
    public partial class MenuTecnico : Form
    {
        public MenuTecnico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar esta" +
                " ventana?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que deseas cerrar sesión",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide();  // Oculta la ventana actual antes de mostrar el formulario de inicio de sesión

                Login login = new Login();
                login.ShowDialog();  // Muestra el formulario de inicio de sesión como un diálogo modal
                this.Close();  // Cierra la ventana actual después de que se cierre el formulario de inicio de sesión              
            }
            else
            {
                MessageBox.Show("Sesión no cerrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercadeTEC acercadeTEC = new AcercadeTEC();
            acercadeTEC.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AsignarSoftTEC asignarSoftTEC = new AsignarSoftTEC();
            asignarSoftTEC.Show();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsigDispTEC asigDispTEC = new AsigDispTEC();
            asigDispTEC.Show();
        }

        private void labelFechaYhora_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuTecnico_Load(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime fechaHoraActual = DateTime.Now;

            // Mostrar la fecha y hora en el formato deseado en un Label
            labelFechaYhora.Text = fechaHoraActual.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
