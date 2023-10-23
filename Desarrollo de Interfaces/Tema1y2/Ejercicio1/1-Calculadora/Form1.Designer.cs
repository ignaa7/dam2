namespace Prueba
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblTitulo = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            rbtnBasicas = new RadioButton();
            rbtnAvanzadas = new RadioButton();
            cmbBasicas = new ComboBox();
            lstAvanzadas = new ListBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(90, 145);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(90, 233);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Número 2";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(325, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Calculadora";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(197, 142);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(197, 230);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // rbtnBasicas
            // 
            rbtnBasicas.AutoSize = true;
            rbtnBasicas.Location = new Point(436, 126);
            rbtnBasicas.Name = "rbtnBasicas";
            rbtnBasicas.Size = new Size(63, 19);
            rbtnBasicas.TabIndex = 5;
            rbtnBasicas.TabStop = true;
            rbtnBasicas.Text = "Básicas";
            rbtnBasicas.UseVisualStyleBackColor = true;
            rbtnBasicas.CheckedChanged += rbtnBasicas_CheckedChanged;
            // 
            // rbtnAvanzadas
            // 
            rbtnAvanzadas.AutoSize = true;
            rbtnAvanzadas.Location = new Point(606, 126);
            rbtnAvanzadas.Name = "rbtnAvanzadas";
            rbtnAvanzadas.Size = new Size(81, 19);
            rbtnAvanzadas.TabIndex = 6;
            rbtnAvanzadas.TabStop = true;
            rbtnAvanzadas.Text = "Avanzadas";
            rbtnAvanzadas.UseVisualStyleBackColor = true;
            rbtnAvanzadas.CheckedChanged += rbtnAvanzadas_CheckedChanged;
            // 
            // cmbBasicas
            // 
            cmbBasicas.FormattingEnabled = true;
            cmbBasicas.Items.AddRange(new object[] { "Suma", "Resta" });
            cmbBasicas.Location = new Point(405, 172);
            cmbBasicas.Name = "cmbBasicas";
            cmbBasicas.Size = new Size(121, 23);
            cmbBasicas.TabIndex = 7;
            // 
            // lstAvanzadas
            // 
            lstAvanzadas.FormattingEnabled = true;
            lstAvanzadas.ItemHeight = 15;
            lstAvanzadas.Items.AddRange(new object[] { "Multiplicación", "División" });
            lstAvanzadas.Location = new Point(586, 172);
            lstAvanzadas.Name = "lstAvanzadas";
            lstAvanzadas.Size = new Size(120, 94);
            lstAvanzadas.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(371, 324);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
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
            Controls.Add(lstAvanzadas);
            Controls.Add(cmbBasicas);
            Controls.Add(rbtnAvanzadas);
            Controls.Add(rbtnBasicas);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblTitulo);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblTitulo;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private RadioButton rbtnBasicas;
        private RadioButton rbtnAvanzadas;
        private ComboBox cmbBasicas;
        private ListBox lstAvanzadas;
        private Button btnCalcular;
    }
}