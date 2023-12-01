namespace _2
{
    partial class FormVerMantenimientos
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
            dgvMantenimientos = new DataGridView();
            btnVer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // dgvMantenimientos
            // 
            dgvMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientos.Location = new Point(12, 108);
            dgvMantenimientos.Name = "dgvMantenimientos";
            dgvMantenimientos.RowTemplate.Height = 25;
            dgvMantenimientos.Size = new Size(776, 324);
            dgvMantenimientos.TabIndex = 3;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(292, 18);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(171, 67);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver mantenimientos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // FormVerMantenimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMantenimientos);
            Controls.Add(btnVer);
            Name = "FormVerMantenimientos";
            Text = "FormVerMantenimientos";
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMantenimientos;
        private Button btnVer;
    }
}