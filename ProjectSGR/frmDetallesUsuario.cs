using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSGR
{
    public partial class frmDetallesUsuario : Form
    {
        Usuarios usuario = new Usuarios();
        public int idUsuario;
        public frmDetallesUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
           

        }


        private void frmDetallesUsuario_Load(object sender, EventArgs e)
        {
            Refresh();

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
