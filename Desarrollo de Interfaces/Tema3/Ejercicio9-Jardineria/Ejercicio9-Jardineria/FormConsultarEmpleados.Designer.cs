namespace Ejercicio9_Jardineria
{
    partial class FormConsultarEmpleados
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
            cbCodigosJefes = new ComboBox();
            btnBuscar = new Button();
            lblCodigoJefe = new Label();
            lblEmpleados = new Label();
            SuspendLayout();
            // 
            // cbCodigosJefes
            // 
            cbCodigosJefes.FormattingEnabled = true;
            cbCodigosJefes.Location = new Point(272, 48);
            cbCodigosJefes.Name = "cbCodigosJefes";
            cbCodigosJefes.Size = new Size(121, 23);
            cbCodigosJefes.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(441, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCodigoJefe
            // 
            lblCodigoJefe.AutoSize = true;
            lblCodigoJefe.Location = new Point(164, 51);
            lblCodigoJefe.Name = "lblCodigoJefe";
            lblCodigoJefe.Size = new Size(87, 15);
            lblCodigoJefe.TabIndex = 2;
            lblCodigoJefe.Text = "Código del jefe";
            // 
            // lblEmpleados
            // 
            lblEmpleados.Location = new Point(12, 97);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(776, 344);
            lblEmpleados.TabIndex = 3;
            // 
            // FormConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmpleados);
            Controls.Add(lblCodigoJefe);
            Controls.Add(btnBuscar);
            Controls.Add(cbCodigosJefes);
            Name = "FormConsultarEmpleados";
            Text = "FormConsultarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCodigosJefes;
        private Button btnBuscar;
        private Label lblCodigoJefe;
        private Label lblEmpleados;
    }
}