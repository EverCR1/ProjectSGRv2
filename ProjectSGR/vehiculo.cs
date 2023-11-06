using ProjectSGR.bdSGRDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculo
{
    public class vehiculo
    {
        
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Estado { get; set; }
        public int idPiloto { get; set; }
        public int idUsuario { get; set; }

        
        QueriesTableAdapter adapter = new QueriesTableAdapter();
        LPilotoTableAdapter LPloto = new LPilotoTableAdapter();
        SelectVehiTableAdapter select = new SelectVehiTableAdapter();
        VistaVehiculoTableAdapter vista = new VistaVehiculoTableAdapter();
        
        public DataTable ListarV()
        {

            DataTable dataTable = new DataTable();
            dataTable = vista.GetData();
            return dataTable;
        }
        public DataTable ListarP(int id)
        {
            DataTable dataTable = new DataTable();
            dataTable = LPloto.GetData(id);
            return dataTable;
        }
        public void Registrar_vehiculo()
        {
            adapter.InsertVehi(Nombre, (byte)(int)Capacidad, Marca, Color, Estado, idPiloto, idUsuario);

        }
        public void elminar_vehiculo(int Id)
        {
            adapter.DeleteVehiculo(Id);

        }
        public void editar_vehiculo(int Id)
        {
            adapter.UpdateVehi(Nombre, Capacidad, Marca, Color, Estado, idPiloto, idUsuario, Id);
        }
        public DataTable ListarVId()
        {
            DataTable dt = new DataTable();
            dt = select.GetData();
            return dt;
        }

        //Método para validar que no se repitan nombres de vehiculos
        public bool VerificarVehiculo(string nombre)
        {
            int validar = (int)adapter.VerificarVehiculo(nombre); //Obtiene el nombre del vehiculo

            if (validar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        }
    }
