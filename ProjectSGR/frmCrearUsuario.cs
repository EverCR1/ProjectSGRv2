using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace ProjectSGR
{
    public partial class frmCrearUsuario : Form
    {

        public string Operacion = "Crear";

        public int idd;

        Usuarios usuario = new Usuarios();


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
            if (Operacion == "Crear")
            {
                ListarLicencias();
            }
            else
            {

            }

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

                txtLicencia.Visible = true;

            }

            else
            {
                label8.Visible = false;

                txtLicencia.Visible = false;

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {


            if (Operacion == "Crear")
            {
                if (txtLicencia.Visible != false)
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
                        usuario.tipoLicencia = txtLicencia.Text;

                        if (txtConfirmarPass.Text == txtPass.Text)
                        {
                            /*  obtener el índice seleccionado
                            int indiceSeleccionado = cbLicencia.SelectedIndex;

                            // Asegurar que el usuario no haya seleccionado nada
                            if (indiceSeleccionado >= 0)
                            {
                                string valorSeleccionado = cbLicencia.Items[indiceSeleccionado].ToString();
                                usuario.tipoLicencia = valorSeleccionado;
                            }
                            */

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
                            MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Operacion == "Editar")
            {
                if (txtLicencia.Visible != false)
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
                        usuario.tipoLicencia = txtLicencia.Text;
                        if (txtConfirmarPass.Text == txtPass.Text)
                        {
                            /*  obtener el índice seleccionado
                            int indiceSeleccionado = cbLicencia.SelectedIndex;

                            // Asegurar que el usuario no haya seleccionado nada
                            if (indiceSeleccionado >= 0)
                            {
                                string valorSeleccionado = cbLicencia.Items[indiceSeleccionado].ToString();
                                usuario.tipoLicencia = valorSeleccionado;
                            }
                            */
                            usuario.EditarPiloto(idd);
                            MessageBox.Show("Se edito el usuario.");
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
                            usuario.EditarUsuario(idd);
                            MessageBox.Show("Se edito el usuario.");
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

        public void ListarCargos()
        {
            cbCargo.DataSource = usuario.ListarC();
            cbCargo.DisplayMember = "Cargo";
            cbCargo.ValueMember = "idCargo";
        }
        public void ListarLicencias()
        {
            //cbLicencia.DataSource = usuario.ListarLicencia();
            //cbLicencia.DisplayMember = "Licencia";
            //cbLicencia.ValueMember = "Licencia";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

            string contraseña = txtPass.Text;


            string patron = @"\w*";
            //@"^(?=.[a-z])(?=.[A-Z])(?=.*\W).{6,}$"

            // Validar la contraseña con una expresión regular
            if (Regex.IsMatch(contraseña, patron))
            {
                // La contraseña cumple con los requisitos
                label10.Visible = false;
            }
            else
            {
                // La contraseña no cumple con los requisitos
                label10.Visible = true;
            }
        }
    }
}
