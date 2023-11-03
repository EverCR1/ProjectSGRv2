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

namespace ProjectSGR
{
    public partial class frmVerUsuario : Form
    {
        Usuarios usuario = new Usuarios();
        detallesPilotoTableAdapter detalleP = new detallesPilotoTableAdapter();
        detallesUsuarioTableAdapter detalleU = new detallesUsuarioTableAdapter();
        
        public frmVerUsuario()
        {
            InitializeComponent();
        }

        private void frmVerUsuario_Load(object sender, EventArgs e)
        {


            Refresh();
        }

        private void Refresh()
        {

            //Data Gried View de Usuarios
            dataGridView1.DataSource = usuario.listarUsuarios();
            dataGridView1.Columns["idUsuario"].Visible = false;
            dataGridView1.Columns["idCargo"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;

            //Data Gried View de Pilotos
            dataPiloto.DataSource = usuario.listarPilotos();
            dataPiloto.Columns["idUsuario"].Visible = false;
            dataPiloto.Columns["idCargo"].Visible = false;
            dataPiloto.Columns["pass"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.Operacion = "Editar";

            if (dataPiloto.SelectedRows.Count > 0 )
            {
                int ide = Convert.ToInt32(dataPiloto.CurrentRow.Cells[0].Value);
                frm.idd = ide;
                
                frm.ListarCargos();
                // frm.ListarLicencias();
                frm.txtDPI.Text = dataPiloto.CurrentRow.Cells["DPI"].Value.ToString();
                frm.txtNombre.Text = dataPiloto.CurrentRow.Cells["nombres"].Value.ToString();
                frm.txtApellido.Text = dataPiloto.CurrentRow.Cells["apellidos"].Value.ToString();
                frm.txtUsername.Text = dataPiloto.CurrentRow.Cells["username"].Value.ToString();
                frm.cbCargo.SelectedValue = Convert.ToInt32(dataPiloto.CurrentRow.Cells["idCargo"].Value);
                frm.txtLicencia.Text = dataPiloto.CurrentRow.Cells["tipoLicencia"].Value.ToString();
                frm.txtPass.Text = dataPiloto.CurrentRow.Cells["pass"].Value.ToString();
                frm.txtConfirmarPass.Text = dataPiloto.CurrentRow.Cells["pass"].Value.ToString();
                //frm.datePick.Text = dataGridView1.CurrentRow.Cells["fechaNac"].Value.ToString();

                frm.ShowDialog();
                Refresh();

            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                int ide = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                frm.idd = ide;

                frm.ListarCargos();
                //frm.ListarLicencias();
                frm.txtDPI.Text = dataGridView1.CurrentRow.Cells["DPI"].Value.ToString();
                frm.txtNombre.Text = dataGridView1.CurrentRow.Cells["nombres"].Value.ToString();
                frm.txtApellido.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
                frm.txtUsername.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                frm.txtPass.Text = dataGridView1.CurrentRow.Cells["pass"].Value.ToString();
                frm.txtConfirmarPass.Text = dataGridView1.CurrentRow.Cells["pass"].Value.ToString();
                frm.cbCargo.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idCargo"].Value);
                //frm.datePick.Text = dataPiloto.CurrentRow.Cells["fechaNac"].Value.ToString();

                frm.ShowDialog();
                Refresh();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.Operacion = "Crear";
            frm.ShowDialog();
            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataPiloto.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int ide = Convert.ToInt32(dataPiloto.CurrentRow.Cells[0].Value);
                usuario.EliminarPiloto(ide);
                MessageBox.Show("Usuario eliminado correctamente");
                Refresh();
                }
                else
                {
                    this.Close();
                }
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int ide = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                usuario.EliminarUsuario(ide);
                MessageBox.Show("Usuario eliminado correctamente");
                Refresh();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataPiloto.SelectedRows.Count > 0)
            {
                int ide = Convert.ToInt32(dataPiloto.CurrentRow.Cells[0].Value);
                DataTable data = new DataTable();
                data = detalleP.GetData(ide);

                frmDetallesUsuario frm = new frmDetallesUsuario();
                DataRow fila = data.Rows[0];
                frm.idUsuario = ide;
                frm.txtDPI.Text = fila["DPI"].ToString();
                frm.txtNombre.Text = fila["nombres"].ToString();
                frm.txtApellido.Text = fila["apellidos"].ToString();
                frm.txtUsername.Text = fila["username"].ToString();
                frm.txtCargo.Text = fila["Cargo"].ToString();
                frm.txtLicencia.Text = fila["tipoLicencia"].ToString();
                frm.txtEdad.Text=fila["Edad"].ToString();
                frm.txtFecha.Text = ((DateTime)fila["fechaNac"]).ToString("dd/MM/yyyy");

                frm.ShowDialog();
                Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
