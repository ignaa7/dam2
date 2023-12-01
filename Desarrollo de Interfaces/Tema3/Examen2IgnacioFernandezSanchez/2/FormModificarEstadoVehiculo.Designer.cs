namespace _2
{
    partial class FormModificarEstadoVehiculo
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
            label1 = new Label();
            txtEstado = new TextBox();
            btnModificar = new Button();
            errEstado = new ErrorProvider(components);
            lblId = new Label();
            txtId = new TextBox();
            errId = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 114);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(330, 111);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 1;
            txtEstado.Validating += txtEstado_Validating;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(271, 180);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(168, 78);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // errEstado
            // 
            errEstado.ContainerControl = this;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(286, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(330, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Validating += txtId_Validating;
            // 
            // errId
            // 
            errId.ContainerControl = this;
            // 
            // FormModificarEstadoVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnModificar);
            Controls.Add(txtEstado);
            Controls.Add(label1);
            Name = "FormModificarEstadoVehiculo";
            Text = "FormModificarEstadoVehiculo";
            ((System.ComponentModel.ISupportInitialize)errEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)errId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEstado;
        private Button btnModificar;
        private ErrorProvider errEstado;
        private TextBox txtId;
        private Label lblId;
        private ErrorProvider errId;
    }
}