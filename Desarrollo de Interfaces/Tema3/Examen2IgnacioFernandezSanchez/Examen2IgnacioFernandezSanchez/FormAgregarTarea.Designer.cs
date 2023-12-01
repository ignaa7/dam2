namespace Examen2IgnacioFernandezSanchez
{
    partial class FormAgregarTarea
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
            txtNombreProyecto = new TextBox();
            txtNombreTarea = new TextBox();
            txtDescripcion = new TextBox();
            txtFechaVencimiento = new TextBox();
            lblNombreProyecto = new Label();
            lblNombreTarea = new Label();
            lblDescripcion = new Label();
            lblFechaVencimiento = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Location = new Point(380, 30);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(100, 23);
            txtNombreProyecto.TabIndex = 0;
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(380, 86);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(100, 23);
            txtNombreTarea.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(380, 146);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(380, 204);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(100, 23);
            txtFechaVencimiento.TabIndex = 3;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.AutoSize = true;
            lblNombreProyecto.Location = new Point(273, 33);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(101, 15);
            lblNombreProyecto.TabIndex = 4;
            lblNombreProyecto.Text = "Nombre proyecto";
            // 
            // lblNombreTarea
            // 
            lblNombreTarea.AutoSize = true;
            lblNombreTarea.Location = new Point(294, 89);
            lblNombreTarea.Name = "lblNombreTarea";
            lblNombreTarea.Size = new Size(80, 15);
            lblNombreTarea.TabIndex = 5;
            lblNombreTarea.Text = "Nombre tarea";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(305, 149);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(251, 207);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(123, 15);
            lblFechaVencimiento.TabIndex = 7;
            lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(380, 258);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(332, 261);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(353, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 45);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar tarea";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormAgregarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreTarea);
            Controls.Add(lblNombreProyecto);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreTarea);
            Controls.Add(txtNombreProyecto);
            Name = "FormAgregarTarea";
            Text = "FormAgregarTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProyecto;
        private TextBox txtNombreTarea;
        private TextBox txtDescripcion;
        private TextBox txtFechaVencimiento;
        private Label lblNombreProyecto;
        private Label lblNombreTarea;
        private Label lblDescripcion;
        private Label lblFechaVencimiento;
        private TextBox txtEstado;
        private Label lblEstado;
        private Button btnAgregar;
    }
}