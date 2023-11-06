using ProjectSGR;
using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vehiculo
{
    public partial class RegistrarVehiculo : Form
    {
        vehiculo vehi = new vehiculo();
        ErrorProvider errorP = new ErrorProvider();

        public string Operacion = "Crear";
        public int Id;
        public RegistrarVehiculo()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Crear")
            {
                if (verificarTextBoxllenos())
                {
                    
                    vehi.Nombre = txtNombre.Text;
                    vehi.Capacidad = (byte)(int)txtCapacidad.Value;
                    vehi.Marca = txtMarca.Text;
                    vehi.Color = txtColor.Text;
                    vehi.Estado = txtEstado.Text;
                    vehi.idPiloto = (int)txtIdPiloto.SelectedValue;
                    vehi.idUsuario = Usuarios.idUsuario;
                    // vehi.idPiloto = (int)txtIdPiloto.SelectedValue;
                    //vehi.idUsuario = (int)txtIdUsuario.SelectedValue;
                    vehi.Registrar_vehiculo();
                    MessageBox.Show("Se registro correctamente el vehiculo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Operacion == "Editar")
            {
                if (verificarTextBoxllenos())
                {
                    vehi.Nombre = txtNombre.Text;
                    vehi.Capacidad = (byte)(int)txtCapacidad.Value;
                    vehi.Marca = txtMarca.Text;
                    vehi.Color = txtColor.Text;
                    vehi.Estado = txtEstado.Text;
                    vehi.idPiloto = (int)txtIdPiloto.SelectedValue;
                    vehi.idUsuario = Usuarios.idUsuario;
                    // vehi.idPiloto = (int)txtIdPiloto.SelectedValue;
                    //vehi.idUsuario = (int)txtIdUsuario.SelectedValue;

                    vehi.editar_vehiculo(Id);
                    Operacion = "Crear";
                    MessageBox.Show("Se editó correctamente el vehiculo");
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //this.Close();
            
        }
        public bool verificarTextBoxllenos()
        {
            if(!string.IsNullOrWhiteSpace(txtNombre.Text) &&
               !string.IsNullOrWhiteSpace(txtCapacidad.Text)&&
               !string.IsNullOrWhiteSpace(txtMarca.Text) &&
               !string.IsNullOrWhiteSpace(txtColor.Text) &&
               !string.IsNullOrWhiteSpace(txtEstado.Text) &&
               !string.IsNullOrWhiteSpace(txtIdPiloto.Text)
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
        public void ListarPiloto(int id)
        {
            txtIdPiloto.DataSource = vehi.ListarP(id);
            txtIdPiloto.DisplayMember = "Nombres";
            txtIdPiloto.ValueMember = "IdPiloto";
        }

        private void RegistrarVehiculo_Load(object sender, EventArgs e)
        {
            if(Operacion == "Crear")
            {
                ListarPiloto(2);
            }
            else
            {

            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarVehiculo(txtNombre.Text);
        }

        public void ValidarLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 255))
            {

                //ErrorProvider.SetError(e,"Solo texto");
                MessageBox.Show("No se admiten numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }
        public void ValidarNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se admiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeros(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        public void validarVehiculo(string nombre)
        {
            bool validar = vehi.VerificarVehiculo(nombre);

            if (validar)
            {
                errorP.SetError(txtNombre, "Ya existe ese nombre de Vehículo \n"
                    + "Por favor, modifíquelo para continuar");
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
                errorP.Clear();

            }
        }
    }
}
