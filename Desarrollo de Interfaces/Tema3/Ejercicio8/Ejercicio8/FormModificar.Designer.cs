namespace Ejercicio8
{
    partial class FormModificar
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
            btnCancelar = new Button();
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
            lblModificar = new Label();
            lblDni = new Label();
            btnConfirmar = new Button();
            btnSeleccionar = new Button();
            cmbClientes = new ComboBox();
            errDni = new ErrorProvider(components);
            errNombre = new ErrorProvider(components);
            errDireccion = new ErrorProvider(components);
            errEdad = new ErrorProvider(components);
            errTelefono = new ErrorProvider(components);
            errNumeroCuentaCorriente = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errDni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDireccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNumeroCuentaCorriente).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(468, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(262, 272);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 23);
            txtTelefono.TabIndex = 28;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(203, 275);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(262, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(342, 23);
            txtNombre.TabIndex = 26;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(198, 157);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(262, 191);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(342, 23);
            txtDireccion.TabIndex = 24;
            txtDireccion.Validating += txtDireccion_Validating;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(198, 194);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 23;
            lblDireccion.Text = "Dirección";
            // 
            // txtNumeroCuentaCorriente
            // 
            txtNumeroCuentaCorriente.Location = new Point(262, 313);
            txtNumeroCuentaCorriente.Name = "txtNumeroCuentaCorriente";
            txtNumeroCuentaCorriente.Size = new Size(342, 23);
            txtNumeroCuentaCorriente.TabIndex = 22;
            txtNumeroCuentaCorriente.Validating += txtNumeroCuentaCorriente_Validating;
            // 
            // lblNumeroCuentaCorriente
            // 
            lblNumeroCuentaCorriente.AutoSize = true;
            lblNumeroCuentaCorriente.Location = new Point(115, 316);
            lblNumeroCuentaCorriente.Name = "lblNumeroCuentaCorriente";
            lblNumeroCuentaCorriente.Size = new Size(140, 15);
            lblNumeroCuentaCorriente.TabIndex = 21;
            lblNumeroCuentaCorriente.Text = "Número cuenta corriente";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(262, 232);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(342, 23);
            txtEdad.TabIndex = 20;
            txtEdad.Validating += txtEdad_Validating;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(222, 235);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 19;
            lblEdad.Text = "Edad";
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificar.Location = new Point(330, 35);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(215, 37);
            lblModificar.TabIndex = 18;
            lblModificar.Text = "Modificar cliente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(222, 117);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(314, 382);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(649, 114);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(121, 23);
            btnSeleccionar.TabIndex = 30;
            btnSeleccionar.Text = "Seleccionar cliente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(262, 115);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(342, 23);
            cmbClientes.TabIndex = 31;
            cmbClientes.Validating += cmbClientes_Validating;
            // 
            // errDni
            // 
            errDni.ContainerControl = this;
            // 
            // errNombre
            // 
            errNombre.ContainerControl = this;
            // 
            // errDireccion
            // 
            errDireccion.ContainerControl = this;
            // 
            // errEdad
            // 
            errEdad.ContainerControl = this;
            // 
            // errTelefono
            // 
            errTelefono.ContainerControl = this;
            // 
            // errNumeroCuentaCorriente
            // 
            errNumeroCuentaCorriente.ContainerControl = this;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbClientes);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
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
            Controls.Add(lblModificar);
            Controls.Add(lblDni);
            Controls.Add(btnConfirmar);
            Name = "FormModificar";
            Text = "FormModificar";
            ((System.ComponentModel.ISupportInitialize)errDni).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDireccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNumeroCuentaCorriente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
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
        private Label lblModificar;
        private Label lblDni;
        private Button btnConfirmar;
        private Button btnSeleccionar;
        private ComboBox cmbClientes;
        private ErrorProvider errDni;
        private ErrorProvider errNombre;
        private ErrorProvider errDireccion;
        private ErrorProvider errEdad;
        private ErrorProvider errTelefono;
        private ErrorProvider errNumeroCuentaCorriente;
    }
}