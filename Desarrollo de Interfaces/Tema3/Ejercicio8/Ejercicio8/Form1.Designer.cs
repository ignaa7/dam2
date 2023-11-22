namespace Ejercicio8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(142, 99);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(165, 56);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(493, 99);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 56);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar cliente";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(142, 272);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 56);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(493, 272);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(165, 56);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar cliente";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnMostrar;
    }
}