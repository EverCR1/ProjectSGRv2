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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectSGR
{
    public partial class frmEstadisticaV : Form
    {
        pVehiculoMostTableAdapter most = new pVehiculoMostTableAdapter();
        public frmEstadisticaV()
        {
            InitializeComponent();
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {

            VehiculoUsado();

        }

        private void VehiculoUsado()
        {
            DataTable data = new DataTable();
            data = most.GetData();

            int numfilas = data.Rows.Count;
            int cantidadVeces = 0;

            for(int i = 0; i < numfilas; i++)
            {
                chartVehiculo.Series["VehiculoS"].Points.AddXY(data.Rows[i]["Vehículo"], 
                    data.Rows[i]["Reportes"]);

                cantidadVeces = cantidadVeces + 
                    Convert.ToInt32(data.Rows[i]["Reportes"]);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Crea un nuevo documento PDF
            Document doc = new Document(PageSize.A4.Rotate());

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
                    datosPrincipales.Add("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n");
                    datosPrincipales.Add("Vehículos más utilizados ");

                    datosPrincipales.SpacingAfter = 10f; // Espacio después de la sección
                    doc.Add(datosPrincipales);

                    // Sección para el gráfico del Chart
                    Size originalT= chartVehiculo.Size;
                    chartVehiculo.Width = 600; 
                    chartVehiculo.Height = 400;

                    MemoryStream chartImage = new MemoryStream();
                    chartVehiculo.SaveImage(chartImage, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImageElement = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                    chartImageElement.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImageElement);

                    chartVehiculo.Size = originalT;

                    // Cierra el documento
                    doc.Close();

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("El archivo PDF se ha generado correctamente");

                    // Abre el PDF automáticamente con el visor de PDF predeterminado:
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
