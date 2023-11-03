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
            lblID = new Label();
            lblNombreCiclo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dgvCiclos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCiclos).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(48, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(510, 23);
            textBox2.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(226, 98);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(417, 98);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(606, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNombreCiclo);
            Controls.Add(lblID);
            Name = "FormCiclo";
            Text = "FormCiclo";
            ((System.ComponentModel.ISupportInitialize)dgvCiclos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNombreCiclo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dgvCiclos;
    }
}