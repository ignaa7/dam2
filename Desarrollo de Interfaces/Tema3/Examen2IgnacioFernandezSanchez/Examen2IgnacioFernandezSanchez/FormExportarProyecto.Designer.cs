namespace Examen2IgnacioFernandezSanchez
{
    partial class FormExportarProyecto
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
            lblNombreProyecto = new Label();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Location = new Point(381, 153);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(100, 23);
            txtNombreProyecto.TabIndex = 0;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.AutoSize = true;
            lblNombreProyecto.Location = new Point(274, 156);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(101, 15);
            lblNombreProyecto.TabIndex = 1;
            lblNombreProyecto.Text = "Nombre proyecto";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(327, 221);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 50);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FormExportarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportar);
            Controls.Add(lblNombreProyecto);
            Controls.Add(txtNombreProyecto);
            Name = "FormExportarProyecto";
            Text = "FormExportarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProyecto;
        private Label lblNombreProyecto;
        private Button btnExportar;
    }
}