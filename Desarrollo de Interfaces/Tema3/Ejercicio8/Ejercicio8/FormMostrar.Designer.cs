namespace Ejercicio8
{
    partial class FormMostrar
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
            btnVolver = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNumeroCuentaCorriente = new TextBox();
            lblNumeroCuentaCorriente = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            lblMostrar = new Label();
            lblDni = new Label();
            cmbClientes = new ComboBox();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(379, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 59;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(254, 275);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 23);
            txtTelefono.TabIndex = 58;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(195, 278);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 57;
            lblTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(254, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(342, 23);
            txtNombre.TabIndex = 56;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(190, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 55;
            lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(254, 194);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(342, 23);
            txtDireccion.TabIndex = 54;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(190, 197);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 53;
            lblDireccion.Text = "Dirección";
            // 
            // txtNumeroCuentaCorriente
            // 
            txtNumeroCuentaCorriente.Location = new Point(254, 316);
            txtNumeroCuentaCorriente.Name = "txtNumeroCuentaCorriente";
            txtNumeroCuentaCorriente.Size = new Size(342, 23);
            txtNumeroCuentaCorriente.TabIndex = 52;
            // 
            // lblNumeroCuentaCorriente
            // 
            lblNumeroCuentaCorriente.AutoSize = true;
            lblNumeroCuentaCorriente.Location = new Point(107, 319);
            lblNumeroCuentaCorriente.Name = "lblNumeroCuentaCorriente";
            lblNumeroCuentaCorriente.Size = new Size(140, 15);
            lblNumeroCuentaCorriente.TabIndex = 51;
            lblNumeroCuentaCorriente.Text = "Número cuenta corriente";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(254, 235);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(342, 23);
            txtEdad.TabIndex = 50;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(214, 238);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 49;
            lblEdad.Text = "Edad";
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostrar.Location = new Point(322, 38);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(194, 37);
            lblMostrar.TabIndex = 48;
            lblMostrar.Text = "Mostrar cliente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(214, 120);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 46;
            lblDni.Text = "DNI";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(254, 117);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(342, 23);
            cmbClientes.TabIndex = 61;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(641, 116);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(121, 23);
            btnSeleccionar.TabIndex = 60;
            btnSeleccionar.Text = "Seleccionar cliente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbClientes);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnVolver);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtNumeroCuentaCorriente);
            Controls.Add(lblNumeroCuentaCorriente);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(lblMostrar);
            Controls.Add(lblDni);
            Name = "FormMostrar";
            Text = "FormMostrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtNumeroCuentaCorriente;
        private Label lblNumeroCuentaCorriente;
        private TextBox txtEdad;
        private Label lblEdad;
        private Label lblMostrar;
        private Label lblDni;
        private ComboBox cmbClientes;
        private Button btnSeleccionar;
    }
}