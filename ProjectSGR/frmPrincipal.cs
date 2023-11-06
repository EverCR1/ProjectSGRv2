using Microsoft.VisualBasic.ApplicationServices;
using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Vehiculo;

namespace ProjectSGR
{
    public partial class frmPrincipal : Form
    {

        QueriesTableAdapter adapter = new QueriesTableAdapter();
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        //Evento que se desencadena al activar el formulario 
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            AdminPermisos(); //Valida los permisos del usuario que ingresó
        }

        //Evento de carga del formulario
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            
            frmLogin.ShowDialog();
            //timerHora.Tick += new EventHandler(timerHora_Tick);
            timerHora.Start(); //Activa el timer
            
        }


        //Evento para abrir el formulario de Crear Reporte
        private void crearReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearReporte frmCrearReporte = new frmCrearReporte();
            frmCrearReporte.ShowDialog();
           

        }

        //Evento para volver al Login
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmLogin cerrarLogin = new frmLogin();
            cerrarLogin.ShowDialog();
            //Usuarios.idUsuario = 0;
            
        }

        //Evento para finalizar la aplicación
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ////Evento para abrir el formulario de Administrar Reportes
        private void editarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerReporte frmVerReporte = new frmVerReporte();
            frmVerReporte.ShowDialog();
        }

        //Evento para abrir el formulario de Administrar Usuarios
        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerUsuario frmVerUsuario = new frmVerUsuario();
            frmVerUsuario.ShowDialog();
        }

        //Evento para mostrar información de los desarrolladores
        private void eOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDesarrolladores();
        }

        //Mensaje de información de los programadores
        private void MostrarDesarrolladores()
        {
            string EOM = "Desarrollado por: Ever Corazón, Olsend Luna, Mónica Caal\n"+
                         "Contacto: eom2023@gmail.com \n"+
                         "Repositorio del proyecto: https://github.com/EverCR1/ProjectSGRv2.git ";

            MessageBox.Show(EOM, "Acerca de los Desarrolladores", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Método para mostrar la fecha y hora en el apartado principal
        private void timerHora_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            labelHora.Text = horaActual.ToString(); //"HH:mm:ss"
        }

        //Método para realizar una consulta y asignar permisos al usuario
        private void AdminPermisos()
        {
            int permiso = (int)adapter.FPermisos(Usuarios.idUsuario);

            if (permiso == 2 || permiso == 3)
            {
                //Oculta los módulos a los que no tiene permiso
                vehículosToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                respaldoToolStripMenuItem.Visible = false;
                editarReporteToolStripMenuItem.Visible = false;
                respaldoToolStripMenuItem.Visible = false;
                estadísticaToolStripMenuItem.Visible = false;
            }

            else
            {
                //Muestra los módulos a los cuales tiene permiso
                vehículosToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
                respaldoToolStripMenuItem.Visible = true;
                editarReporteToolStripMenuItem.Visible = true;
                respaldoToolStripMenuItem.Visible = true;
                estadísticaToolStripMenuItem.Visible = true;
            }
        }

        //Evento para generar una Copia de Seguridad de los datos de la app
        private void realizarCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de diálogo para que el usuario elija la ubicación y el nombre del archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de copia de seguridad de SQL Server|*.bak";
            saveFileDialog1.Title = "Guardar archivo de copia de seguridad de SQL Server";
            saveFileDialog1.ShowDialog();

            // Si el usuario no cancela el diálogo y elige una ubicación
            if (saveFileDialog1.FileName != "")
            {
                string filePath = saveFileDialog1.FileName;

                try
                {
                    adapter.pCopiaSeguridad(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la copia de seguridad: " + ex.Message);
                }
            }
        }

        //Evento para abrir el formulario de Cambiar Contraseña
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frmCambiar = new frmCambiarContraseña();
            frmCambiar.ShowDialog();
        }

        //Evento para abrir el formulario de Ver Perfil
        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detallesPilotoTableAdapter detalleP = new detallesPilotoTableAdapter();
            detallesUsuarioTableAdapter detalleU = new detallesUsuarioTableAdapter();
            int cargo = (int)adapter.FPermisos(Usuarios.idUsuario);
            int perfil = Usuarios.idUsuario;

            if (cargo == 2)
            {
                DataTable dataP = new DataTable();
                dataP = detalleP.GetData(perfil);

                frmDetallesUsuario frm = new frmDetallesUsuario();
                DataRow fila = dataP.Rows[0];
                frm.idUsuario = perfil;
                frm.txtDPI.Text = fila["DPI"].ToString();
                frm.txtNombre.Text = fila["nombres"].ToString();
                frm.txtApellido.Text = fila["apellidos"].ToString();
                frm.txtUsername.Text = fila["username"].ToString();
                frm.txtCargo.Text = fila["Cargo"].ToString();
                frm.txtLicencia.Text = fila["tipoLicencia"].ToString();
                frm.txtEdad.Text = fila["Edad"].ToString();
                frm.txtFecha.Text = ((DateTime)fila["fechaNac"]).ToString("dd/MM/yyyy");

                frm.label1.Visible = true;
                frm.txtLicencia.Visible = true;

                frm.ShowDialog();
            }

            else if(cargo == 1 || cargo == 3)
            {
                DataTable dataU = new DataTable();
                dataU = detalleU.GetData(perfil);

                frmDetallesUsuario frm = new frmDetallesUsuario();
                DataRow fila = dataU.Rows[0];
                frm.idUsuario = perfil;
                frm.txtDPI.Text = fila["DPI"].ToString();
                frm.txtNombre.Text = fila["nombres"].ToString();
                frm.txtApellido.Text = fila["apellidos"].ToString();
                frm.txtUsername.Text = fila["username"].ToString();
                frm.txtCargo.Text = fila["Cargo"].ToString();
                frm.txtEdad.Text = fila["Edad"].ToString();
                frm.txtFecha.Text = ((DateTime)fila["fechaNac"]).ToString("dd/MM/yyyy");

                frm.label1.Visible = false;
                frm.txtLicencia.Visible = false;

                frm.ShowDialog();
            }
        }

        //Evento para abrir el formulario de Estadísticas 1
        private void vehículoMásUsadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaV frmEstadistica = new frmEstadisticaV();
            frmEstadistica.ShowDialog();
        }

        //Evento para abrir el formulario de Estadísticas 2
        private void viajesPorDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaIn frmEstadisticaIn = new frmEstadisticaIn();
            frmEstadisticaIn.ShowDialog();
        }

        //Evento para abrir el formulario de Administrar Vehículos
        private void editarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerVehiculos frmVerVehiculos = new frmVerVehiculos();
            frmVerVehiculos.ShowDialog();
        }

        private void crearCopiaORecuperarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }
    }
}
