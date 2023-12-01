namespace _2
{
    partial class FormAgregarMantenimiento
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
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            txtCodigoDescripcion = new TextBox();
            txtIdVehiculo = new TextBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            lblMatricula = new Label();
            lblAnoFabricacion = new Label();
            lblEstado = new Label();
            lblId = new Label();
            errId = new ErrorProvider(components);
            errCodigoDescripcion = new ErrorProvider(components);
            errIdVehiculo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errCodigoDescripcion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errIdVehiculo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(366, 334);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 60);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = "Agregar mantenimiento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCodigoDescripcion
            // 
            txtCodigoDescripcion.Location = new Point(404, 97);
            txtCodigoDescripcion.Name = "txtCodigoDescripcion";
            txtCodigoDescripcion.Size = new Size(100, 23);
            txtCodigoDescripcion.TabIndex = 37;
            txtCodigoDescripcion.Validating += txtCodigoDescripcion_Validating;
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Location = new Point(404, 139);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(100, 23);
            txtIdVehiculo.TabIndex = 36;
            txtIdVehiculo.Validating += txtIdVehiculo_Validating;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(404, 182);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(100, 23);
            txtFechaInicio.TabIndex = 35;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(404, 222);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(100, 23);
            txtFechaFin.TabIndex = 34;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(404, 262);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 33;
            // 
            // txtId
            // 
            txtId.Location = new Point(404, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 32;
            txtId.Validating += txtId_Validating;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(322, 185);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(70, 15);
            lblMarca.TabIndex = 31;
            lblMarca.Text = "Fecha inicio";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(322, 142);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(65, 15);
            lblModelo.TabIndex = 30;
            lblModelo.Text = "Id vehículo";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(269, 100);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(110, 15);
            lblMatricula.TabIndex = 29;
            lblMatricula.Text = "Código descripción";
            // 
            // lblAnoFabricacion
            // 
            lblAnoFabricacion.AutoSize = true;
            lblAnoFabricacion.Location = new Point(332, 225);
            lblAnoFabricacion.Name = "lblAnoFabricacion";
            lblAnoFabricacion.Size = new Size(55, 15);
            lblAnoFabricacion.TabIndex = 28;
            lblAnoFabricacion.Text = "Fecha fin";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(322, 265);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(69, 15);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Descripción";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(347, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 26;
            lblId.Text = "Id";
            // 
            // errId
            // 
            errId.ContainerControl = this;
            // 
            // errCodigoDescripcion
            // 
            errCodigoDescripcion.ContainerControl = this;
            // 
            // errIdVehiculo
            // 
            errIdVehiculo.ContainerControl = this;
            // 
            // FormAgregarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtCodigoDescripcion);
            Controls.Add(txtIdVehiculo);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtFechaFin);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblMatricula);
            Controls.Add(lblAnoFabricacion);
            Controls.Add(lblEstado);
            Controls.Add(lblId);
            Name = "FormAgregarMantenimiento";
            Text = "FormAgregarMantenimiento";
            ((System.ComponentModel.ISupportInitialize)errId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errCodigoDescripcion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errIdVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtCodigoDescripcion;
        private TextBox txtIdVehiculo;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
        private TextBox txtDescripcion;
        private TextBox txtId;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblMatricula;
        private Label lblAnoFabricacion;
        private Label lblEstado;
        private Label lblId;
        private ErrorProvider errId;
        private ErrorProvider errCodigoDescripcion;
        private ErrorProvider errIdVehiculo;
    }
}