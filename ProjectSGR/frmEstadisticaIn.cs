using iTextSharp.text.pdf;
using iTextSharp.text;
using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectSGR
{
    public partial class frmEstadisticaIn : Form
    {
        gCapitalTableAdapter cap = new gCapitalTableAdapter();
        Reporte reporte = new Reporte();
        public frmEstadisticaIn()
        {
            InitializeComponent();
        }

        private void Generar(int id)
        {
            DataTable datos = new DataTable();
            datos = cap.GetData(id);

            // Asegúrate de que los datos estén ordenados por fecha
            datos.DefaultView.Sort = "Fecha ASC"; // Orden ascendente por fecha
            datos = datos.DefaultView.ToTable();

            int numfilas = datos.Rows.Count;
            int cantidadVeces = 0;

            for (int i = 0; i < numfilas; i++)
            {

                DateTime fecha = Convert.ToDateTime(datos.Rows[i]["Fecha"]); // Convierte el valor a DateTime
                string fec = ((DateTime)datos.Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                chartCapital.Series["CapitalS"].Points.AddXY(fec, datos.Rows[i]["CapitalDiario"]);

                cantidadVeces = cantidadVeces +
                    Convert.ToInt32(datos.Rows[i]["CapitalDiario"]);
            }

            
        }

        public void ListarVehi()
        {
            cmbVehiculo.DataSource = reporte.ListarVe();
            cmbVehiculo.DisplayMember = "Nombre";
            cmbVehiculo.ValueMember = "IdVehiculo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartCapital.Series.Clear();

            Series serieCapital = new Series("CapitalS");
            serieCapital.ChartType = SeriesChartType.Line;
            serieCapital.IsVisibleInLegend = false;
            chartCapital.Series.Add(serieCapital);

            int ide = (int)cmbVehiculo.SelectedValue;
            Generar(ide);
            btnImprimir.Visible = true;
        }

        private void frmEstadisticaIn_Load(object sender, EventArgs e)
        {
            ListarVehi();
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
                    DataRowView selectedRow = (DataRowView)cmbVehiculo.SelectedItem;
                    string name = (string)selectedRow["Nombre"];
                    datosPrincipales.Add("Vehículo: " + name + " \n");
                    datosPrincipales.Add("Capital Semanal ");

                    datosPrincipales.SpacingAfter = 10f; // Espacio después de la sección
                    doc.Add(datosPrincipales);

                    // Sección para el gráfico del Chart
                    Size originalT = chartCapital.Size;
                    chartCapital.Width = 600;
                    chartCapital.Height = 400;

                    MemoryStream chartImage = new MemoryStream();
                    chartCapital.SaveImage(chartImage, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImageElement = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                    chartImageElement.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImageElement);

                    chartCapital.Size = originalT;

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
