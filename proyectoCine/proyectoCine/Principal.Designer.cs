namespace proyectoCine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarioDB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Enabled = false;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(28, 83);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(146, 32);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Enabled = false;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(358, 83);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(146, 32);
            this.btnReservas.TabIndex = 0;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Enabled = false;
            this.btnPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.Location = new System.Drawing.Point(186, 83);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(146, 32);
            this.btnPeliculas.TabIndex = 0;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoConexion.Location = new System.Drawing.Point(308, 202);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(0, 25);
            this.lblEstadoConexion.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verificar Conexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONSULTAS CINE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.informacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.películasToolStripMenuItem});
            this.consultasToolStripMenuItem.Enabled = false;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.películasToolStripMenuItem.Text = "Películas";
            this.películasToolStripMenuItem.Click += new System.EventHandler(this.películasToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMPeliculasToolStripMenuItem});
            this.aBMToolStripMenuItem.Enabled = false;
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMPeliculasToolStripMenuItem
            // 
            this.aBMPeliculasToolStripMenuItem.Name = "aBMPeliculasToolStripMenuItem";
            this.aBMPeliculasToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.aBMPeliculasToolStripMenuItem.Text = "ABM Peliculas";
            this.aBMPeliculasToolStripMenuItem.Click += new System.EventHandler(this.aBMPeliculasToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelGrupoToolStripMenuItem});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // datosDelGrupoToolStripMenuItem
            // 
            this.datosDelGrupoToolStripMenuItem.Name = "datosDelGrupoToolStripMenuItem";
            this.datosDelGrupoToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.datosDelGrupoToolStripMenuItem.Text = "Datos del grupo";
            this.datosDelGrupoToolStripMenuItem.Click += new System.EventHandler(this.datosDelGrupoToolStripMenuItem_Click);
            // 
            // btnUsuarioDB
            // 
            this.btnUsuarioDB.Enabled = false;
            this.btnUsuarioDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioDB.Location = new System.Drawing.Point(186, 147);
            this.btnUsuarioDB.Name = "btnUsuarioDB";
            this.btnUsuarioDB.Size = new System.Drawing.Size(146, 32);
            this.btnUsuarioDB.TabIndex = 4;
            this.btnUsuarioDB.Text = "Usuario DB";
            this.btnUsuarioDB.UseVisualStyleBackColor = true;
            this.btnUsuarioDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.btnUsuarioDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEstadoConexion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPeliculas);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CINE - Menu principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.Button btnUsuarioDB;
    }
}

