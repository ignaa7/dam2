namespace Ejercicio9_Jardineria
{
    partial class FormAgregarProducto
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblGama = new Label();
            lblDimensiones = new Label();
            lblProveedor = new Label();
            lblDescripcion = new Label();
            lblCantidadStock = new Label();
            lblPrecioVenta = new Label();
            lblPrecioProveedor = new Label();
            btnConfirmar = new Button();
            txtNombre = new TextBox();
            txtDimensiones = new TextBox();
            txtProveedor = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidadStock = new TextBox();
            txtPrecioProveedor = new TextBox();
            cmbGama = new ComboBox();
            errCodigo = new ErrorProvider(components);
            errNombre = new ErrorProvider(components);
            errGama = new ErrorProvider(components);
            errCantidadStock = new ErrorProvider(components);
            errPrecioVenta = new ErrorProvider(components);
            errPrecioProveedor = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errGama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errCantidadStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPrecioProveedor).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(156, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.Validating += txtCodigo_Validating;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(96, 70);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(424, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblGama
            // 
            lblGama.AutoSize = true;
            lblGama.Location = new Point(104, 135);
            lblGama.Name = "lblGama";
            lblGama.Size = new Size(38, 15);
            lblGama.TabIndex = 3;
            lblGama.Text = "Gama";
            // 
            // lblDimensiones
            // 
            lblDimensiones.AutoSize = true;
            lblDimensiones.Location = new Point(400, 135);
            lblDimensiones.Name = "lblDimensiones";
            lblDimensiones.Size = new Size(75, 15);
            lblDimensiones.TabIndex = 4;
            lblDimensiones.Text = "Dimensiones";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(81, 206);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 5;
            lblProveedor.Text = "Proveedor";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(406, 206);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Location = new Point(40, 275);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(102, 15);
            lblCantidadStock.TabIndex = 7;
            lblCantidadStock.Text = "Cantidad en stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(387, 275);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(88, 15);
            lblPrecioVenta.TabIndex = 8;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // lblPrecioProveedor
            // 
            lblPrecioProveedor.AutoSize = true;
            lblPrecioProveedor.Location = new Point(26, 357);
            lblPrecioProveedor.Name = "lblPrecioProveedor";
            lblPrecioProveedor.Size = new Size(116, 15);
            lblPrecioProveedor.TabIndex = 9;
            lblPrecioProveedor.Text = "Precio del proveedor";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(497, 337);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(145, 54);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(484, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 11;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // txtDimensiones
            // 
            txtDimensiones.Location = new Point(484, 132);
            txtDimensiones.Name = "txtDimensiones";
            txtDimensiones.Size = new Size(188, 23);
            txtDimensiones.TabIndex = 12;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(156, 203);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(188, 23);
            txtProveedor.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(484, 203);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(188, 23);
            txtDescripcion.TabIndex = 15;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(484, 272);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(188, 23);
            txtPrecioVenta.TabIndex = 16;
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(156, 272);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(188, 23);
            txtCantidadStock.TabIndex = 17;
            // 
            // txtPrecioProveedor
            // 
            txtPrecioProveedor.Location = new Point(156, 354);
            txtPrecioProveedor.Name = "txtPrecioProveedor";
            txtPrecioProveedor.Size = new Size(188, 23);
            txtPrecioProveedor.TabIndex = 18;
            // 
            // cmbGama
            // 
            cmbGama.FormattingEnabled = true;
            cmbGama.Location = new Point(156, 132);
            cmbGama.Name = "cmbGama";
            cmbGama.Size = new Size(188, 23);
            cmbGama.TabIndex = 19;
            cmbGama.Validating += cmbGama_Validating;
            // 
            // errCodigo
            // 
            errCodigo.ContainerControl = this;
            // 
            // errNombre
            // 
            errNombre.ContainerControl = this;
            // 
            // errGama
            // 
            errGama.ContainerControl = this;
            // 
            // errCantidadStock
            // 
            errCantidadStock.ContainerControl = this;
            // 
            // errPrecioVenta
            // 
            errPrecioVenta.ContainerControl = this;
            // 
            // errPrecioProveedor
            // 
            errPrecioProveedor.ContainerControl = this;
            // 
            // FormAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbGama);
            Controls.Add(txtPrecioProveedor);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtDescripcion);
            Controls.Add(txtProveedor);
            Controls.Add(txtDimensiones);
            Controls.Add(txtNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(lblPrecioProveedor);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblCantidadStock);
            Controls.Add(lblDescripcion);
            Controls.Add(lblProveedor);
            Controls.Add(lblDimensiones);
            Controls.Add(lblGama);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "FormAgregarProducto";
            Text = "FormAgregarProducto";
            ((System.ComponentModel.ISupportInitialize)errCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errGama).EndInit();
            ((System.ComponentModel.ISupportInitialize)errCantidadStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPrecioProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblGama;
        private Label lblDimensiones;
        private Label lblProveedor;
        private Label lblDescripcion;
        private Label lblCantidadStock;
        private Label lblPrecioVenta;
        private Label lblPrecioProveedor;
        private Button btnConfirmar;
        private TextBox txtNombre;
        private TextBox txtDimensiones;
        private TextBox txtProveedor;
        private TextBox txtDescripcion;
        private TextBox txtPrecioVenta;
        private TextBox txtCantidadStock;
        private TextBox txtPrecioProveedor;
        private ComboBox cmbGama;
        private ErrorProvider errCodigo;
        private ErrorProvider errNombre;
        private ErrorProvider errGama;
        private ErrorProvider errCantidadStock;
        private ErrorProvider errPrecioVenta;
        private ErrorProvider errPrecioProveedor;
    }
}