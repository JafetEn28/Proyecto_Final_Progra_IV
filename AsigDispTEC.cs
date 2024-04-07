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
    public partial class AsigDispTEC : Form
    {
        public AsigDispTEC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            MenuTecnico formPrincipal = Application.OpenForms.OfType<MenuTecnico>().FirstOrDefault(); // Obtén el formulario principal existente
            if (formPrincipal != null) // Verifica si el formulario principal existe
            {
                formPrincipal.Show(); // Muestra el formulario principal
            }
            else
            {
                // Si el formulario principal no existe, puedes crear uno nuevo y mostrarlo
                MenuTecnico nuevoFormPrincipalTEC = new MenuTecnico();
                nuevoFormPrincipalTEC.FormClosed += (s, args) => this.Close(); // Cierra este formulario cuando se cierre el nuevo formulario principal
                nuevoFormPrincipalTEC.Show();
            }
        }
    }
}
