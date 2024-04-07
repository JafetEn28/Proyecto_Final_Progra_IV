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
    public partial class ControlADM : Form
    {
        public ControlADM()
        {
            InitializeComponent();
            // Establecer la posición de inicio del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void ControlADM_Load(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime fechaHoraActual = DateTime.Now;

            // Mostrar la fecha y hora en el formato deseado en un Label
            labelFechaYhora.Text = fechaHoraActual.ToString("dd/MM/yyyy HH:mm");
        }

        private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarDispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDispositivosADM agregarDispositivoADM = new AgregarDispositivosADM();

            agregarDispositivoADM.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void agregarSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarSoftADM agregarSoftADM = new AgregarSoftADM();
            agregarSoftADM.ShowDialog();
        }

        private void opcion4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesADM reportesADM = new ReportesADM();
            reportesADM.ShowDialog();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MANUsuarios manuUsuarios = new MANUsuarios();   
            manuUsuarios.ShowDialog();
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

        private void labelFechaYhora_Click(object sender, EventArgs e)
        {

        }
    }
}