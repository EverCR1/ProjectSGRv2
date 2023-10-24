using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectSGR
{

    public partial class frmCrearUsuario : Form
    {
        Usuarios usuario = new Usuarios();
        bool validar = false;
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            // Agrega elementos al ComboBox
            cbLicencia.Items.Add("A");
            cbLicencia.Items.Add("B");
            cbLicencia.Items.Add("C");


            // TODO: esta línea de código carga datos en la tabla 'bdSGRDataSet.tbCargo' Puede moverla o quitarla según sea necesario.
            this.tbCargoTableAdapter.Fill(this.bdSGRDataSet.tbCargo);
            // TODO: esta línea de código carga datos en la tabla 'bdSGRDataSet.tbUsuario' Puede moverla o quitarla según sea necesario.
            this.tbUsuarioTableAdapter.Fill(this.bdSGRDataSet.tbUsuario);

        }

        private void cbLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)

        {
            if ((int)cbCargo.SelectedValue == 2)
            {
                label8.Visible = true;
                cbLicencia.Visible = true;
                validar = true;

                //   cbLicencia.Items.Clear();


            }


            else
            {
                label8.Visible = false;
                cbLicencia.Visible = false;
                validar = false;
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cbLicencia.SelectedItem != null)
            {
                if (VerificarTextBoxLlenos())
                {

                    //Obtenemos los valores del formulario
                    usuario.DPI = long.Parse(txtDPI.Text);
                    usuario.Contraseña = txtPass.Text;
                    usuario.Nombres = txtNombre.Text;
                    usuario.Apellidos = txtApellido.Text;
                    usuario.NombreUsuario = txtUsername.Text;
                    usuario.cargo = (int)cbCargo.SelectedValue;
                    usuario.Fecha_Nacimiento = datePick.Value;

                    if (txtConfirmarPass.Text == txtPass.Text )
                    {
                        //  obtener el índice seleccionado
                        int indiceSeleccionado = cbLicencia.SelectedIndex;

                        // Asegurar que el usuario no haya seleccionado nada
                        if (indiceSeleccionado >= 0)
                        {
                            string valorSeleccionado = cbLicencia.Items[indiceSeleccionado].ToString();
                            usuario.tipoLicencia = valorSeleccionado;
                        }

                        usuario.crearPiloto();
                        MessageBox.Show("Se creo el usuario.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (VerificarTextBoxLlenos())
                {
                    //Obtenemos los valores del formulario
                    usuario.DPI = long.Parse(txtDPI.Text);
                    usuario.Contraseña = txtPass.Text;
                    usuario.Nombres = txtNombre.Text;
                    usuario.Apellidos = txtApellido.Text;
                    usuario.NombreUsuario = txtUsername.Text;
                    usuario.cargo = (int)cbCargo.SelectedValue;
                    usuario.Fecha_Nacimiento = datePick.Value;

                    if (txtConfirmarPass.Text == txtPass.Text)
                    {
                        usuario.crearUsuario();
                        MessageBox.Show("Se creo el usuario.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No coinciden las contraseñas","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtDPI.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                !string.IsNullOrWhiteSpace(txtPass.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
