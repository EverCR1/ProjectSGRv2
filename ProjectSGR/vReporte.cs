using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjectSGR
{
    public partial class vReporte : Form
    {

        Reporte reporte = new Reporte();
        public int idReporte;
        public vReporte()
        {
            InitializeComponent();
        }

        private void vReporte_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            datosRepDetalles.DataSource = reporte.ListarIngresos(idReporte);
            //datosRep.Columns["idReporte"].Visible = false;
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            // Crea un nuevo documento PDF
            Document doc = new Document();

            // Abre el cuadro de diálogo para que el usuario elija la ubicación y el nombre del archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos PDF|*.pdf";
            saveFileDialog1.Title = "Guardar archivo PDF";
            saveFileDialog1.ShowDialog();

            // Si el usuario no cancela el diálogo y elige una ubicación
            if (saveFileDialog1.FileName != "")
            {
                string filePath = saveFileDialog1.FileName;

                try
                {
                    // Crea el archivo PDF en la ubicación seleccionada
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Agrega contenido al PDF
                    doc.Add(new Paragraph("Detalles del Reporte:\n\n"));

                    doc.Add(new Paragraph("Cantidad de Viajes: " + txtViajes.Text));
                    doc.Add(new Paragraph("Fecha: " + txtFecha.Text));
                    doc.Add(new Paragraph("Vehículo: " + txtVehiculo.Text));
                    doc.Add(new Paragraph("Turno: " + txtTurno.Text));
                    doc.Add(new Paragraph("Pago Piloto: " + txtPiloto.Text));
                    doc.Add(new Paragraph("Pago Ayudante: " + txtAyudante.Text));
                    doc.Add(new Paragraph("Pago Combustible: " + txtCombustible.Text));
                    doc.Add(new Paragraph("Pago Viáticos: " + txtViaticos.Text));
                    doc.Add(new Paragraph("Pago Extras: " + txtExtras.Text));
                    doc.Add(new Paragraph("Total Ingresos: " + txtTotalIngresos.Text));
                    doc.Add(new Paragraph("Total Egresos: " + txtTotalEgresos.Text));
                    doc.Add(new Paragraph("Capital: " + txtCapital.Text));
                    doc.Add(new Paragraph("Comentario: " + txtComentario.Text));


                    // Crear la tabla
                    PdfPTable table = new PdfPTable(2); // Cambia el número de columnas según tus necesidades

                    // Definir ancho de columnas (puedes ajustar los porcentajes)
                    float[] columnWidths = { 50f, 50f };
                    table.SetWidths(columnWidths);

                    // Agregar encabezados
                    table.AddCell(new PdfPCell(new Phrase("Vuelta")));
                    table.AddCell(new PdfPCell(new Phrase("Ingresos")));

                    // Recorrer los datos del DataGridView y agregarlos a la tabla
                    foreach (DataGridViewRow row in datosRepDetalles.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(new PdfPCell(new Phrase(row.Cells["Viaje"].Value.ToString())));
                            table.AddCell(new PdfPCell(new Phrase(row.Cells["Ingreso"].Value.ToString())));
                        }
                    }

                    // Agregar la tabla al documento
                    doc.Add(table);

                    // Cierra el documento
                    doc.Close();

                    MessageBox.Show("PDF guardado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF: " + ex.Message);
                }
            }

        }
    }
}
