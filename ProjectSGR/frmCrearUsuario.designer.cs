namespace ProjectSGR
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.bdSGRDataSet = new ProjectSGR.bdSGRDataSet();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bdSGRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new ProjectSGR.bdSGRDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tbCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCargoTableAdapter = new ProjectSGR.bdSGRDataSetTableAdapters.tbCargoTableAdapter();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bdSGRDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtDPI
            // 
            this.txtDPI.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtDPI, "txtDPI");
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDPI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.LightGray;
            this.cbCargo.DataSource = this.bdSGRDataSet;
            this.cbCargo.DisplayMember = "tbCargo.Cargo";
            resources.ApplyResources(this.cbCargo, "cbCargo");
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.ValueMember = "tbUsuario.idCargo";
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // bdSGRDataSet
            // 
            this.bdSGRDataSet.DataSetName = "bdSGRDataSet";
            this.bdSGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datePick
            // 
            this.datePick.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.datePick.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.datePick, "datePick");
            this.datePick.Name = "datePick";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // bdSGRDataSetBindingSource
            // 
            this.bdSGRDataSetBindingSource.DataSource = this.bdSGRDataSet;
            this.bdSGRDataSetBindingSource.Position = 0;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bdSGRDataSetBindingSource;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tbCargoBindingSource
            // 
            this.tbCargoBindingSource.DataMember = "tbCargo";
            this.tbCargoBindingSource.DataSource = this.bdSGRDataSetBindingSource;
            // 
            // tbCargoTableAdapter
            // 
            this.tbCargoTableAdapter.ClearBeforeFill = true;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnCrear, "btnCrear");
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bdSGRDataSetBindingSource1
            // 
            this.bdSGRDataSetBindingSource1.DataSource = this.bdSGRDataSet;
            this.bdSGRDataSetBindingSource1.Position = 0;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtConfirmarPass, "txtConfirmarPass");
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.UseSystemPasswordChar = true;
            // 
            // txtLicencia
            // 
            this.txtLicencia.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.txtLicencia, "txtLicencia");
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // frmCrearUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtConfirmarPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCrearUsuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bdSGRDataSetBindingSource;
        private bdSGRDataSet bdSGRDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private bdSGRDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.BindingSource tbCargoBindingSource;
        private bdSGRDataSetTableAdapters.tbCargoTableAdapter tbCargoTableAdapter;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bdSGRDataSetBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDPI;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.ComboBox cbCargo;
        public System.Windows.Forms.DateTimePicker datePick;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtConfirmarPass;
        public System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}