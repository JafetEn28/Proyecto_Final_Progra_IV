using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PrograIV
{
    internal class Clase_Conexion
    {
        
            public static SqlConnection Abrir_Conexion()
            {
                SqlConnection conect = new SqlConnection("Server=JAFETPC;Database=ProyectoFinalPrograIV;Integrated Security=True;");
                conect.Open();
                return conect;
            }
        }
}