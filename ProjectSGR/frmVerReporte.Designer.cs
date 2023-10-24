namespace ProjectSGR
{
    partial class frmVerReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datosRep = new System.Windows.Forms.DataGridView();
            this.btnBuscarReporte = new System.Windows.Forms.Button();
            this.datePickFecha = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarReporte = new System.Windows.Forms.Button();
            this.btnEditarReporte = new System.Windows.Forms.Button();
            this.btnCrearRep = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.tbReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.datosIng = new System.Windows.Forms.DataGridView();
            this.tbReporteTableAdapter1 = new ProjectSGR.bdSGRDataSetTableAdapters.tbReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIng)).BeginInit();
            this.SuspendLayout();
            // 
            // datosRep
            // 
            this.datosRep.AllowUserToAddRows = false;
            this.datosRep.AllowUserToDeleteRows = false;
            this.datosRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datosRep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datosRep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.datosRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datosRep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datosRep.ColumnHeadersHeight = 20;
            this.datosRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datosRep.EnableHeadersVisualStyles = false;
            this.datosRep.GridColor = System.Drawing.Color.SteelBlue;
            this.datosRep.Location = new System.Drawing.Point(27, 83);
            this.datosRep.Name = "datosRep";
            this.datosRep.ReadOnly = true;
            this.datosRep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosRep.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datosRep.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.datosRep.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datosRep.RowTemplate.Height = 24;
            this.datosRep.Size = new System.Drawing.Size(1060, 324);
            this.datosRep.TabIndex = 0;
            this.datosRep.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datosRep_CellFormatting);
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.Location = new System.Drawing.Point(1097, 12);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(156, 40);
            this.btnBuscarReporte.TabIndex = 1;
            this.btnBuscarReporte.Text = "Buscar";
            this.btnBuscarReporte.UseVisualStyleBackColor = true;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // datePickFecha
            // 
            this.datePickFecha.Location = new System.Drawing.Point(838, 19);
            this.datePickFecha.Name = "datePickFecha";
            this.datePickFecha.Size = new System.Drawing.Size(217, 22);
            this.datePickFecha.TabIndex = 2;
            // 
            // btnEliminarReporte
            // 
            this.btnEliminarReporte.Location = new System.Drawing.Point(1129, 377);
            this.btnEliminarReporte.Name = "btnEliminarReporte";
            this.btnEliminarReporte.Size = new System.Drawing.Size(111, 30);
            this.btnEliminarReporte.TabIndex = 3;
            this.btnEliminarReporte.Text = "Eliminar";
            this.btnEliminarReporte.UseVisualStyleBackColor = true;
            this.btnEliminarReporte.Click += new System.EventHandler(this.btnEliminarReporte_Click);
            // 
            // btnEditarReporte
            // 
            this.btnEditarReporte.Location = new System.Drawing.Point(1129, 271);
            this.btnEditarReporte.Name = "btnEditarReporte";
            this.btnEditarReporte.Size = new System.Drawing.Size(111, 37);
            this.btnEditarReporte.TabIndex = 4;
            this.btnEditarReporte.Text = "Editar";
            this.btnEditarReporte.UseVisualStyleBackColor = true;
            this.btnEditarReporte.Click += new System.EventHandler(this.btnEditarReporte_Click);
            // 
            // btnCrearRep
            // 
            this.btnCrearRep.Location = new System.Drawing.Point(1129, 83);
            this.btnCrearRep.Name = "btnCrearRep";
            this.btnCrearRep.Size = new System.Drawing.Size(111, 38);
            this.btnCrearRep.TabIndex = 5;
            this.btnCrearRep.Text = "Crear";
            this.btnCrearRep.UseVisualStyleBackColor = true;
            this.btnCrearRep.Click += new System.EventHandler(this.btnCrearRep_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(1129, 184);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(111, 36);
            this.btnDetalles.TabIndex = 6;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // tbReporteBindingSource
            // 
            this.tbReporteBindingSource.DataMember = "tbReporte";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(27, 19);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(121, 34);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // datosIng
            // 
            this.datosIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosIng.Location = new System.Drawing.Point(762, 440);
            this.datosIng.Name = "datosIng";
            this.datosIng.RowHeadersWidth = 51;
            this.datosIng.RowTemplate.Height = 24;
            this.datosIng.Size = new System.Drawing.Size(135, 57);
            this.datosIng.TabIndex = 8;
            this.datosIng.Visible = false;
            // 
            // tbReporteTableAdapter1
            // 
            this.tbReporteTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVerReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 563);
            this.Controls.Add(this.datosIng);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnCrearRep);
            this.Controls.Add(this.btnEditarReporte);
            this.Controls.Add(this.btnEliminarReporte);
            this.Controls.Add(this.datePickFecha);
            this.Controls.Add(this.btnBuscarReporte);
            this.Controls.Add(this.datosRep);
            this.Name = "frmVerReporte";
            this.Text = "frmVerReporte";
            this.Load += new System.EventHandler(this.frmVerReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bdSGRDataSet bdSGRDataSet1;
        private System.Windows.Forms.Button btnBuscarReporte;
        private System.Windows.Forms.DateTimePicker datePickFecha;
        private System.Windows.Forms.Button btnEliminarReporte;
        private System.Windows.Forms.Button btnEditarReporte;
        private System.Windows.Forms.Button btnCrearRep;
        private System.Windows.Forms.Button btnDetalles;
        private bdSGRDataSet bdSGRDataSet;
        private System.Windows.Forms.BindingSource tbReporteBindingSource;
        private bdSGRDataSetTableAdapters.tbReporteTableAdapter tbReporteTableAdapter;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView datosIng;
        private bdSGRDataSet bdSGRDataSet2;
        private bdSGRDataSetTableAdapters.tbReporteTableAdapter tbReporteTableAdapter1;
        public System.Windows.Forms.DataGridView datosRep;
    }
}