namespace Ejercicio9_Jardineria
{
    partial class FormConsultarProductosEntregados
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
            cbMeses = new ComboBox();
            lblMes = new Label();
            btnBuscar = new Button();
            dgvPedidosEntregados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosEntregados).BeginInit();
            SuspendLayout();
            // 
            // cbMeses
            // 
            cbMeses.FormattingEnabled = true;
            cbMeses.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cbMeses.Location = new Point(289, 65);
            cbMeses.Name = "cbMeses";
            cbMeses.Size = new Size(121, 23);
            cbMeses.TabIndex = 0;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(237, 68);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(455, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvPedidosEntregados
            // 
            dgvPedidosEntregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosEntregados.Location = new Point(12, 137);
            dgvPedidosEntregados.Name = "dgvPedidosEntregados";
            dgvPedidosEntregados.RowTemplate.Height = 25;
            dgvPedidosEntregados.Size = new Size(776, 301);
            dgvPedidosEntregados.TabIndex = 3;
            // 
            // FormConsultarProductosEntregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPedidosEntregados);
            Controls.Add(btnBuscar);
            Controls.Add(lblMes);
            Controls.Add(cbMeses);
            Name = "FormConsultarProductosEntregados";
            Text = "FormConsultarProductosEntregados";
            ((System.ComponentModel.ISupportInitialize)dgvPedidosEntregados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMeses;
        private Label lblMes;
        private Button btnBuscar;
        private DataGridView dgvPedidosEntregados;
    }
}