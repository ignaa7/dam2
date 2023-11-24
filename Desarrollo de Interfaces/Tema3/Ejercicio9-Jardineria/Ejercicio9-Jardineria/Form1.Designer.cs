namespace Ejercicio9_Jardineria
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
            btnAgregarProducto = new Button();
            btnEliminarGama = new Button();
            btnConsultarPedidosEntregados = new Button();
            btnConsultarEmpleadosJefe = new Button();
            btnConsultarClientesNoPagan = new Button();
            btnConsultarPrecioCaroBarato = new Button();
            SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(130, 44);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(214, 65);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Añadir producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarGama
            // 
            btnEliminarGama.Location = new Point(465, 44);
            btnEliminarGama.Name = "btnEliminarGama";
            btnEliminarGama.Size = new Size(214, 65);
            btnEliminarGama.TabIndex = 1;
            btnEliminarGama.Text = "Eliminar gama";
            btnEliminarGama.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPedidosEntregados
            // 
            btnConsultarPedidosEntregados.Location = new Point(130, 185);
            btnConsultarPedidosEntregados.Name = "btnConsultarPedidosEntregados";
            btnConsultarPedidosEntregados.Size = new Size(214, 65);
            btnConsultarPedidosEntregados.TabIndex = 2;
            btnConsultarPedidosEntregados.Text = "Consultar pedidos entregados";
            btnConsultarPedidosEntregados.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEmpleadosJefe
            // 
            btnConsultarEmpleadosJefe.Location = new Point(465, 185);
            btnConsultarEmpleadosJefe.Name = "btnConsultarEmpleadosJefe";
            btnConsultarEmpleadosJefe.Size = new Size(214, 65);
            btnConsultarEmpleadosJefe.TabIndex = 3;
            btnConsultarEmpleadosJefe.Text = "Consultar empleados de un jefe determinado";
            btnConsultarEmpleadosJefe.UseVisualStyleBackColor = true;
            // 
            // btnConsultarClientesNoPagan
            // 
            btnConsultarClientesNoPagan.Location = new Point(130, 324);
            btnConsultarClientesNoPagan.Name = "btnConsultarClientesNoPagan";
            btnConsultarClientesNoPagan.Size = new Size(214, 65);
            btnConsultarClientesNoPagan.TabIndex = 4;
            btnConsultarClientesNoPagan.Text = "Consultar clientes que no pagan";
            btnConsultarClientesNoPagan.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPrecioCaroBarato
            // 
            btnConsultarPrecioCaroBarato.Location = new Point(465, 324);
            btnConsultarPrecioCaroBarato.Name = "btnConsultarPrecioCaroBarato";
            btnConsultarPrecioCaroBarato.Size = new Size(214, 65);
            btnConsultarPrecioCaroBarato.TabIndex = 5;
            btnConsultarPrecioCaroBarato.Text = "Consultar precio del producto más caro y más barato";
            btnConsultarPrecioCaroBarato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarPrecioCaroBarato);
            Controls.Add(btnConsultarClientesNoPagan);
            Controls.Add(btnConsultarEmpleadosJefe);
            Controls.Add(btnConsultarPedidosEntregados);
            Controls.Add(btnEliminarGama);
            Controls.Add(btnAgregarProducto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProducto;
        private Button btnEliminarGama;
        private Button btnConsultarPedidosEntregados;
        private Button btnConsultarEmpleadosJefe;
        private Button btnConsultarClientesNoPagan;
        private Button btnConsultarPrecioCaroBarato;
    }
}