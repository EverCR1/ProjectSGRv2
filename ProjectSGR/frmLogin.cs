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

namespace ProjectSGR
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Evento para salir de la app desde el Login
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Evento para Ingresar a la app
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            QueriesTableAdapter adapter = new QueriesTableAdapter();

            int? idU = (int?)adapter.Flogin(txtUser.Text, txtPass.Text);
            if (idU > 0) //Valida las credenciales
            {
                this.Close();
                adapter.pBitacoraAcceso(Convert.ToInt32(idU));
                Usuarios.idUsuario = Convert.ToInt32(idU); //Registra el id del usuario que ingresó
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta"); //Mensaje de error
                txtUser.Focus();
            }  
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Down)
            {
                txtPass.Focus();
            }
            
        }

        //Eventos para navegar entre controladores
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Down)
            {
                btnAceptar.Focus();
            }

            else if (e.KeyData == Keys.Up)
            {
                txtUser.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //Eventos para mostrar/ocultar texto en los TextBox
        //Evento cuando txtUser tiene el foco
        private void txtUser_Enter(object sender, EventArgs e)
        { 
            if (txtUser.Text == "Usuario")
            {
                    txtUser.Text = "";
            }
        }

        //Evento cuando txtUser pierde el foco
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        //Marca el focus del botón
        private void btnAceptar_Enter(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderSize = 1;
            btnAceptar.FlatAppearance.BorderColor = Color.White; 
        }

        private void btnAceptar_Leave(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderSize = 0;
        }
    }
}
