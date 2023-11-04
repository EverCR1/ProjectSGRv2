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


namespace Vehiculo
{
    public partial class frmVerVehiculos : Form
    {
        vehiculo vehiculo = new vehiculo();
           
        public frmVerVehiculos()
        {
            InitializeComponent();
        }
        private void ListarV()
        {
            dataGridView1.DataSource = vehiculo.ListarV();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
            ListarV();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo registrarVehiculo = new RegistrarVehiculo();
            registrarVehiculo.Operacion = "Crear";
            registrarVehiculo.ShowDialog();
            Refrescar();
        }
        public void Refrescar()
        {
            VistaVehiculoTableAdapter ta = new VistaVehiculoTableAdapter();
            dataGridView1.DataSource= ta.GetData();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo rv = new RegistrarVehiculo();
            rv.Operacion = "Editar";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ide = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                rv.Id = ide;
                rv.ListarPiloto();
                rv.txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                rv.txtCapacidad.Text = dataGridView1.CurrentRow.Cells["capacidad"].Value.ToString();
                rv.txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                rv.txtColor.Text = dataGridView1.CurrentRow.Cells["Color"].Value.ToString();
                rv.txtEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                rv.txtIdPiloto.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdPiloto"].Value);
                rv.ShowDialog();
                Refrescar();
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Deseea eliminar el Vehiculo?", "Eliminar Vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ide = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    vehiculo.elminar_vehiculo(ide);
                    MessageBox.Show("Vehiculo Eliminado");
                    Refrescar();

                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                    MessageBox.Show("Debe seleccionar un vehículo");
            }
                
            }
        }
    }
