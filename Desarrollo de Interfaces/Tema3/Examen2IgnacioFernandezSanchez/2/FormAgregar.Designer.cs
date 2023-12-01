namespace _2
{
    partial class FormAgregar
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
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            txtMatricula = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtAnoFabricacion = new TextBox();
            txtEstado = new TextBox();
            txtId = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            lblMatricula = new Label();
            lblAnoFabricacion = new Label();
            lblEstado = new Label();
            lblId = new Label();
            errId = new ErrorProvider(components);
            errMatricula = new ErrorProvider(components);
            errModelo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errMatricula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errModelo).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(366, 334);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 60);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar vehículo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(404, 97);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 24;
            txtMatricula.Validating += txtMatricula_Validating;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(404, 139);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 23;
            txtModelo.Validating += txtModelo_Validating;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(404, 182);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 22;
            // 
            // txtAnoFabricacion
            // 
            txtAnoFabricacion.Location = new Point(404, 222);
            txtAnoFabricacion.Name = "txtAnoFabricacion";
            txtAnoFabricacion.Size = new Size(100, 23);
            txtAnoFabricacion.TabIndex = 21;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(404, 262);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(404, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 19;
            txtId.Validating += txtId_Validating;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(322, 185);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(322, 142);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 17;
            lblModelo.Text = "Modelo";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(322, 100);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 16;
            lblMatricula.Text = "Matrícula";
            // 
            // lblAnoFabricacion
            // 
            lblAnoFabricacion.AutoSize = true;
            lblAnoFabricacion.Location = new Point(286, 225);
            lblAnoFabricacion.Name = "lblAnoFabricacion";
            lblAnoFabricacion.Size = new Size(93, 15);
            lblAnoFabricacion.TabIndex = 15;
            lblAnoFabricacion.Text = "Año Fabricación";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(322, 265);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(322, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 13;
            lblId.Text = "Id";
            // 
            // errId
            // 
            errId.ContainerControl = this;
            // 
            // errMatricula
            // 
            errMatricula.ContainerControl = this;
            // 
            // errModelo
            // 
            errModelo.ContainerControl = this;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtMatricula);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtAnoFabricacion);
            Controls.Add(txtEstado);
            Controls.Add(txtId);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblMatricula);
            Controls.Add(lblAnoFabricacion);
            Controls.Add(lblEstado);
            Controls.Add(lblId);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)errId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errMatricula).EndInit();
            ((System.ComponentModel.ISupportInitialize)errModelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtMatricula;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtAnoFabricacion;
        private TextBox txtEstado;
        private TextBox txtId;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblMatricula;
        private Label lblAnoFabricacion;
        private Label lblEstado;
        private Label lblId;
        private ErrorProvider errId;
        private ErrorProvider errMatricula;
        private ErrorProvider errModelo;
    }
}