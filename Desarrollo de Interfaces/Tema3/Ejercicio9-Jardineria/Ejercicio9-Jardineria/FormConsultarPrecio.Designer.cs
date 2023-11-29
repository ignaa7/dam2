namespace Ejercicio9_Jardineria
{
    partial class FormConsultarPrecio
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
            btnBuscar = new Button();
            dgvPrecios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPrecios).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(323, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(133, 49);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar precio más caro y más barato";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvPrecios
            // 
            dgvPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrecios.Location = new Point(12, 102);
            dgvPrecios.Name = "dgvPrecios";
            dgvPrecios.RowTemplate.Height = 25;
            dgvPrecios.Size = new Size(776, 336);
            dgvPrecios.TabIndex = 1;
            // 
            // FormConsultarPrecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPrecios);
            Controls.Add(btnBuscar);
            Name = "FormConsultarPrecio";
            Text = "FormConsultarPrecio";
            ((System.ComponentModel.ISupportInitialize)dgvPrecios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private DataGridView dgvPrecios;
    }
}