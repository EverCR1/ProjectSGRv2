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
        public bool val = false;
        public bool val2 = false;

        Usuarios usuario = new Usuarios();
        ErrorProvider errorP = new ErrorProvider();

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
  
                ListarCargos();
            }
            else
            {

            }

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
            if (AlgoritmoContraseña(txtPass.Text))
            {
                
                label10.Visible = false;
                val = true;
                ActivarButton();
            }
            else
            {
                
                label10.Visible = true;
                val = false;
                ActivarButton();
            }

        }

        private bool AlgoritmoContraseña(string password)
        {
            bool mayuscula = false, minuscula = false, numero = false, especial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    especial = true;
                }
            }
            if (mayuscula && minuscula && numero && especial && password.Length >= 6)
            {
                return true;
            }
            return false;

        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = usuario.soloNumeros(e);
            if (!valida)
            {
                errorP.SetError(txtDPI, "Solo números");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = usuario.soloLetras(e);
            if (!valida)
            {
                errorP.SetError(txtNombre, "Solo letras");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = usuario.soloLetras(e);
            if (!valida)
            {
                errorP.SetError(txtApellido, "Solo letras");
            }
            else
            {
                errorP.Clear();
            }
        }

        public bool validarUsername(string nombre)
        {
            bool validar = usuario.VerificarUsername(nombre);

            if (validar)
            {
                return false;
                
            }
            else
            {
                return true;

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            bool validar = validarUsername(txtUsername.Text);

            if (!validar)
            {
                errorP.SetError(txtUsername, "Ya existe ese nombre de usuario \n"
                            + "Por favor, modifíquelo para continuar");
                val2 = false;
                ActivarButton();
            }
            else
            {
                val2 = true;
                ActivarButton();
                errorP.Clear();
                
            }
        }

        private void ActivarButton()
        {
            if (val == true && val2 == true)
            {
                btnCrear.Enabled = true;
            }
            else
            {
                btnCrear.Enabled = false;
            }
        }
    }
}
