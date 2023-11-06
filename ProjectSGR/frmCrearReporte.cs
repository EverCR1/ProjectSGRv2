﻿using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectSGR
{
    public partial class frmCrearReporte : Form

    {
        public List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
        public List<decimal> listaInge = new List<decimal>();
        Reporte reporte = new Reporte();
        Usuarios usuario = new Usuarios();
        ErrorProvider errorP = new ErrorProvider();

        //Variables de control
        public bool controlI = false;
        public string Operacion = "Crear";
        public int idd;
        public bool fechaC = false;
        public DateTime fechaOri;
        
        public frmCrearReporte()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {     
                e.SuppressKeyPress = true; // Evita que se escriba el salto de línea en el TextBox actual
                SelectNextControl((Control)sender, true, true, true, true);
            }

        }


        //Función para crear TextBox dinámicamente
        public void crearTextBox(int cantidad)
        {

            // Limpia cualquier TextBox previamente creado
                panelViajes.Controls.Clear();

                // Crea dinámicamente TextBox para las ganancias por cada viaje
                for (int i = 1; i <= cantidad; i++)
                {

                var label = new Label

                {
                        Text = "Ingresos Viaje " + i + ":",
                        Location = new Point(10, 30 * i),
                        Width = 130
                    };

                var textBox = new System.Windows.Forms.TextBox

                {
                        Location = new Point(160, 30 * i),
                        Width = 100,
                        
                    };

                    textBox.BackColor = Color.LightGray;
                    textBox.KeyDown += TextBox_KeyDown;
                    textBox.KeyPress += TextBox_KeyPress;

                    
                    textBox.TextChanged += TextBox_TextChanged;

                    // Agrega los nuevos controles al panel
                    textBoxes.Add(textBox);
                    panelViajes.Controls.Add(label);
                    panelViajes.Controls.Add(textBox);
                    

                }

        }
    
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
            }
        }

        //Evento para cada vez que se modifique el texto
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalIngresos();
        }

        private void btnAddViajes_Click(object sender, EventArgs e)
        {
            
            int.TryParse(txtCantViajes.Text, out int comprobarV);

            if (comprobarV > 0 && comprobarV < 9){
                panelViajes.Visible = true;
                crearTextBox(comprobarV);
                btnLimpiar.Visible = true;
                controlI = true;
                
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida de viajes");
            }

        }


        private void CalcularTotalIngresos()
        {
            decimal totalIngresos = 0;

            foreach (var textBox in textBoxes)
            {
                if (decimal.TryParse(textBox.Text, out decimal ingreso))
                {
                    totalIngresos += ingreso;
                    
                }
            }

            txtTotalIngresos.Text = totalIngresos.ToString("0.00");
        }

        //Evento que se activa al cargar el formulario
        private void frmCrearReporte_Load(object sender, EventArgs e)
        {
            
            
            if(Operacion == "Crear")
            {
                ListarVehi();
            }
            else
            {

            }
            
        }

        //Evento para evitar que no se escriban tipos de datos erróneos
        private void txtPiloto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtPiloto, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtAyudante.Focus();
                e.Handled = true;
                
            }
        }

        private void txtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtCombustible, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtViaticos.Focus();
                e.Handled = true;
                
            }
        }

        private void txtAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtAyudante, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtCombustible.Focus();
                e.Handled = true;
                
            }
        }

        private void txtViaticos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtViaticos, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }


            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtExtras.Focus();
                e.Handled = true;
                
            }
        }

        private void txtExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Verifica si el punto decimal ya se ha ingresado
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            // Verifica si se ha ingresado más de dos decimales
            if ((sender as System.Windows.Forms.TextBox).Text.Contains('.') 
                && (sender as System.Windows.Forms.TextBox).Text.Split('.')[1].Length >= 2)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtComentario.Focus();
                e.Handled = true;
            }

        }

        //Método activado al presionar el botón Gaurdar
        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (Operacion == "Crear")
            {

                bool verificado = true;
                fechaC = validarFecha();
                listaInge.Clear(); //Limpia la lista

                if (VerificarTextBoxLlenos())
                {
                    if (controlI)
                    {
                        //Recorrido de los TextBox dinámicos
                        foreach (Control control in panelViajes.Controls)
                        {
                            if (control is System.Windows.Forms.TextBox textBox)
                            {
                                if (string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    verificado = false;

                                    MessageBox.Show("Por favor, ingrese un valor correcto en los Ingresos"
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break; // Si uno de los TextBox está vacío, se detiene la verificación
                                }
                                else if (decimal.TryParse(textBox.Text, out decimal valor))
                                {
                                    listaInge.Add(valor);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, debe registrar los Ingresos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        verificado = false;
                    }
                }

                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado = false;
                }

                if (verificado && fechaC)
                {
                    errorP.Clear();
                    //Obtenemos los valores del formulario
                    reporte.CantViajes = int.Parse(txtCantViajes.Text);
                    reporte.IdVehiculo = (int)cBoxVehiculo.SelectedValue;
                    reporte.Fecha = datePick.Value;
                    reporte.Turno = (int)nTurno.Value;
                    reporte.PagoPiloto = int.Parse(txtPiloto.Text);
                    reporte.PagoAyudante = int.Parse(txtAyudante.Text);
                    reporte.PagoCombustible = int.Parse(txtCombustible.Text);
                    reporte.PagoViaticos = int.Parse(txtViaticos.Text);
                    reporte.TotalIngresos = decimal.Parse(txtTotalIngresos.Text);
                    reporte.TotalEgresos = decimal.Parse(txtTotalEgresos.Text);
                    reporte.Capital = decimal.Parse(txtCapital.Text);
                    reporte.IdUsuario = Usuarios.idUsuario;
                    reporte.Listado = listaInge;
                    Adicion();

                    reporte.CrearReporte();
                    MessageBox.Show("Reporte creado exitosamente");
                    this.Close();

                }
                else
                {
                    errorP.SetError(datePick, "Ya existe un reporte para el vehículo con esa fecha \n"
                    + "Por favor, cambie la fecha");
                }
            }

            else if (Operacion == "Editar")
            {
                bool verificado = true;
                fechaC = validarFecha();
                listaInge.Clear();

                if (VerificarTextBoxLlenos())
                {
                    if (controlI)
                    {
                        foreach (Control control in panelViajes.Controls)
                        {
                            if (control is System.Windows.Forms.TextBox textBox)
                            {
                                if (string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    verificado = false;

                                    MessageBox.Show("Por favor, ingrese un valor correcto en los Ingresos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                                else if (decimal.TryParse(textBox.Text, out decimal valor))
                                {
                                    listaInge.Add(valor);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, debe registrar los Ingresos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        verificado = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado = false;
                }

                if (verificado)
                {
                    //Obtiene la fecha original
                    DateTime fechaOriginal = fechaOri;

                    //Compara la fecha original con la nueva fecha
                    if (fechaOriginal != datePick.Value)
                    {
                        //Verifica si ya existe un reporte con la nueva fecha y el mismo vehículo
                        if (!validarFecha())
                        {
                            errorP.SetError(datePick, "Ya existe un reporte para el vehículo con esa fecha \n"
                            + "Por favor, cambie la fecha");
                        }
                        else
                        {
                            //La nueva fecha no existe en otro reporte, procede con la edición
                            errorP.Clear();
                            reporte.CantViajes = int.Parse(txtCantViajes.Text);
                            reporte.IdVehiculo = (int)cBoxVehiculo.SelectedValue;
                            reporte.Fecha = datePick.Value;
                            reporte.Turno = (int)nTurno.Value;
                            reporte.PagoPiloto = int.Parse(txtPiloto.Text);
                            reporte.PagoAyudante = int.Parse(txtAyudante.Text);
                            reporte.PagoCombustible = int.Parse(txtCombustible.Text);
                            reporte.PagoViaticos = int.Parse(txtViaticos.Text);
                            reporte.TotalIngresos = decimal.Parse(txtTotalIngresos.Text);
                            reporte.TotalEgresos = decimal.Parse(txtTotalEgresos.Text);
                            reporte.Capital = decimal.Parse(txtCapital.Text);
                            reporte.IdUsuario = Usuarios.idUsuario;
                            reporte.Listado = listaInge;
                            Adicion();

                            // Realiza la edición del reporte
                            reporte.EditarReporte(idd);

                            Operacion = "Crear";
                            MessageBox.Show("Reporte actualizado exitosamente");
                            this.Close();
                        }
                    }
                    else
                    {
                        //La fecha no ha cambiado, puedes proceder con la edición sin verificar nuevamente
                        errorP.Clear();
                        reporte.CantViajes = int.Parse(txtCantViajes.Text);
                        reporte.IdVehiculo = (int)cBoxVehiculo.SelectedValue;
                        reporte.Fecha = fechaOriginal; //Restaura la fecha original
                        reporte.Turno = (int)nTurno.Value;
                        reporte.PagoPiloto = int.Parse(txtPiloto.Text);
                        reporte.PagoAyudante = int.Parse(txtAyudante.Text);
                        reporte.PagoCombustible = int.Parse(txtCombustible.Text);
                        reporte.PagoViaticos = int.Parse(txtViaticos.Text);
                        reporte.TotalIngresos = decimal.Parse(txtTotalIngresos.Text);
                        reporte.TotalEgresos = decimal.Parse(txtTotalIngresos.Text);
                        reporte.Capital = decimal.Parse(txtCapital.Text);
                        reporte.IdUsuario = Usuarios.idUsuario;
                        reporte.Listado = listaInge;
                        Adicion();

                        // Realiza la edición del reporte
                        reporte.EditarReporte(idd);

                        Operacion = "Crear";
                        MessageBox.Show("Reporte actualizado exitosamente");
                        this.Close();
                    }
                }
            }
        }

        //Método para calcular en tiempo real los egresos
        private void CalcularTotalEgresos()
        {
            decimal totalPagos = 0;

            if (int.TryParse(txtPiloto.Text, out int pagoPiloto))
            {
                totalPagos += pagoPiloto;
            }
            if (int.TryParse(txtAyudante.Text, out int pagoAyudante))
            {
                totalPagos += pagoAyudante;
            }
            if (int.TryParse(txtCombustible.Text, out int pagoCombustible))
            {
                totalPagos += pagoCombustible;
            }
            if (int.TryParse(txtViaticos.Text, out int pagoViaticos))
            {
                totalPagos += pagoViaticos;
            }
            if (decimal.TryParse(txtExtras.Text, out decimal pagoExtras))
            {
                totalPagos += pagoExtras;
            }

            txtTotalEgresos.Text = totalPagos.ToString("0.00");
            
        }

        private void txtPiloto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalEgresos(); 
        }

        private void txtAyudante_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalEgresos(); 
        }

        private void txtCombustible_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalEgresos();
        }

        private void txtViaticos_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalEgresos();
        }

        private void txtExtras_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalEgresos();
        }

        //Método para el botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalIngresos_TextChanged(object sender, EventArgs e)
        {
            CalcularCapital();
        }

        private void txtTotalEgresos_TextChanged(object sender, EventArgs e)
        {
            CalcularCapital();
        }

        //Método para Calcular el Capital del Reporte
        private void CalcularCapital()
        {
            if (decimal.TryParse(txtTotalIngresos.Text, out decimal totalIngresos) &&
                decimal.TryParse(txtTotalEgresos.Text, out decimal totalEgresos))
            {
                decimal capital = totalIngresos - totalEgresos;
                txtCapital.Text = capital.ToString("0.00");
            }
            else
            {
                txtCapital.Text = ""; // Deja el TextBox de "Capital" en blanco si no se pueden analizar los valores
            }
        }

        //Función para verificar que todos los campos requeridos estén llenos llenos
        private bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtPiloto.Text) &&
                !string.IsNullOrWhiteSpace(txtAyudante.Text) &&
                !string.IsNullOrWhiteSpace(txtCombustible.Text) &&
                !string.IsNullOrWhiteSpace(txtViaticos.Text) &&
                !string.IsNullOrWhiteSpace(txtCantViajes.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //Método para asignarle un valor por defecto a Extras y Comentario, o para obtener su valor del TextBox
        private void Adicion()
        {
            decimal valorExtras = 0;
            string comentario = "SC";

            if (!string.IsNullOrWhiteSpace(txtExtras.Text) && decimal.TryParse(txtExtras.Text, out decimal extras))
            {
                reporte.PagoExtras = extras; // Asigna el valor ingresado por el usuario
            }
            else
            {
                reporte.PagoExtras = valorExtras;
            }

            // Verifica si el campo Comentario no está en blanco
            if (!string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                reporte.Comentario = txtComentario.Text; // Asigna el valor ingresado por el usuario
            }
            else
            {
                reporte.Comentario = comentario;
            }
        }

        private void txtCantViajes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtCantViajes, "Solo se permiten números 1-8");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                btnAddViajes.Focus();
                e.Handled = true;
                
            }
        }

        //Botón para limpiar el apartado de ingresos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            panelViajes.Controls.Clear();
            btnLimpiar.Visible = false;
            controlI = false;
        }
        
        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCrear.Focus();
                e.Handled = true;
            }
        }

        //Método para listar los Vehículos
        public void ListarVehi()
        {
            cBoxVehiculo.DataSource = reporte.ListarVe();
            cBoxVehiculo.DisplayMember = "Nombre";
            cBoxVehiculo.ValueMember = "IdVehiculo";
        }

        public bool validarFecha()
        {
            bool validar = reporte.VerificarFecha((int)cBoxVehiculo.SelectedValue, datePick.Value);

            if (validar)
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
        }

        private void btnCrear_Enter(object sender, EventArgs e)
        {
            btnCrear.FlatAppearance.BorderSize = 1;
            btnCrear.FlatAppearance.BorderColor = Color.White;
        }

        private void btnCrear_Leave(object sender, EventArgs e)
        {
            btnCrear.FlatAppearance.BorderSize = 0;
        }

        private void btnAddViajes_Enter(object sender, EventArgs e)
        {
            btnAddViajes.FlatAppearance.BorderSize = 1;
            btnAddViajes.FlatAppearance.BorderColor = Color.White;
        }

        private void btnAddViajes_Leave(object sender, EventArgs e)
        {
            btnAddViajes.FlatAppearance.BorderSize = 0;
        }
    }
}

