namespace ProjectSGR
{
    partial class frmCrearReporte
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
            this.txtCantViajes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddViajes = new System.Windows.Forms.Button();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtViaticos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAyudante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPiloto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nTurno = new System.Windows.Forms.NumericUpDown();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.panelViajes = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.panelReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantViajes
            // 
            this.txtCantViajes.Location = new System.Drawing.Point(174, 18);
            this.txtCantViajes.Name = "txtCantViajes";
            this.txtCantViajes.Size = new System.Drawing.Size(100, 22);
            this.txtCantViajes.TabIndex = 0;
            this.txtCantViajes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantViajes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Viajes";
            // 
            // btnAddViajes
            // 
            this.btnAddViajes.Location = new System.Drawing.Point(298, 18);
            this.btnAddViajes.Name = "btnAddViajes";
            this.btnAddViajes.Size = new System.Drawing.Size(88, 25);
            this.btnAddViajes.TabIndex = 2;
            this.btnAddViajes.Text = "Añadir";
            this.btnAddViajes.UseVisualStyleBackColor = true;
            this.btnAddViajes.Click += new System.EventHandler(this.btnAddViajes_Click);
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.cBoxVehiculo);
            this.panelReporte.Controls.Add(this.btnCrear);
            this.panelReporte.Controls.Add(this.btnCancelar);
            this.panelReporte.Controls.Add(this.txtComentario);
            this.panelReporte.Controls.Add(this.label13);
            this.panelReporte.Controls.Add(this.label12);
            this.panelReporte.Controls.Add(this.txtCapital);
            this.panelReporte.Controls.Add(this.label10);
            this.panelReporte.Controls.Add(this.txtTotalEgresos);
            this.panelReporte.Controls.Add(this.label11);
            this.panelReporte.Controls.Add(this.txtTotalIngresos);
            this.panelReporte.Controls.Add(this.label9);
            this.panelReporte.Controls.Add(this.txtExtras);
            this.panelReporte.Controls.Add(this.label8);
            this.panelReporte.Controls.Add(this.txtViaticos);
            this.panelReporte.Controls.Add(this.label7);
            this.panelReporte.Controls.Add(this.txtCombustible);
            this.panelReporte.Controls.Add(this.label6);
            this.panelReporte.Controls.Add(this.txtAyudante);
            this.panelReporte.Controls.Add(this.label5);
            this.panelReporte.Controls.Add(this.txtPiloto);
            this.panelReporte.Controls.Add(this.label4);
            this.panelReporte.Controls.Add(this.label3);
            this.panelReporte.Controls.Add(this.label2);
            this.panelReporte.Controls.Add(this.nTurno);
            this.panelReporte.Controls.Add(this.datePick);
            this.panelReporte.Location = new System.Drawing.Point(24, 55);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(475, 375);
            this.panelReporte.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(124, 335);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(101, 23);
            this.btnCrear.TabIndex = 28;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(9, 253);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(452, 76);
            this.txtComentario.TabIndex = 27;
            this.txtComentario.Text = "SC";
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentario_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Si tiene un comentario, escríbalo abajo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Capital:";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(70, 208);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.Size = new System.Drawing.Size(106, 22);
            this.txtCapital.TabIndex = 24;
            this.txtCapital.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Egresos:";
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(331, 165);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(100, 22);
            this.txtTotalEgresos.TabIndex = 22;
            this.txtTotalEgresos.Text = "0.00";
            this.txtTotalEgresos.TextChanged += new System.EventHandler(this.txtTotalEgresos_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Ingresos:";
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(112, 165);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.ReadOnly = true;
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 22);
            this.txtTotalIngresos.TabIndex = 20;
            this.txtTotalIngresos.Text = "0.00";
            this.txtTotalIngresos.TextChanged += new System.EventHandler(this.txtTotalIngresos_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Extras:";
            // 
            // txtExtras
            // 
            this.txtExtras.Location = new System.Drawing.Point(378, 123);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(73, 22);
            this.txtExtras.TabIndex = 18;
            this.txtExtras.TextChanged += new System.EventHandler(this.txtExtras_TextChanged);
            this.txtExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtras_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Viaticos:";
            // 
            // txtViaticos
            // 
            this.txtViaticos.Location = new System.Drawing.Point(246, 123);
            this.txtViaticos.Name = "txtViaticos";
            this.txtViaticos.Size = new System.Drawing.Size(73, 22);
            this.txtViaticos.TabIndex = 16;
            this.txtViaticos.TextChanged += new System.EventHandler(this.txtViaticos_TextChanged);
            this.txtViaticos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtViaticos_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Combustible:";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Location = new System.Drawing.Point(103, 123);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(73, 22);
            this.txtCombustible.TabIndex = 14;
            this.txtCombustible.TextChanged += new System.EventHandler(this.txtCombustible_TextChanged);
            this.txtCombustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombustible_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pago Ayudante:";
            // 
            // txtAyudante
            // 
            this.txtAyudante.Location = new System.Drawing.Point(318, 82);
            this.txtAyudante.Name = "txtAyudante";
            this.txtAyudante.Size = new System.Drawing.Size(100, 22);
            this.txtAyudante.TabIndex = 12;
            this.txtAyudante.TextChanged += new System.EventHandler(this.txtAyudante_TextChanged);
            this.txtAyudante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyudante_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pago Piloto:";
            // 
            // txtPiloto
            // 
            this.txtPiloto.Location = new System.Drawing.Point(103, 82);
            this.txtPiloto.Name = "txtPiloto";
            this.txtPiloto.Size = new System.Drawing.Size(100, 22);
            this.txtPiloto.TabIndex = 10;
            this.txtPiloto.TextChanged += new System.EventHandler(this.txtPiloto_TextChanged);
            this.txtPiloto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiloto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vehículo:";
            // 
            // nTurno
            // 
            this.nTurno.Location = new System.Drawing.Point(309, 3);
            this.nTurno.Name = "nTurno";
            this.nTurno.Size = new System.Drawing.Size(37, 22);
            this.nTurno.TabIndex = 6;
            this.nTurno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(103, 43);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(306, 22);
            this.datePick.TabIndex = 5;
            // 
            // panelViajes
            // 
            this.panelViajes.Location = new System.Drawing.Point(539, 55);
            this.panelViajes.Name = "panelViajes";
            this.panelViajes.Size = new System.Drawing.Size(359, 375);
            this.panelViajes.TabIndex = 4;
            this.panelViajes.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(662, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Registro de Ingresos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(811, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cBoxVehiculo
            // 
            this.cBoxVehiculo.FormattingEnabled = true;
            this.cBoxVehiculo.Location = new System.Drawing.Point(104, 6);
            this.cBoxVehiculo.Name = "cBoxVehiculo";
            this.cBoxVehiculo.Size = new System.Drawing.Size(136, 24);
            this.cBoxVehiculo.TabIndex = 29;
            // 
            // frmCrearReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 446);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panelViajes);
            this.Controls.Add(this.panelReporte);
            this.Controls.Add(this.btnAddViajes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantViajes);
            this.Name = "frmCrearReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Reporte";
            this.Load += new System.EventHandler(this.frmCrearReporte_Load);
            this.panelReporte.ResumeLayout(false);
            this.panelReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bdSGRDataSet bdSGRDataSet;
        private bdSGRDataSetTableAdapters.tbVehiculoTableAdapter tbVehiculoTableAdapter;
        public System.Windows.Forms.TextBox txtCantViajes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAddViajes;
        public System.Windows.Forms.Panel panelReporte;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nTurno;
        public System.Windows.Forms.DateTimePicker datePick;
        public System.Windows.Forms.TextBox txtPiloto;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtViaticos;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCombustible;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAyudante;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtExtras;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTotalEgresos;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTotalIngresos;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtCapital;
        public System.Windows.Forms.TextBox txtComentario;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Panel panelViajes;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.ComboBox cBoxVehiculo;
    }
}