namespace Ejercicio2
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
            txtNif = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            btnAdd = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblNif = new Label();
            lblName = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lstStudents = new ListBox();
            lblStudents = new Label();
            SuspendLayout();
            // 
            // txtNif
            // 
            txtNif.Location = new Point(38, 248);
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(100, 23);
            txtNif.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 248);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(38, 313);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(121, 384);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Vaciar";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(221, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Location = new Point(38, 230);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(25, 15);
            lblNif.TabIndex = 7;
            lblNif.Text = "NIF";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(175, 230);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Nombre";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(38, 295);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(51, 15);
            lblSurname.TabIndex = 9;
            lblSurname.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(175, 295);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(365, 103);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(423, 334);
            lstStudents.TabIndex = 11;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new Point(533, 85);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(110, 15);
            lblStudents.TabIndex = 12;
            lblStudents.Text = "Lista de estudiantes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStudents);
            Controls.Add(lstStudents);
            Controls.Add(lblEmail);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(lblNif);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtNif);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNif;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button btnAdd;
        private Button btnReset;
        private Button btnExit;
        private Label lblNif;
        private Label lblName;
        private Label lblSurname;
        private Label lblEmail;
        private ListBox lstStudents;
        private Label lblStudents;
    }
}