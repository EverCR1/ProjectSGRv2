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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            QueriesTableAdapter adapter = new QueriesTableAdapter();

            int? idU = (int?)adapter.Flogin(txtUser.Text, txtPass.Text);
            if (idU > 0)
            {
                this.Close();
                adapter.pBitacoraAcceso(Convert.ToInt32(idU));
                Usuarios.idUsuario = Convert.ToInt32(idU);
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
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

        private void txtUser_Enter(object sender, EventArgs e)
        { 
            if (txtUser.Text == "Usuario")
            {
                    txtUser.Text = "";
            }
        }

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
