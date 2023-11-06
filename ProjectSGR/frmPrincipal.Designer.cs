namespace ProjectSGR
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículoMásUsadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCopiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.bdSGRDataSet = new ProjectSGR.bdSGRDataSet();
            this.bdSGRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crearCopiaORecuperarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.vehículosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.estadísticaToolStripMenuItem,
            this.respaldoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrincipal.Size = new System.Drawing.Size(156, 498);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.userToolStripMenuItem.Text = "Mi Cuenta";
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.verPerfilToolStripMenuItem.Text = "Ver Perfil";
            this.verPerfilToolStripMenuItem.Click += new System.EventHandler(this.verPerfilToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearReporteToolStripMenuItem,
            this.editarReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearReporteToolStripMenuItem
            // 
            this.crearReporteToolStripMenuItem.Name = "crearReporteToolStripMenuItem";
            this.crearReporteToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.crearReporteToolStripMenuItem.Text = "Crear Reporte";
            this.crearReporteToolStripMenuItem.Click += new System.EventHandler(this.crearReporteToolStripMenuItem_Click);
            // 
            // editarReporteToolStripMenuItem
            // 
            this.editarReporteToolStripMenuItem.Name = "editarReporteToolStripMenuItem";
            this.editarReporteToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.editarReporteToolStripMenuItem.Text = "Administrar Reportes";
            this.editarReporteToolStripMenuItem.Click += new System.EventHandler(this.editarReporteToolStripMenuItem_Click);
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarVehículoToolStripMenuItem});
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            // 
            // editarVehículoToolStripMenuItem
            // 
            this.editarVehículoToolStripMenuItem.Name = "editarVehículoToolStripMenuItem";
            this.editarVehículoToolStripMenuItem.Size = new System.Drawing.Size(337, 36);
            this.editarVehículoToolStripMenuItem.Text = "Administrar Vehículos";
            this.editarVehículoToolStripMenuItem.Click += new System.EventHandler(this.editarVehículoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(329, 36);
            this.crearUsuarioToolStripMenuItem.Text = "Administrar Usuarios";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // estadísticaToolStripMenuItem
            // 
            this.estadísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehículoMásUsadoToolStripMenuItem,
            this.viajesPorDíaToolStripMenuItem});
            this.estadísticaToolStripMenuItem.Name = "estadísticaToolStripMenuItem";
            this.estadísticaToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.estadísticaToolStripMenuItem.Text = "Estadística";
            // 
            // vehículoMásUsadoToolStripMenuItem
            // 
            this.vehículoMásUsadoToolStripMenuItem.Name = "vehículoMásUsadoToolStripMenuItem";
            this.vehículoMásUsadoToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.vehículoMásUsadoToolStripMenuItem.Text = "Vehículo más usado";
            this.vehículoMásUsadoToolStripMenuItem.Click += new System.EventHandler(this.vehículoMásUsadoToolStripMenuItem_Click);
            // 
            // viajesPorDíaToolStripMenuItem
            // 
            this.viajesPorDíaToolStripMenuItem.Name = "viajesPorDíaToolStripMenuItem";
            this.viajesPorDíaToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.viajesPorDíaToolStripMenuItem.Text = "Capital de los últimos 7 días";
            this.viajesPorDíaToolStripMenuItem.Click += new System.EventHandler(this.viajesPorDíaToolStripMenuItem_Click);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCopiaDeSeguridadToolStripMenuItem,
            this.crearCopiaORecuperarToolStripMenuItem});
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            // 
            // realizarCopiaDeSeguridadToolStripMenuItem
            // 
            this.realizarCopiaDeSeguridadToolStripMenuItem.Name = "realizarCopiaDeSeguridadToolStripMenuItem";
            this.realizarCopiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(395, 36);
            this.realizarCopiaDeSeguridadToolStripMenuItem.Text = "Realizar copia de seguridad";
            this.realizarCopiaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.realizarCopiaDeSeguridadToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eOMToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // eOMToolStripMenuItem
            // 
            this.eOMToolStripMenuItem.Name = "eOMToolStripMenuItem";
            this.eOMToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.eOMToolStripMenuItem.Text = "EOM";
            this.eOMToolStripMenuItem.Click += new System.EventHandler(this.eOMToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjectSGR.Properties.Resources.Bus;
            this.pictureBox2.Location = new System.Drawing.Point(359, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 314);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(371, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Gestión de Reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(464, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transportes Francisco";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(895, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 29);
            this.labelHora.TabIndex = 5;
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // bdSGRDataSet
            // 
            this.bdSGRDataSet.DataSetName = "bdSGRDataSet";
            this.bdSGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdSGRDataSetBindingSource
            // 
            this.bdSGRDataSetBindingSource.DataSource = this.bdSGRDataSet;
            this.bdSGRDataSetBindingSource.Position = 0;
            // 
            // crearCopiaORecuperarToolStripMenuItem
            // 
            this.crearCopiaORecuperarToolStripMenuItem.Name = "crearCopiaORecuperarToolStripMenuItem";
            this.crearCopiaORecuperarToolStripMenuItem.Size = new System.Drawing.Size(395, 36);
            this.crearCopiaORecuperarToolStripMenuItem.Text = "Crear Copia o Recuperar";
            this.crearCopiaORecuperarToolStripMenuItem.Click += new System.EventHandler(this.crearCopiaORecuperarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.BackgroundImage = global::ProjectSGR.Properties.Resources.FondoF;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 498);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSGRDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.BindingSource bdSGRDataSetBindingSource;
        private bdSGRDataSet bdSGRDataSet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.ToolStripMenuItem realizarCopiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículoMásUsadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesPorDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaORecuperarToolStripMenuItem;
    }
}

