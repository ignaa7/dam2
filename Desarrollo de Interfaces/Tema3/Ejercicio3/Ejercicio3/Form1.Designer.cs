namespace Ejercicio3
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
            btnCiclos = new Button();
            btnEstudiantes = new Button();
            SuspendLayout();
            // 
            // btnCiclos
            // 
            btnCiclos.Location = new Point(98, 123);
            btnCiclos.Name = "btnCiclos";
            btnCiclos.Size = new Size(231, 152);
            btnCiclos.TabIndex = 0;
            btnCiclos.Text = "Ciclos";
            btnCiclos.UseVisualStyleBackColor = true;
            btnCiclos.Click += btnCiclos_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Location = new Point(471, 123);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(231, 152);
            btnEstudiantes.TabIndex = 1;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstudiantes);
            Controls.Add(btnCiclos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCiclos;
        private Button btnEstudiantes;
    }
}