namespace Ejercicio8
{
    partial class FormModificar
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
            btnCancelar = new Button();
            textBox6 = new TextBox();
            lblTelefono = new Label();
            textBox5 = new TextBox();
            lblNombre = new Label();
            textBox4 = new TextBox();
            lblDireccion = new Label();
            textBox3 = new TextBox();
            lblNumeroCuentaCorriente = new Label();
            textBox2 = new TextBox();
            lblEdad = new Label();
            lblModificar = new Label();
            textBox1 = new TextBox();
            lblDni = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(468, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(262, 272);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(342, 23);
            textBox6.TabIndex = 28;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(203, 275);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Teléfono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(342, 23);
            textBox5.TabIndex = 26;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(198, 157);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 23);
            textBox4.TabIndex = 24;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(198, 194);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 23;
            lblDireccion.Text = "Dirección";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 313);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 23);
            textBox3.TabIndex = 22;
            // 
            // lblNumeroCuentaCorriente
            // 
            lblNumeroCuentaCorriente.AutoSize = true;
            lblNumeroCuentaCorriente.Location = new Point(115, 316);
            lblNumeroCuentaCorriente.Name = "lblNumeroCuentaCorriente";
            lblNumeroCuentaCorriente.Size = new Size(140, 15);
            lblNumeroCuentaCorriente.TabIndex = 21;
            lblNumeroCuentaCorriente.Text = "Número cuenta corriente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 20;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(222, 235);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 19;
            lblEdad.Text = "Edad";
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificar.Location = new Point(330, 35);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(208, 37);
            lblModificar.TabIndex = 18;
            lblModificar.Text = "Modificar ciente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 17;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(222, 117);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(314, 382);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(textBox6);
            Controls.Add(lblTelefono);
            Controls.Add(textBox5);
            Controls.Add(lblNombre);
            Controls.Add(textBox4);
            Controls.Add(lblDireccion);
            Controls.Add(textBox3);
            Controls.Add(lblNumeroCuentaCorriente);
            Controls.Add(textBox2);
            Controls.Add(lblEdad);
            Controls.Add(lblModificar);
            Controls.Add(textBox1);
            Controls.Add(lblDni);
            Controls.Add(btnConfirmar);
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox textBox6;
        private Label lblTelefono;
        private TextBox textBox5;
        private Label lblNombre;
        private TextBox textBox4;
        private Label lblDireccion;
        private TextBox textBox3;
        private Label lblNumeroCuentaCorriente;
        private TextBox textBox2;
        private Label lblEdad;
        private Label lblModificar;
        private TextBox textBox1;
        private Label lblDni;
        private Button btnConfirmar;
    }
}