using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        
    }
}
