using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectSGR
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }


        private void btnRutaRestaurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SQL Backup Files|*.bak";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaRestaurar.Text = openFileDialog1.FileName;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string conString = "server=DESKTOP-NS0PFV5;uid=evecr;pwd=sql2023; database=bdNotas";

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = conString;
            conexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT name from sys.databases where name = 'bdNotas'", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    cboBaseDatos.Items.Add(fila[0].ToString());
                }

                cboBaseDatos.SelectedIndex = 0;
            }
        }

        private void btnRutaGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "SQL Backup files|*.bak";
            saveFileDialog1.FileName = cboBaseDatos.Text + "-" + DateTime.Today.ToString("dd-MM-yyyy") + "-" + DateTime.Now.ToString("h.mm") + ".bak";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaGuardar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists("C:\\Backup"))
                {
                    Directory.CreateDirectory("D:\\Backup");
                }

                System.Diagnostics.Process.Start("cmd", "/k" + "sqlcmd -S DESKTOP-NS0PFV5 -E -Q \"BACKUP DATABASE [" + cboBaseDatos.Text + "] TO DISK='" + txtRutaGuardar.Text + "'\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/k" + "Sqlcmd -S DESKTOP-NS0PFV5 -E -Q \"RESTORE DATABASE [" + txtBaseRestaurar.Text + "] FROM DISK = '" + txtRutaRestaurar.Text + "'\"");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}