namespace _2
{
    partial class FormVerVehiculos
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
            btnVer = new Button();
            dgvVehiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // btnVer
            // 
            btnVer.Location = new Point(292, 24);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(171, 67);
            btnVer.TabIndex = 0;
            btnVer.Text = "Ver vehículos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(12, 114);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowTemplate.Height = 25;
            dgvVehiculos.Size = new Size(776, 324);
            dgvVehiculos.TabIndex = 1;
            // 
            // FormVerVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnVer);
            Name = "FormVerVehiculos";
            Text = "FormVerVehiculos";
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVer;
        private DataGridView dgvVehiculos;
    }
}