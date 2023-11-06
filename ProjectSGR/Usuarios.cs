using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSGR
{
    public class Usuarios
    {
        public static int idUsuario { get; set; }
        public long DPI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int cargo { get; set; }
        public string tipoLicencia { get; set; }

        QueriesTableAdapter adapter = new QueriesTableAdapter();
        ListarCargosTableAdapter listarC = new ListarCargosTableAdapter();


        vListarUsuariosTableAdapter pUsuarios = new vListarUsuariosTableAdapter();
        vListarPilotosTableAdapter pPilotos = new vListarPilotosTableAdapter();


       //pListarPilotosTableAdapter pPilotos = new pListarPilotosTableAdapter();
       // pListarUsuariosTableAdapter pUsuarios = new pListarUsuariosTableAdapter(); 



        public DataTable listarPilotos()
        {
            DataTable data = new DataTable();
            data = pPilotos.GetData();
            return data;
        }
 
        public DataTable listarUsuarios()
        {
            DataTable data = new DataTable();
            data = pUsuarios.GetData();
            return data;

        }


        public DataTable ListarC()
        {
            DataTable dataTable = new DataTable();
            dataTable = listarC.GetData();
            return dataTable;
        }
        

        public void cambiarPass( string contraseña, string Ncontraseña, string Ccontraseña)
        {

            adapter.CambiarContrasena(idUsuario, contraseña, Ncontraseña, Ccontraseña);
        }

        public void crearUsuario()
        {
            adapter.pCrearUsuario(DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo);
        }     

        public void crearPiloto()
        {
            
            adapter.pUsuarioLicencia(DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo, tipoLicencia);
        }

        public void EditarUsuario(int ide)
        {
            adapter.pEditarUsuario(ide, DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo);

        }


        public void EditarPiloto (int ide)
        {
            adapter.pEditarPiloto(ide, DPI, Nombres, Apellidos, NombreUsuario, Contraseña, Fecha_Nacimiento, cargo, tipoLicencia);
        }
        public void EliminarUsuario(int ide)
        {
            adapter.pEliminarUsuario(ide);
        }

        public void EliminarPiloto(int ide)
        {
            adapter.pEliminarPiloto(ide);
        }

        public bool soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public bool soloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        //Método para validar que no se repitan nombres de usuario
        public bool VerificarUsername(string nombre)
        {
            int validar = (int)adapter.VerificarUsername(nombre); //Obtiene el nombre del usuario

            if (validar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
