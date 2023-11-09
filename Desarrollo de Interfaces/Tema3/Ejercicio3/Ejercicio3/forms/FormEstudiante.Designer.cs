namespace AdminIES.forms
{
    partial class FormEstudiante
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
            pbImagen = new PictureBox();
            lblClave = new Label();
            lblNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            lblCorreo = new Label();
            lblCiclo = new Label();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtCorreo = new TextBox();
            cmbCiclo = new ComboBox();
            btnExaminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dgvEstudiante = new DataGridView();
            errNombre = new ErrorProvider(components);
            errPrimerApellido = new ErrorProvider(components);
            errSegundoApellido = new ErrorProvider(components);
            errCorreo = new ErrorProvider(components);
            errCiclo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPrimerApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSegundoApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errCiclo).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(29, 26);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(146, 202);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(235, 26);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(390, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(235, 79);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(89, 15);
            lblPrimerApellido.TabIndex = 3;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(508, 79);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 4;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(235, 125);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // lblCiclo
            // 
            lblCiclo.AutoSize = true;
            lblCiclo.Location = new Point(235, 182);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(34, 15);
            lblCiclo.TabIndex = 6;
            lblCiclo.Text = "Ciclo";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(235, 44);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(121, 23);
            txtClave.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(390, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(386, 23);
            txtNombre.TabIndex = 8;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(508, 97);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(268, 23);
            txtSegundoApellido.TabIndex = 9;
            txtSegundoApellido.Validating += txtSegundoApellido_Validating;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(235, 97);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(238, 23);
            txtPrimerApellido.TabIndex = 10;
            txtPrimerApellido.Validating += txtPrimerApellido_Validating;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(235, 147);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(541, 23);
            txtCorreo.TabIndex = 11;
            txtCorreo.Validating += txtCorreo_Validating;
            // 
            // cmbCiclo
            // 
            cmbCiclo.FormattingEnabled = true;
            cmbCiclo.Location = new Point(235, 200);
            cmbCiclo.Name = "cmbCiclo";
            cmbCiclo.Size = new Size(541, 23);
            cmbCiclo.TabIndex = 13;
            cmbCiclo.Validating += cmbCiclo_Validating;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(29, 253);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(146, 23);
            btnExaminar.TabIndex = 14;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(265, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(376, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(488, 253);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(601, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(29, 288);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.RowTemplate.Height = 25;
            dgvEstudiante.Size = new Size(747, 150);
            dgvEstudiante.TabIndex = 19;
            // 
            // errNombre
            // 
            errNombre.ContainerControl = this;
            // 
            // errPrimerApellido
            // 
            errPrimerApellido.ContainerControl = this;
            // 
            // errSegundoApellido
            // 
            errSegundoApellido.ContainerControl = this;
            // 
            // errCorreo
            // 
            errCorreo.ContainerControl = this;
            // 
            // errCiclo
            // 
            errCiclo.ContainerControl = this;
            // 
            // FormEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstudiante);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnExaminar);
            Controls.Add(cmbCiclo);
            Controls.Add(txtCorreo);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(lblCiclo);
            Controls.Add(lblCorreo);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblClave);
            Controls.Add(pbImagen);
            Name = "FormEstudiante";
            Text = "FormEstudiante";
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPrimerApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSegundoApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)errCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errCiclo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        private Label lblClave;
        private Label lblNombre;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private Label lblCorreo;
        private Label lblCiclo;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtCorreo;
        private ComboBox cmbCiclo;
        private Button btnExaminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dgvEstudiante;
        private ErrorProvider errNombre;
        private ErrorProvider errPrimerApellido;
        private ErrorProvider errSegundoApellido;
        private ErrorProvider errCorreo;
        private ErrorProvider errCiclo;
    }
}