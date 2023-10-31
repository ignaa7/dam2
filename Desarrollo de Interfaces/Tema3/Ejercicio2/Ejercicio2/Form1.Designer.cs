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
            components = new System.ComponentModel.Container();
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
            errNif = new ErrorProvider(components);
            errName = new ErrorProvider(components);
            errSurname = new ErrorProvider(components);
            errEmail = new ErrorProvider(components);
            imgImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errNif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
            SuspendLayout();
            // 
            // txtNif
            // 
            txtNif.Location = new Point(38, 248);
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(100, 23);
            txtNif.TabIndex = 0;
            txtNif.Validating += txtNif_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 248);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            txtName.Validating += txtName_Validating;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(38, 313);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 3;
            txtSurname.Validating += txtSurname_Validating;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(121, 384);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Vaciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(221, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            // errNif
            // 
            errNif.ContainerControl = this;
            // 
            // errName
            // 
            errName.ContainerControl = this;
            // 
            // errSurname
            // 
            errSurname.ContainerControl = this;
            // 
            // errEmail
            // 
            errEmail.ContainerControl = this;
            // 
            // imgImage
            // 
            imgImage.Image = Properties.Resources.logo_placeholder;
            imgImage.Location = new Point(78, 30);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(170, 157);
            imgImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImage.TabIndex = 13;
            imgImage.TabStop = false;
            imgImage.MouseDoubleClick += pictureBox1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgImage);
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
            ((System.ComponentModel.ISupportInitialize)errNif).EndInit();
            ((System.ComponentModel.ISupportInitialize)errName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
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
        private ErrorProvider errNif;
        private ErrorProvider errName;
        private ErrorProvider errSurname;
        private ErrorProvider errEmail;
        private PictureBox imgImage;
    }
}