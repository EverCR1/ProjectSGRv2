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

                    // Sección para los datos principales
                    Paragraph datosPrincipales = new Paragraph();
                    datosPrincipales.Alignment = Element.ALIGN_CENTER; // Alineación centrada
                    datosPrincipales.Add("TRANSPORTES FRANCISCO \n");
                    datosPrincipales.Add("Fecha: " + txtFecha.Text + "\n");
                    datosPrincipales.Add("Vehículo: " + txtVehiculo.Text + "\n");
                    datosPrincipales.Add("Viajes: " + txtViajes.Text + "\n");
                    datosPrincipales.Add("Turno: " + txtTurno.Text + "\n");
                    datosPrincipales.SpacingAfter = 10f; // Espacio después de la sección
                    doc.Add(datosPrincipales);


                    // Sección para Ingresos
                    Paragraph ingresos = new Paragraph("Ingresos");
                    ingresos.Alignment = Element.ALIGN_CENTER;
                    ingresos.SpacingAfter = 15f;
                    doc.Add(ingresos);

                    PdfPTable ingresosTable = new PdfPTable(2);
                    float[] ingresosColumnWidths = { 30f, 30f };
                    ingresosTable.SetWidths(ingresosColumnWidths);

                    ingresosTable.AddCell("Vuelta");
                    ingresosTable.AddCell("Ingresos");

                    // Recorre los datos del DataGridView y los agrega a la tabla
                    foreach (DataGridViewRow row in datosRepDetalles.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            ingresosTable.AddCell(row.Cells["Viaje"].Value.ToString());
                            ingresosTable.AddCell(row.Cells["Ingreso"].Value.ToString());
                        }
                    }

                    ingresosTable.AddCell("Total Ingresos");
                    ingresosTable.AddCell(txtTotalIngresos.Text);

                    doc.Add(ingresosTable);

                    doc.Add(Chunk.NEWLINE);

                    // Sección para Egresos
                    Paragraph egresos = new Paragraph("Egresos");
                    egresos.Alignment = Element.ALIGN_CENTER;
                    egresos.SpacingAfter = 15f;
                    doc.Add(egresos);

                    PdfPTable egresosTable = new PdfPTable(2);
                    float[] egresosColumnWidths = { 30f, 30f };
                    egresosTable.SetWidths(egresosColumnWidths);

                    egresosTable.AddCell("Pago Piloto");
                    egresosTable.AddCell(txtPiloto.Text);
                    egresosTable.AddCell("Pago Ayudante");
                    egresosTable.AddCell(txtAyudante.Text);
                    egresosTable.AddCell("Pago Combustible");
                    egresosTable.AddCell(txtCombustible.Text);
                    egresosTable.AddCell("Pago Viáticos");
                    egresosTable.AddCell(txtViaticos.Text);
                    egresosTable.AddCell("Pago Extras");
                    egresosTable.AddCell(txtExtras.Text);
                    egresosTable.AddCell("Total Egresos");
                    egresosTable.AddCell(txtTotalEgresos.Text);

                    doc.Add(egresosTable);

                    doc.Add(Chunk.NEWLINE);

                    Paragraph capital = new Paragraph("Capital: " + txtCapital.Text);
                    capital.Alignment = Element.ALIGN_CENTER;
                    capital.SpacingAfter = 10f;
                    doc.Add(capital);
                    

                    // Cierra el documento
                    doc.Close();

                    MessageBox.Show("PDF guardado exitosamente");
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF: " + ex.Message);
                }
            }

        }
    }
}
