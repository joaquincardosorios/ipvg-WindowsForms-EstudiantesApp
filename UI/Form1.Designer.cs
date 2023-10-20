namespace UI
{
    partial class Form1
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
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.gbEstudiante = new System.Windows.Forms.GroupBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAgregar.SuspendLayout();
            this.gbEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Controls.Add(this.dtpDoB);
            this.gbAgregar.Controls.Add(this.txtApellidos);
            this.gbAgregar.Controls.Add(this.txtNombres);
            this.gbAgregar.Controls.Add(this.txtRut);
            this.gbAgregar.Controls.Add(this.lblApellidos);
            this.gbAgregar.Controls.Add(this.lblDob);
            this.gbAgregar.Controls.Add(this.lblNombres);
            this.gbAgregar.Controls.Add(this.lblRut);
            this.gbAgregar.Location = new System.Drawing.Point(21, 12);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(476, 112);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Estudiante";
            // 
            // gbEstudiante
            // 
            this.gbEstudiante.Controls.Add(this.dtgvEstudiantes);
            this.gbEstudiante.Controls.Add(this.btnEliminar);
            this.gbEstudiante.Location = new System.Drawing.Point(21, 130);
            this.gbEstudiante.Name = "gbEstudiante";
            this.gbEstudiante.Size = new System.Drawing.Size(476, 229);
            this.gbEstudiante.TabIndex = 1;
            this.gbEstudiante.TabStop = false;
            this.gbEstudiante.Text = "Estudiante";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(18, 27);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(27, 13);
            this.lblRut.TabIndex = 0;
            this.lblRut.Text = "Rut:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(18, 52);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(18, 76);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(253, 23);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(114, 13);
            this.lblDob.TabIndex = 0;
            this.lblDob.Text = "Fecha de Nacimiento: ";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(69, 24);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(139, 20);
            this.txtRut.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(69, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(139, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(69, 76);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(139, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(256, 39);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(200, 20);
            this.dtpDoB.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(348, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Estudiante";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(348, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar Seleccion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgvEstudiantes
            // 
            this.dtgvEstudiantes.AllowUserToAddRows = false;
            this.dtgvEstudiantes.AllowUserToDeleteRows = false;
            this.dtgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Apellidos,
            this.DOB});
            this.dtgvEstudiantes.Location = new System.Drawing.Point(6, 31);
            this.dtgvEstudiantes.Name = "dtgvEstudiantes";
            this.dtgvEstudiantes.ReadOnly = true;
            this.dtgvEstudiantes.Size = new System.Drawing.Size(464, 150);
            this.dtgvEstudiantes.TabIndex = 1;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Fecha de Nacimiento";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(514, 371);
            this.Controls.Add(this.gbEstudiante);
            this.Controls.Add(this.gbAgregar);
            this.Name = "Form1";
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.gbEstudiante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.GroupBox gbVisualizacion;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.GroupBox gbEstudiante;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.DataGridView dtgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.Button btnEliminar;
    }
}

