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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReporteTableAdapter1 = new ProjectSGR.bdSGRDataSetTableAdapters.tbReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIng)).BeginInit();
            this.panel1.SuspendLayout();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datosRep.ColumnHeadersHeight = 25;
            this.datosRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datosRep.DefaultCellStyle = dataGridViewCellStyle10;
            this.datosRep.EnableHeadersVisualStyles = false;
            this.datosRep.GridColor = System.Drawing.Color.SteelBlue;
            this.datosRep.Location = new System.Drawing.Point(27, 90);
            this.datosRep.Name = "datosRep";
            this.datosRep.ReadOnly = true;
            this.datosRep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosRep.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datosRep.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.datosRep.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datosRep.RowTemplate.Height = 24;
            this.datosRep.Size = new System.Drawing.Size(919, 406);
            this.datosRep.TabIndex = 0;
            this.datosRep.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datosRep_CellFormatting);
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnBuscarReporte.FlatAppearance.BorderSize = 0;
            this.btnBuscarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReporte.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReporte.Location = new System.Drawing.Point(49, 90);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(182, 44);
            this.btnBuscarReporte.TabIndex = 1;
            this.btnBuscarReporte.Text = "Buscar";
            this.btnBuscarReporte.UseVisualStyleBackColor = false;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // datePickFecha
            // 
            this.datePickFecha.CalendarFont = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickFecha.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.datePickFecha.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.datePickFecha.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickFecha.Location = new System.Drawing.Point(14, 38);
            this.datePickFecha.Name = "datePickFecha";
            this.datePickFecha.Size = new System.Drawing.Size(253, 26);
            this.datePickFecha.TabIndex = 2;
            // 
            // btnEliminarReporte
            // 
            this.btnEliminarReporte.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEliminarReporte.FlatAppearance.BorderSize = 0;
            this.btnEliminarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReporte.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReporte.Location = new System.Drawing.Point(49, 451);
            this.btnEliminarReporte.Name = "btnEliminarReporte";
            this.btnEliminarReporte.Size = new System.Drawing.Size(182, 45);
            this.btnEliminarReporte.TabIndex = 3;
            this.btnEliminarReporte.Text = "Eliminar";
            this.btnEliminarReporte.UseVisualStyleBackColor = false;
            this.btnEliminarReporte.Click += new System.EventHandler(this.btnEliminarReporte_Click);
            // 
            // btnEditarReporte
            // 
            this.btnEditarReporte.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEditarReporte.FlatAppearance.BorderSize = 0;
            this.btnEditarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarReporte.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarReporte.Location = new System.Drawing.Point(49, 359);
            this.btnEditarReporte.Name = "btnEditarReporte";
            this.btnEditarReporte.Size = new System.Drawing.Size(182, 45);
            this.btnEditarReporte.TabIndex = 4;
            this.btnEditarReporte.Text = "Editar";
            this.btnEditarReporte.UseVisualStyleBackColor = false;
            this.btnEditarReporte.Click += new System.EventHandler(this.btnEditarReporte_Click);
            // 
            // btnCrearRep
            // 
            this.btnCrearRep.BackColor = System.Drawing.Color.LightGray;
            this.btnCrearRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCrearRep.FlatAppearance.BorderSize = 0;
            this.btnCrearRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRep.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRep.Location = new System.Drawing.Point(49, 181);
            this.btnCrearRep.Name = "btnCrearRep";
            this.btnCrearRep.Size = new System.Drawing.Size(182, 44);
            this.btnCrearRep.TabIndex = 5;
            this.btnCrearRep.Text = "Crear";
            this.btnCrearRep.UseVisualStyleBackColor = false;
            this.btnCrearRep.Click += new System.EventHandler(this.btnCrearRep_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.LightGray;
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.Location = new System.Drawing.Point(49, 271);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(182, 45);
            this.btnDetalles.TabIndex = 6;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // tbReporteBindingSource
            // 
            this.tbReporteBindingSource.DataMember = "tbReporte";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightGray;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(27, 27);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(159, 45);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // datosIng
            // 
            this.datosIng.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.datosIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosIng.Location = new System.Drawing.Point(811, 16);
            this.datosIng.Name = "datosIng";
            this.datosIng.RowHeadersWidth = 51;
            this.datosIng.RowTemplate.Height = 24;
            this.datosIng.Size = new System.Drawing.Size(135, 57);
            this.datosIng.TabIndex = 8;
            this.datosIng.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCrearRep);
            this.panel1.Controls.Add(this.btnDetalles);
            this.panel1.Controls.Add(this.btnEditarReporte);
            this.panel1.Controls.Add(this.datePickFecha);
            this.panel1.Controls.Add(this.btnEliminarReporte);
            this.panel1.Controls.Add(this.btnBuscarReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(976, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 510);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha para buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administración de Reportes";
            // 
            // tbReporteTableAdapter1
            // 
            this.tbReporteTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVerReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1255, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datosIng);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.datosRep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVerReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVerReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIng)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}