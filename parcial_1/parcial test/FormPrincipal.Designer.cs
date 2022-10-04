namespace parcial_test
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_altaAvion = new System.Windows.Forms.Button();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_UsuarioLogeado = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_bienvenidaUser = new System.Windows.Forms.Label();
            this.dtg_aviones = new System.Windows.Forms.DataGridView();
            this.dtg_vuelos = new System.Windows.Forms.DataGridView();
            this.lbl_vuelosDisponibles = new System.Windows.Forms.Label();
            this.lbl_flota = new System.Windows.Forms.Label();
            this.btn_AltaPasaje = new System.Windows.Forms.Button();
            this.btn_AltaPasajero = new System.Windows.Forms.Button();
            this.btn_verPasajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_altaAvion
            // 
            this.btn_altaAvion.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_altaAvion.Location = new System.Drawing.Point(672, 310);
            this.btn_altaAvion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_altaAvion.Name = "btn_altaAvion";
            this.btn_altaAvion.Size = new System.Drawing.Size(114, 31);
            this.btn_altaAvion.TabIndex = 1;
            this.btn_altaAvion.TabStop = false;
            this.btn_altaAvion.Text = "Alta vuelo";
            this.btn_altaAvion.UseVisualStyleBackColor = true;
            this.btn_altaAvion.Click += new System.EventHandler(this.btn_altaVuelo_Click);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataSource = typeof(Entidades.Vendedor);
            // 
            // lbl_UsuarioLogeado
            // 
            this.lbl_UsuarioLogeado.AutoSize = true;
            this.lbl_UsuarioLogeado.Location = new System.Drawing.Point(682, 589);
            this.lbl_UsuarioLogeado.Name = "lbl_UsuarioLogeado";
            this.lbl_UsuarioLogeado.Size = new System.Drawing.Size(0, 15);
            this.lbl_UsuarioLogeado.TabIndex = 2;
            this.lbl_UsuarioLogeado.Click += new System.EventHandler(this.lbl_UsuarioLogeado_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fecha.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.Location = new System.Drawing.Point(807, 578);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(426, 26);
            this.lbl_Fecha.TabIndex = 3;
            this.lbl_Fecha.Text = "placeholder Tiempo";
            this.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_Fecha.Click += new System.EventHandler(this.lbl_Fecha_Click);
            // 
            // lbl_bienvenidaUser
            // 
            this.lbl_bienvenidaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bienvenidaUser.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenidaUser.Location = new System.Drawing.Point(404, 578);
            this.lbl_bienvenidaUser.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lbl_bienvenidaUser.Name = "lbl_bienvenidaUser";
            this.lbl_bienvenidaUser.Size = new System.Drawing.Size(426, 26);
            this.lbl_bienvenidaUser.TabIndex = 4;
            this.lbl_bienvenidaUser.Text = "placeholder user logueado";
            this.lbl_bienvenidaUser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_bienvenidaUser.Click += new System.EventHandler(this.lbl_bienvenidaUser_Click);
            // 
            // dtg_aviones
            // 
            this.dtg_aviones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_aviones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_aviones.Location = new System.Drawing.Point(46, 378);
            this.dtg_aviones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_aviones.Name = "dtg_aviones";
            this.dtg_aviones.RowHeadersWidth = 51;
            this.dtg_aviones.RowTemplate.Height = 29;
            this.dtg_aviones.Size = new System.Drawing.Size(1153, 152);
            this.dtg_aviones.TabIndex = 5;
            this.dtg_aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_aviones_CellContentClick);
            // 
            // dtg_vuelos
            // 
            this.dtg_vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_vuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vuelos.Location = new System.Drawing.Point(46, 117);
            this.dtg_vuelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_vuelos.Name = "dtg_vuelos";
            this.dtg_vuelos.RowHeadersWidth = 51;
            this.dtg_vuelos.RowTemplate.Height = 29;
            this.dtg_vuelos.Size = new System.Drawing.Size(1153, 141);
            this.dtg_vuelos.TabIndex = 6;
            this.dtg_vuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_vuelos_CellContentClick);
            // 
            // lbl_vuelosDisponibles
            // 
            this.lbl_vuelosDisponibles.AutoSize = true;
            this.lbl_vuelosDisponibles.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelosDisponibles.Location = new System.Drawing.Point(46, 63);
            this.lbl_vuelosDisponibles.Name = "lbl_vuelosDisponibles";
            this.lbl_vuelosDisponibles.Size = new System.Drawing.Size(196, 27);
            this.lbl_vuelosDisponibles.TabIndex = 7;
            this.lbl_vuelosDisponibles.Text = "Vuelos disponibles";
            this.lbl_vuelosDisponibles.Click += new System.EventHandler(this.lbl_vuelosDisponibles_Click);
            // 
            // lbl_flota
            // 
            this.lbl_flota.AutoSize = true;
            this.lbl_flota.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_flota.Location = new System.Drawing.Point(46, 333);
            this.lbl_flota.Name = "lbl_flota";
            this.lbl_flota.Size = new System.Drawing.Size(61, 27);
            this.lbl_flota.TabIndex = 8;
            this.lbl_flota.Text = "Flota";
            this.lbl_flota.Click += new System.EventHandler(this.lbl_flota_Click);
            // 
            // btn_AltaPasaje
            // 
            this.btn_AltaPasaje.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AltaPasaje.Location = new System.Drawing.Point(949, 310);
            this.btn_AltaPasaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AltaPasaje.Name = "btn_AltaPasaje";
            this.btn_AltaPasaje.Size = new System.Drawing.Size(114, 31);
            this.btn_AltaPasaje.TabIndex = 9;
            this.btn_AltaPasaje.Text = "Alta pasaje";
            this.btn_AltaPasaje.UseVisualStyleBackColor = true;
            this.btn_AltaPasaje.Click += new System.EventHandler(this.btn_AltaPasaje_Click);
            // 
            // btn_AltaPasajero
            // 
            this.btn_AltaPasajero.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AltaPasajero.Location = new System.Drawing.Point(801, 310);
            this.btn_AltaPasajero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AltaPasajero.Name = "btn_AltaPasajero";
            this.btn_AltaPasajero.Size = new System.Drawing.Size(134, 31);
            this.btn_AltaPasajero.TabIndex = 10;
            this.btn_AltaPasajero.TabStop = false;
            this.btn_AltaPasajero.Text = "Alta pasajero";
            this.btn_AltaPasajero.UseVisualStyleBackColor = true;
            this.btn_AltaPasajero.Click += new System.EventHandler(this.btn_AltaCliente_Click);
            // 
            // btn_verPasajes
            // 
            this.btn_verPasajes.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verPasajes.Location = new System.Drawing.Point(1079, 310);
            this.btn_verPasajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verPasajes.Name = "btn_verPasajes";
            this.btn_verPasajes.Size = new System.Drawing.Size(114, 31);
            this.btn_verPasajes.TabIndex = 11;
            this.btn_verPasajes.Text = "Ver pasajes";
            this.btn_verPasajes.UseVisualStyleBackColor = true;
            this.btn_verPasajes.Click += new System.EventHandler(this.btn_verPasajes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 621);
            this.Controls.Add(this.btn_verPasajes);
            this.Controls.Add(this.btn_AltaPasajero);
            this.Controls.Add(this.btn_AltaPasaje);
            this.Controls.Add(this.lbl_flota);
            this.Controls.Add(this.lbl_vuelosDisponibles);
            this.Controls.Add(this.dtg_vuelos);
            this.Controls.Add(this.dtg_aviones);
            this.Controls.Add(this.lbl_bienvenidaUser);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_UsuarioLogeado);
            this.Controls.Add(this.btn_altaAvion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolineas A Pique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_altaAvion;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private System.Windows.Forms.Label lbl_UsuarioLogeado;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_bienvenidaUser;
        private System.Windows.Forms.DataGridView dtg_aviones;
        private System.Windows.Forms.DataGridView dtg_vuelos;
        private System.Windows.Forms.Label lbl_vuelosDisponibles;
        private System.Windows.Forms.Label lbl_flota;
        private System.Windows.Forms.Button btn_AltaPasaje;
        private System.Windows.Forms.Button btn_AltaPasajero;
        private System.Windows.Forms.Button btn_verPasajes;
    }
}
