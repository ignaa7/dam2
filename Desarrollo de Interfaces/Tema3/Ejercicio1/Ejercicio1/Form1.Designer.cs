namespace Ejercicio1
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
            lblCadena = new Label();
            lblCaracter = new Label();
            lblResultado = new Label();
            txtCadena = new TextBox();
            txtResultado = new TextBox();
            cmbCaracter = new ComboBox();
            btnContar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Location = new Point(97, 81);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(54, 15);
            lblCadena.TabIndex = 0;
            lblCadena.Text = "CADENA";
            // 
            // lblCaracter
            // 
            lblCaracter.AutoSize = true;
            lblCaracter.Location = new Point(97, 122);
            lblCaracter.Name = "lblCaracter";
            lblCaracter.Size = new Size(65, 15);
            lblCaracter.TabIndex = 1;
            lblCaracter.Text = "CARACTER";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(97, 239);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "RESULTADO";
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(202, 78);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(546, 23);
            txtCadena.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(202, 236);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(546, 202);
            txtResultado.TabIndex = 4;
            // 
            // cmbCaracter
            // 
            cmbCaracter.FormattingEnabled = true;
            cmbCaracter.Location = new Point(202, 119);
            cmbCaracter.Name = "cmbCaracter";
            cmbCaracter.Size = new Size(546, 23);
            cmbCaracter.TabIndex = 5;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(345, 180);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(75, 23);
            btnContar.TabIndex = 6;
            btnContar.Text = "CONTAR";
            btnContar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(533, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnContar);
            Controls.Add(cmbCaracter);
            Controls.Add(txtResultado);
            Controls.Add(txtCadena);
            Controls.Add(lblResultado);
            Controls.Add(lblCaracter);
            Controls.Add(lblCadena);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadena;
        private Label lblCaracter;
        private Label lblResultado;
        private TextBox txtCadena;
        private TextBox txtResultado;
        private ComboBox cmbCaracter;
        private Button btnContar;
        private Button btnEliminar;
    }
}