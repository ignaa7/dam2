namespace _2
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
            btnAgregarVehiculo = new Button();
            btnModificarEstadoVehiculo = new Button();
            btnVisualizarInventarioVehiculos = new Button();
            btnAgregarMantenimiento = new Button();
            btnVisualizarMantenimientos = new Button();
            SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(197, 93);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(131, 53);
            btnAgregarVehiculo.TabIndex = 0;
            btnAgregarVehiculo.Text = "Agregar vehículo";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            btnAgregarVehiculo.Click += btnAgregarVehiculo_Click;
            // 
            // btnModificarEstadoVehiculo
            // 
            btnModificarEstadoVehiculo.Location = new Point(427, 90);
            btnModificarEstadoVehiculo.Name = "btnModificarEstadoVehiculo";
            btnModificarEstadoVehiculo.Size = new Size(146, 58);
            btnModificarEstadoVehiculo.TabIndex = 1;
            btnModificarEstadoVehiculo.Text = "Modificar estado de vehículo";
            btnModificarEstadoVehiculo.UseVisualStyleBackColor = true;
            btnModificarEstadoVehiculo.Click += btnModificarEstadoVehiculo_Click;
            // 
            // btnVisualizarInventarioVehiculos
            // 
            btnVisualizarInventarioVehiculos.Location = new Point(197, 231);
            btnVisualizarInventarioVehiculos.Name = "btnVisualizarInventarioVehiculos";
            btnVisualizarInventarioVehiculos.Size = new Size(134, 58);
            btnVisualizarInventarioVehiculos.TabIndex = 2;
            btnVisualizarInventarioVehiculos.Text = "Visualizar inventario de vehículos";
            btnVisualizarInventarioVehiculos.UseVisualStyleBackColor = true;
            btnVisualizarInventarioVehiculos.Click += btnVisualizarInventarioVehiculos_Click;
            // 
            // btnAgregarMantenimiento
            // 
            btnAgregarMantenimiento.Location = new Point(433, 231);
            btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            btnAgregarMantenimiento.Size = new Size(140, 60);
            btnAgregarMantenimiento.TabIndex = 3;
            btnAgregarMantenimiento.Text = "Agregar mantenimiento";
            btnAgregarMantenimiento.UseVisualStyleBackColor = true;
            btnAgregarMantenimiento.Click += btnAgregarMantenimiento_Click;
            // 
            // btnVisualizarMantenimientos
            // 
            btnVisualizarMantenimientos.Location = new Point(324, 346);
            btnVisualizarMantenimientos.Name = "btnVisualizarMantenimientos";
            btnVisualizarMantenimientos.Size = new Size(141, 64);
            btnVisualizarMantenimientos.TabIndex = 4;
            btnVisualizarMantenimientos.Text = "Visualizar mantenimientos";
            btnVisualizarMantenimientos.UseVisualStyleBackColor = true;
            btnVisualizarMantenimientos.Click += btnVisualizarMantenimientos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualizarMantenimientos);
            Controls.Add(btnAgregarMantenimiento);
            Controls.Add(btnVisualizarInventarioVehiculos);
            Controls.Add(btnModificarEstadoVehiculo);
            Controls.Add(btnAgregarVehiculo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarVehiculo;
        private Button btnModificarEstadoVehiculo;
        private Button btnVisualizarInventarioVehiculos;
        private Button btnAgregarMantenimiento;
        private Button btnVisualizarMantenimientos;
    }
}