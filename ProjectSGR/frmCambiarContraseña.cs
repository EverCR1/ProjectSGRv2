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
    public partial class frmCambiarContraseña : Form
    {
        Usuarios usuario = new Usuarios();
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (txtPass.Text == txtConfirmPass.Text)
            {
                usuario.cambiarPass(txtPassActual.Text, txtPass.Text, txtConfirmPass.Text);
                MessageBox.Show("Se cambio la contraseña.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
            
        

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
        

        }
    }
}