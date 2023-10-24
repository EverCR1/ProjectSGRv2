using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSGR
{
    public class Reporte
    {

        public int CantViajes { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime Fecha { get; set; }
        public int Turno { get; set; }
        public int PagoPiloto { get; set; }
        public int PagoAyudante { get; set; }
        public int PagoCombustible { get; set; }
        public int PagoViaticos { get; set; }
        public decimal PagoExtras { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalEgresos { get; set; }
        public decimal Capital { get; set; }
        public string Comentario { get; set; }
        public int IdUsuario { get; set; }

        public List<decimal> Listado = new List<decimal>();

        QueriesTableAdapter adapter = new QueriesTableAdapter();
        pResumenReporteTableAdapter ResumenReporte = new pResumenReporteTableAdapter();
        pBuscarReporteTableAdapter buscarReporte = new pBuscarReporteTableAdapter();
        pListarReporteTableAdapter listarReporte = new pListarReporteTableAdapter();
        pListarIngresosTableAdapter listarIngreso = new pListarIngresosTableAdapter();
        ListarVehiculosTableAdapter listaVe = new ListarVehiculosTableAdapter();
        //Método para crear reportes
        public void CrearReporte()
        {
            int valorDeSalida = 1;
            byte tyn = (byte)Turno;

            // Crear un DataTable
            DataTable dataTable = new DataTable();

            DataColumn reporteColumn = new DataColumn("idReporte", typeof(int)); // Ajusta el tipo de datos según tu lista
            dataTable.Columns.Add(reporteColumn);
            // Agregar la columna "IdVuelta" con autoincremento
            DataColumn idVueltaColumn = new DataColumn("idVuelta", typeof(int));
            idVueltaColumn.AutoIncrement = true;
            idVueltaColumn.AutoIncrementSeed = 1; // Comenzar en 1
            idVueltaColumn.AutoIncrementStep = 1; // Incrementar en 1
            dataTable.Columns.Add(idVueltaColumn);

            // Agregar la columna "Ingreso" (debes ajustar el tipo de datos según la lista)
            DataColumn ingresoColumn = new DataColumn("Ingreso", typeof(decimal)); // Ajusta el tipo de datos según tu lista
            dataTable.Columns.Add(ingresoColumn);


            // Obtener una lista de ingresos (reemplaza con tu propia lista)
            List<decimal> listaIngresos = Listado; // Reemplaza esta línea con tu lista

            // Llenar el DataTable con los datos de la lista
            foreach (decimal ingreso in listaIngresos)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["idReporte"] = valorDeSalida;
                newRow["Ingreso"] = ingreso; // Asigna el valor de ingreso desde la lista
                dataTable.Rows.Add(newRow);
            }

            adapter.pCrearReporte(CantViajes, IdVehiculo, Fecha, tyn, PagoPiloto, PagoAyudante,
                PagoCombustible, PagoViaticos, PagoExtras, TotalIngresos, TotalEgresos,
                Capital, Comentario, IdUsuario, dataTable);

        }

        //Método para Mostrar/Listar Reportes
        public DataTable ListarReporte()
        {
            DataTable dataTable = new DataTable();
            dataTable = listarReporte.GetData();
            return dataTable;
        }

        //Método para Mostrar/Listar Ingresos
        public DataTable ListarIngresos(int idRep)
        {
            DataTable dataTable = new DataTable();
            dataTable = listarIngreso.GetData(idRep);
            return dataTable;
        }

        //Método para Listar nombres de Vehiculos
        public DataTable ListarVe()
        {
            DataTable dataTable = new DataTable();
            dataTable = listaVe.GetData();
            return dataTable;
        }


        //Método para Editar Reportes
        public void EditarReporte(int idRep)
        {

            int valorDeSalida = 1;
            byte tyn = (byte)Turno;

            // Crear un DataTable
            DataTable dataTable = new DataTable();

            DataColumn reporteColumn = new DataColumn("idReporte", typeof(int)); // Ajusta el tipo de datos según tu lista
            dataTable.Columns.Add(reporteColumn);
            // Agregar la columna "IdVuelta" con autoincremento
            DataColumn idVueltaColumn = new DataColumn("idVuelta", typeof(int));
            idVueltaColumn.AutoIncrement = true;
            idVueltaColumn.AutoIncrementSeed = 1; // Comenzar en 1
            idVueltaColumn.AutoIncrementStep = 1; // Incrementar en 1
            dataTable.Columns.Add(idVueltaColumn);

            // Agregar la columna "Ingreso" (debes ajustar el tipo de datos según la lista)
            DataColumn ingresoColumn = new DataColumn("Ingreso", typeof(decimal)); // Ajusta el tipo de datos según tu lista
            dataTable.Columns.Add(ingresoColumn);


            // Obtener una lista de ingresos (reemplaza con tu propia lista)
            List<decimal> listaIngresos = Listado; // Reemplaza esta línea con tu lista

            // Llenar el DataTable con los datos de la lista
            foreach (decimal ingreso in listaIngresos)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["idReporte"] = valorDeSalida;
                newRow["Ingreso"] = ingreso; // Asigna el valor de ingreso desde la lista
                dataTable.Rows.Add(newRow);
            }

            adapter.pEditarReporte(idRep, CantViajes, IdVehiculo, Fecha, tyn, PagoPiloto, PagoAyudante,
                PagoCombustible, PagoViaticos, PagoExtras, TotalIngresos, TotalEgresos,
                Capital, Comentario, IdUsuario, dataTable);
        }

        //Método para Eliminar Reportes
        public void EliminarReporte(int idRep)
        {
            adapter.pEliminarReporte(idRep);
        }

        //Método para Buscar Reportes
        public DataTable BuscarReporte(DateTime fecha)
        {
            DataTable dataTable = new DataTable();
            dataTable = buscarReporte.GetData(fecha);
            return dataTable;
        }
    }
}
