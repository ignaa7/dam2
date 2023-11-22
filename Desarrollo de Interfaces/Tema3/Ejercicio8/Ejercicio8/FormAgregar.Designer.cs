namespace Ejercicio8
{
    partial class FormAgregar
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
            btnConfirmar = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblAgregar = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNumeroCuentaCorriente = new TextBox();
            lblNumeroCuentaCorriente = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            btnCancelar = new Button();
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
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(272, 376);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(180, 111);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(220, 108);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(342, 23);
            txtDni.TabIndex = 2;
            txtDni.Validating += txtDni_Validating;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgregar.Location = new Point(288, 29);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(197, 37);
            lblAgregar.TabIndex = 3;
            lblAgregar.Text = "Agregar cliente";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(220, 226);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(342, 23);
            txtEdad.TabIndex = 5;
            txtEdad.Validating += txtEdad_Validating;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(180, 229);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtNumeroCuentaCorriente
            // 
            txtNumeroCuentaCorriente.Location = new Point(220, 307);
            txtNumeroCuentaCorriente.Name = "txtNumeroCuentaCorriente";
            txtNumeroCuentaCorriente.Size = new Size(342, 23);
            txtNumeroCuentaCorriente.TabIndex = 7;
            txtNumeroCuentaCorriente.Validating += txtNumeroCuentaCorriente_Validating;
            // 
            // lblNumeroCuentaCorriente
            // 
            lblNumeroCuentaCorriente.AutoSize = true;
            lblNumeroCuentaCorriente.Location = new Point(73, 310);
            lblNumeroCuentaCorriente.Name = "lblNumeroCuentaCorriente";
            lblNumeroCuentaCorriente.Size = new Size(140, 15);
            lblNumeroCuentaCorriente.TabIndex = 6;
            lblNumeroCuentaCorriente.Text = "Número cuenta corriente";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(220, 185);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(342, 23);
            txtDireccion.TabIndex = 9;
            txtDireccion.Validating += txtDireccion_Validating;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(156, 188);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(342, 23);
            txtNombre.TabIndex = 11;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(156, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(220, 266);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 23);
            txtTelefono.TabIndex = 13;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(161, 269);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(426, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(lblAgregar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnConfirmar);
            Name = "FormAgregar";
            Text = "FormAgregar";
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

        private Button btnConfirmar;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblAgregar;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtNumeroCuentaCorriente;
        private Label lblNumeroCuentaCorriente;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Button btnCancelar;
        private ErrorProvider errDni;
        private ErrorProvider errNombre;
        private ErrorProvider errDireccion;
        private ErrorProvider errEdad;
        private ErrorProvider errTelefono;
        private ErrorProvider errNumeroCuentaCorriente;
    }
}