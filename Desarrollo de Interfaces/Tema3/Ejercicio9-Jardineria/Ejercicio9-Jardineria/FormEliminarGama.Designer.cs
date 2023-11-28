namespace Ejercicio9_Jardineria
{
    partial class FormEliminarGama
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
            cbGamas = new ComboBox();
            lblGama = new Label();
            lblDescripcionTexto = new Label();
            lblDescripcionHtml = new Label();
            lblImagen = new Label();
            lblGamaDato = new Label();
            lblDescripcionTextoDato = new Label();
            lblDescripcionHtmlDato = new Label();
            lblImagenDato = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbGamas
            // 
            cbGamas.FormattingEnabled = true;
            cbGamas.Location = new Point(353, 56);
            cbGamas.Name = "cbGamas";
            cbGamas.Size = new Size(121, 23);
            cbGamas.TabIndex = 0;
            cbGamas.SelectedIndexChanged += cbGamas_SelectedIndexChanged;
            // 
            // lblGama
            // 
            lblGama.AutoSize = true;
            lblGama.Location = new Point(154, 132);
            lblGama.Name = "lblGama";
            lblGama.Size = new Size(38, 15);
            lblGama.TabIndex = 1;
            lblGama.Text = "Gama";
            // 
            // lblDescripcionTexto
            // 
            lblDescripcionTexto.AutoSize = true;
            lblDescripcionTexto.Location = new Point(516, 132);
            lblDescripcionTexto.Name = "lblDescripcionTexto";
            lblDescripcionTexto.Size = new Size(99, 15);
            lblDescripcionTexto.TabIndex = 2;
            lblDescripcionTexto.Text = "Descripción texto";
            // 
            // lblDescripcionHtml
            // 
            lblDescripcionHtml.AutoSize = true;
            lblDescripcionHtml.Location = new Point(154, 261);
            lblDescripcionHtml.Name = "lblDescripcionHtml";
            lblDescripcionHtml.Size = new Size(104, 15);
            lblDescripcionHtml.TabIndex = 3;
            lblDescripcionHtml.Text = "Descripción HTML";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(516, 261);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(47, 15);
            lblImagen.TabIndex = 4;
            lblImagen.Text = "Imagen";
            // 
            // lblGamaDato
            // 
            lblGamaDato.AutoSize = true;
            lblGamaDato.Location = new Point(154, 169);
            lblGamaDato.Name = "lblGamaDato";
            lblGamaDato.Size = new Size(0, 15);
            lblGamaDato.TabIndex = 5;
            // 
            // lblDescripcionTextoDato
            // 
            lblDescripcionTextoDato.AutoSize = true;
            lblDescripcionTextoDato.Location = new Point(516, 169);
            lblDescripcionTextoDato.Name = "lblDescripcionTextoDato";
            lblDescripcionTextoDato.Size = new Size(0, 15);
            lblDescripcionTextoDato.TabIndex = 6;
            // 
            // lblDescripcionHtmlDato
            // 
            lblDescripcionHtmlDato.AutoSize = true;
            lblDescripcionHtmlDato.Location = new Point(154, 297);
            lblDescripcionHtmlDato.Name = "lblDescripcionHtmlDato";
            lblDescripcionHtmlDato.Size = new Size(0, 15);
            lblDescripcionHtmlDato.TabIndex = 7;
            // 
            // lblImagenDato
            // 
            lblImagenDato.AutoSize = true;
            lblImagenDato.Location = new Point(516, 297);
            lblImagenDato.Name = "lblImagenDato";
            lblImagenDato.Size = new Size(0, 15);
            lblImagenDato.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(285, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 47);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(452, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 47);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEliminarGama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(lblImagenDato);
            Controls.Add(lblDescripcionHtmlDato);
            Controls.Add(lblDescripcionTextoDato);
            Controls.Add(lblGamaDato);
            Controls.Add(lblImagen);
            Controls.Add(lblDescripcionHtml);
            Controls.Add(lblDescripcionTexto);
            Controls.Add(lblGama);
            Controls.Add(cbGamas);
            Name = "FormEliminarGama";
            Text = "FormEliminarGama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGamas;
        private Label lblGama;
        private Label lblDescripcionTexto;
        private Label lblDescripcionHtml;
        private Label lblImagen;
        private Label lblGamaDato;
        private Label lblDescripcionTextoDato;
        private Label lblDescripcionHtmlDato;
        private Label lblImagenDato;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}