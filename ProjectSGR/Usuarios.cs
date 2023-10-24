using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSGR
{
    public class Usuarios
    {
        public static int idUsuario {  get; set; }
        public long DPI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int cargo { get; set; }
        public string tipoLicencia { get; set; }

        QueriesTableAdapter adapter = new QueriesTableAdapter();

        public void crearUsuario()
        {
            adapter.pCrearUsuario(DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo);
        }
       

        public void crearPiloto()
        {
            
            adapter.pUsuarioLicencia(DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo, tipoLicencia);
        }


    }
}
