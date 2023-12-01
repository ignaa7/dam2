namespace Examen2IgnacioFernandezSanchez
{
    partial class FormCrearProyecto
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtFechaInicio = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblFechaInicio = new Label();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(339, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(339, 153);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(339, 239);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(100, 23);
            txtFechaInicio.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(198, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(198, 156);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(198, 242);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 15);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(320, 335);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(130, 46);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear proyecto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormCrearProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "FormCrearProyecto";
            Text = "FormCrearProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtFechaInicio;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblFechaInicio;
        private Button btnCrear;
    }
}