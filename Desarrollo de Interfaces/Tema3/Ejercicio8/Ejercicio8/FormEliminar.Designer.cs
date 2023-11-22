namespace Ejercicio8
{
    partial class FormEliminar
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
            btnCancelar = new Button();
            lblEliminar = new Label();
            lblDni = new Label();
            btnConfirmar = new Button();
            cmbClientes = new ComboBox();
            errDni = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errDni).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(523, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEliminar.Location = new Point(371, 40);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(198, 37);
            lblEliminar.TabIndex = 33;
            lblEliminar.Text = "Eliminar cliente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(263, 122);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 31;
            lblDni.Text = "DNI";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(359, 195);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 30;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(303, 119);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(342, 23);
            cmbClientes.TabIndex = 45;
            cmbClientes.Validating += cmbClientes_Validating;
            // 
            // errDni
            // 
            errDni.ContainerControl = this;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbClientes);
            Controls.Add(btnCancelar);
            Controls.Add(lblEliminar);
            Controls.Add(lblDni);
            Controls.Add(btnConfirmar);
            Name = "FormEliminar";
            Text = "FormEliminar";
            ((System.ComponentModel.ISupportInitialize)errDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label lblEliminar;
        private Label lblDni;
        private Button btnConfirmar;
        private ComboBox cmbClientes;
        private ErrorProvider errDni;
    }
}