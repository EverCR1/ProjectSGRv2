namespace ProjectSGR
{
    partial class Backup
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
            this.txtRutaRestaurar = new System.Windows.Forms.TextBox();
            this.txtBaseRestaurar = new System.Windows.Forms.TextBox();
            this.btnRutaRestaurar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBaseDatos = new System.Windows.Forms.ComboBox();
            this.txtRutaGuardar = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnRutaGuardar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRutaRestaurar
            // 
            this.txtRutaRestaurar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaRestaurar.Location = new System.Drawing.Point(179, 268);
            this.txtRutaRestaurar.Name = "txtRutaRestaurar";
            this.txtRutaRestaurar.Size = new System.Drawing.Size(446, 31);
            this.txtRutaRestaurar.TabIndex = 0;
            // 
            // txtBaseRestaurar
            // 
            this.txtBaseRestaurar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseRestaurar.Location = new System.Drawing.Point(179, 330);
            this.txtBaseRestaurar.Name = "txtBaseRestaurar";
            this.txtBaseRestaurar.Size = new System.Drawing.Size(446, 31);
            this.txtBaseRestaurar.TabIndex = 1;
            // 
            // btnRutaRestaurar
            // 
            this.btnRutaRestaurar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaRestaurar.Location = new System.Drawing.Point(650, 262);
            this.btnRutaRestaurar.Name = "btnRutaRestaurar";
            this.btnRutaRestaurar.Size = new System.Drawing.Size(171, 42);
            this.btnRutaRestaurar.TabIndex = 2;
            this.btnRutaRestaurar.Text = "Obtener Ruta";
            this.btnRutaRestaurar.UseVisualStyleBackColor = true;
            this.btnRutaRestaurar.Click += new System.EventHandler(this.btnRutaRestaurar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(650, 327);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(171, 44);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar Datos";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base de datos";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base de datos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ruta Guardar";
            // 
            // cboBaseDatos
            // 
            this.cboBaseDatos.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaseDatos.FormattingEnabled = true;
            this.cboBaseDatos.Location = new System.Drawing.Point(179, 93);
            this.cboBaseDatos.Name = "cboBaseDatos";
            this.cboBaseDatos.Size = new System.Drawing.Size(446, 32);
            this.cboBaseDatos.TabIndex = 8;
            // 
            // txtRutaGuardar
            // 
            this.txtRutaGuardar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaGuardar.Location = new System.Drawing.Point(179, 155);
            this.txtRutaGuardar.Name = "txtRutaGuardar";
            this.txtRutaGuardar.Size = new System.Drawing.Size(446, 31);
            this.txtRutaGuardar.TabIndex = 9;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(650, 91);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(171, 42);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnRutaGuardar
            // 
            this.btnRutaGuardar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaGuardar.Location = new System.Drawing.Point(650, 154);
            this.btnRutaGuardar.Name = "btnRutaGuardar";
            this.btnRutaGuardar.Size = new System.Drawing.Size(171, 42);
            this.btnRutaGuardar.TabIndex = 11;
            this.btnRutaGuardar.Text = "Generar Ruta";
            this.btnRutaGuardar.UseVisualStyleBackColor = true;
            this.btnRutaGuardar.Click += new System.EventHandler(this.btnRutaGuardar_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(839, 155);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(171, 42);
            this.btnBackup.TabIndex = 12;
            this.btnBackup.Text = "Generar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Copia de Seguridad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "Recuperar Datos";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnRutaGuardar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtRutaGuardar);
            this.Controls.Add(this.cboBaseDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRutaRestaurar);
            this.Controls.Add(this.txtBaseRestaurar);
            this.Controls.Add(this.txtRutaRestaurar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup y Restauración de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaRestaurar;
        private System.Windows.Forms.TextBox txtBaseRestaurar;
        private System.Windows.Forms.Button btnRutaRestaurar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBaseDatos;
        private System.Windows.Forms.TextBox txtRutaGuardar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnRutaGuardar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}