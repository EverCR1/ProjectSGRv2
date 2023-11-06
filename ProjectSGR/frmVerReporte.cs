using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectSGR
{
    public partial class frmVerReporte : Form
    {

        Reporte reporte = new Reporte();
        pListarIngresosTableAdapter listaIngresos = new pListarIngresosTableAdapter();
        QueriesTableAdapter adapter = new QueriesTableAdapter();
        
        public frmVerReporte()
        {
            InitializeComponent();
        }

        //Evento de carga
        private void frmVerReporte_Load(object sender, EventArgs e)
        {
            MostrarDatos();      
        }

        //Método para mostrar los datos requeridos
        public void MostrarDatos()
        {
            datosRep.DataSource = reporte.ListarReporte();
            datosRep.Columns["idReporte"].Visible = false;
            datosRep.Columns["Pago Piloto"].Visible = false;
            datosRep.Columns["Pago Ayudante"].Visible = false;
            datosRep.Columns["Combustible"].Visible = false;
            datosRep.Columns["idVehiculo"].Visible = false;
            datosRep.Columns["Viáticos"].Visible = false;
            datosRep.Columns["Extras"].Visible = false;
            datosRep.Columns["Comentario"].Visible = false;
            datosRep.Columns["idUsuario"].Visible = false;
            datosRep.Columns["Viajes"].Visible = false;
            //datosRep.Columns["Vehículo"].Visible = false;

            TotalReportes();
        }


    //Método para buscar reportes al presionar un botón
    private void btnBuscarReporte_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = datePickFecha.Value;
            DateTime FechaFinal = datePickFecha2.Value;
            BuscarDatos(FechaInicio, FechaFinal);

            TotalReportes();

            btnRegresar.Visible = true;

        }

        //Método para contrar y mostrar el Total de Reportes
        public void TotalReportes()
        {
            int total = 0;
            total = datosRep.RowCount;
            labelCantidad.Text = total.ToString();
        }

        //Método para buscar datos mediante una consulta
        private void BuscarDatos(DateTime fechaInicio, DateTime fechaFinal)
        {
            datosRep.DataSource = reporte.BuscarReporte(fechaInicio, fechaFinal);


            if (datosRep.Rows.Count == 0)
            {
                // No se encontraron reportes con la fecha especificada, muestra un mensaje
                MessageBox.Show("No se encontraron reportes con la fecha especificada.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                
            }
            else
            {
                datosRep.Visible = true;
            }
        }

        //Método para llamar al formulario de Creación de Reportes
        private void btnCrearRep_Click(object sender, EventArgs e)
        {
            frmCrearReporte frmCrearReporte = new frmCrearReporte();
            frmCrearReporte.Operacion = "Crear";
            frmCrearReporte.ShowDialog();
            MostrarDatos(); //Resfresca la tabla
            //Console.WriteLine(Usuarios.idUsuario);
        }

        //Método para mostrar los detalles de un reporte
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (datosRep.SelectedRows.Count > 0)
            {
                vReporte frm = new vReporte();
                
                int ide = Convert.ToInt32(datosRep.CurrentRow.Cells["idReporte"].Value);
                obtenerIngresos(ide);
                
                frm.idReporte = ide;
                
                frm.txtViajes.Text = datosRep.CurrentRow.Cells["Viajes"].Value.ToString();
                frm.txtFecha.Text = ((DateTime)datosRep.CurrentRow.Cells["Fecha"].Value).ToString("dd/MM/yyyy");
                frm.txtVehiculo.Text = datosRep.CurrentRow.Cells["Vehículo"].Value.ToString();
                frm.txtTurno.Text = datosRep.CurrentRow.Cells["Turno"].Value.ToString();
                frm.txtPiloto.Text = datosRep.CurrentRow.Cells["Pago Piloto"].Value.ToString();
                frm.txtAyudante.Text = datosRep.CurrentRow.Cells["Pago Ayudante"].Value.ToString();
                frm.txtCombustible.Text = datosRep.CurrentRow.Cells["Combustible"].Value.ToString();
                frm.txtViaticos.Text = datosRep.CurrentRow.Cells["Viáticos"].Value.ToString();
                frm.txtExtras.Text = datosRep.CurrentRow.Cells["Extras"].Value.ToString();
                frm.txtTotalIngresos.Text = datosRep.CurrentRow.Cells["Total Ingresos"].Value.ToString();
                frm.txtTotalEgresos.Text = datosRep.CurrentRow.Cells["Total Egresos"].Value.ToString();
                frm.txtCapital.Text = datosRep.CurrentRow.Cells["Capital"].Value.ToString();
                frm.txtComentario.Text = datosRep.CurrentRow.Cells["Comentario"].Value.ToString();

                frm.ShowDialog();
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un reporte");
            }
        }

        //Método para obtener los datos de los Ingresos en una tabla
        public DataTable ListarIngresos(int ide)
        {
            DataTable dataTable = new DataTable();
            dataTable = listaIngresos.GetData(ide);
            return dataTable;
        }

        //Método para mostrar los ingresos en una tabla
        private void obtenerIngresos(int ide)
        {
            datosIng.DataSource = ListarIngresos(ide);
        }

        //Método para editar la información de un reporte
        public void btnEditarReporte_Click(object sender, EventArgs e)
        {
            if(datosRep.SelectedRows.Count > 0)
            {
                
                frmCrearReporte frm = new frmCrearReporte();
                
                frm.Operacion = "Editar";
                int ide = Convert.ToInt32(datosRep.CurrentRow.Cells[0].Value);
                obtenerIngresos(ide);
                frm.idd = ide;
                frm.ListarVehi();
                
                frm.txtCantViajes.Text = datosRep.CurrentRow.Cells["Viajes"].Value.ToString();
                frm.cBoxVehiculo.SelectedValue = Convert.ToInt32(datosRep.CurrentRow.Cells["idVehiculo"].Value);
                frm.datePick.Text = datosRep.CurrentRow.Cells["Fecha"].Value.ToString();
                frm.fechaOri = ((DateTime)datosRep.CurrentRow.Cells["Fecha"].Value);
                frm.nTurno.Text = datosRep.CurrentRow.Cells["Turno"].Value.ToString();
                frm.txtPiloto.Text = datosRep.CurrentRow.Cells["Pago Piloto"].Value.ToString();
                frm.txtAyudante.Text = datosRep.CurrentRow.Cells["Pago Ayudante"].Value.ToString();
                frm.txtCombustible.Text = datosRep.CurrentRow.Cells["Combustible"].Value.ToString();
                frm.txtViaticos.Text = datosRep.CurrentRow.Cells["Viáticos"].Value.ToString();
                frm.txtExtras.Text = datosRep.CurrentRow.Cells["Extras"].Value.ToString();
                frm.txtComentario.Text = datosRep.CurrentRow.Cells["Comentario"].Value.ToString();

                int ca = datosIng.RowCount - 1;
                frm.crearTextBox(ca);
                frm.btnLimpiar.Visible = true;
                frm.panelViajes.Visible = true;
                frm.controlI = true;

                for (int i=0; i < ca; i++)
                {
                    
                    if (i < datosIng.Rows.Count)
                    {
                        frm.textBoxes[i].Text = datosIng.Rows[i].Cells["Ingreso"].Value.ToString();
                    }
                    else
                    {
                        // Si no hay suficientes filas en el DataTable, se puede asignar un valor predeterminado o dejar el TextBox en blanco
                        frm.textBoxes[i].Text = "";
                    }
                }

                frm.ShowDialog();
                MostrarDatos(); //Refrescar

            }
            else
            {
                MessageBox.Show("Debe seleccionar un reporte");
            }
        }

        //Método para eliminar un reporte
        private void btnEliminarReporte_Click(object sender, EventArgs e)
        {
            if (datosRep.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea" +
                    " eliminar este reporte?", "Confirmación de eliminación", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    int ide = Convert.ToInt32(datosRep.CurrentRow.Cells[0].Value);
                    reporte.EliminarReporte(ide);
                    MessageBox.Show("Reporte eliminado exitosamente.", "Eliminado", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();

                }
                else
                {
                    
                }
      
            }
            else
            {
                //Verifica que se seleccione un reporte
                MessageBox.Show("Debe seleccionar un reporte");
            }
        }

        //Método para regresar a la lista principal de reportes
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            btnRegresar.Visible = false;
        }

        //Evento para aplicar condicionales a las celdas
        private void datosRep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.datosRep.Columns[e.ColumnIndex].Name == "Capital")
            {
                if (Convert.ToInt32(e.Value) >= 300)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;
                }

                if (Convert.ToInt32(e.Value) <= 100)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }

        
    }
}
