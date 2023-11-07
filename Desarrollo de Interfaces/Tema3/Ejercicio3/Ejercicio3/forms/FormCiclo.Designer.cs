namespace AdminIES.forms
{
    partial class FormCiclo
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
            lblID = new Label();
            lblNombreCiclo = new Label();
            txtId = new TextBox();
            txtNombreCiclo = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dgvCiclos = new DataGridView();
            errNombreCiclo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCiclos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNombreCiclo).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(48, 26);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblNombreCiclo
            // 
            lblNombreCiclo.AutoSize = true;
            lblNombreCiclo.Location = new Point(256, 26);
            lblNombreCiclo.Name = "lblNombreCiclo";
            lblNombreCiclo.Size = new Size(81, 15);
            lblNombreCiclo.TabIndex = 1;
            lblNombreCiclo.Text = "Nombre Ciclo";
            // 
            // txtId
            // 
            txtId.Location = new Point(48, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 23);
            txtId.TabIndex = 2;
            // 
            // txtNombreCiclo
            // 
            txtNombreCiclo.Location = new Point(256, 44);
            txtNombreCiclo.Name = "txtNombreCiclo";
            txtNombreCiclo.Size = new Size(510, 23);
            txtNombreCiclo.TabIndex = 3;
            txtNombreCiclo.Validating += txtNombreCiclo_Validating;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(226, 98);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(417, 98);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(606, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvCiclos
            // 
            dgvCiclos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiclos.Location = new Point(48, 140);
            dgvCiclos.Name = "dgvCiclos";
            dgvCiclos.RowTemplate.Height = 25;
            dgvCiclos.Size = new Size(718, 298);
            dgvCiclos.TabIndex = 8;
            // 
            // errNombreCiclo
            // 
            errNombreCiclo.ContainerControl = this;
            // 
            // FormCiclo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCiclos);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreCiclo);
            Controls.Add(txtId);
            Controls.Add(lblNombreCiclo);
            Controls.Add(lblID);
            Name = "FormCiclo";
            Text = "FormCiclo";
            ((System.ComponentModel.ISupportInitialize)dgvCiclos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNombreCiclo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNombreCiclo;
        private TextBox txtId;
        private TextBox txtNombreCiclo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dgvCiclos;
        private ErrorProvider errNombreCiclo;
    }
}