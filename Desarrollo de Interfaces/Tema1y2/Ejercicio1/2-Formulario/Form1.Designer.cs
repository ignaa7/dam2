namespace _2_Formulario
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblSalario = new Label();
            txtNombre = new TextBox();
            txtSalario = new TextBox();
            rbtnGerente = new RadioButton();
            rbtnSubGerente = new RadioButton();
            rbtnSecretaria = new RadioButton();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(309, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Problema 1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(109, 168);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(461, 168);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 2;
            lblSalario.Text = "Salario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(509, 165);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(144, 23);
            txtSalario.TabIndex = 4;
            // 
            // rbtnGerente
            // 
            rbtnGerente.AutoSize = true;
            rbtnGerente.Location = new Point(83, 253);
            rbtnGerente.Name = "rbtnGerente";
            rbtnGerente.Size = new Size(66, 19);
            rbtnGerente.TabIndex = 5;
            rbtnGerente.TabStop = true;
            rbtnGerente.Text = "Gerente";
            rbtnGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSubGerente
            // 
            rbtnSubGerente.AutoSize = true;
            rbtnSubGerente.Location = new Point(336, 253);
            rbtnSubGerente.Name = "rbtnSubGerente";
            rbtnSubGerente.Size = new Size(86, 19);
            rbtnSubGerente.TabIndex = 6;
            rbtnSubGerente.TabStop = true;
            rbtnSubGerente.Text = "SubGerente";
            rbtnSubGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSecretaria
            // 
            rbtnSecretaria.AutoSize = true;
            rbtnSecretaria.Location = new Point(573, 253);
            rbtnSecretaria.Name = "rbtnSecretaria";
            rbtnSecretaria.Size = new Size(76, 19);
            rbtnSecretaria.TabIndex = 7;
            rbtnSecretaria.TabStop = true;
            rbtnSecretaria.Text = "Secretaria";
            rbtnSecretaria.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(290, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(201, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(rbtnSecretaria);
            Controls.Add(rbtnSubGerente);
            Controls.Add(rbtnGerente);
            Controls.Add(txtSalario);
            Controls.Add(txtNombre);
            Controls.Add(lblSalario);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblSalario;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private RadioButton rbtnGerente;
        private RadioButton rbtnSubGerente;
        private RadioButton rbtnSecretaria;
        private Button btnCalcular;
    }
}