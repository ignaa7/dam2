namespace Examen2IgnacioFernandezSanchez
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
            btnCrear = new Button();
            btnAgregar = new Button();
            btnExportar = new Button();
            btnVer = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(86, 49);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(146, 68);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear proyecto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(539, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar tarea";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(539, 221);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 68);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar proyecto";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(86, 221);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(146, 68);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver proyecto";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(314, 333);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(146, 68);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVer);
            Controls.Add(btnExportar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCrear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnAgregar;
        private Button btnExportar;
        private Button btnVer;
        private Button btnSalir;
    }
}