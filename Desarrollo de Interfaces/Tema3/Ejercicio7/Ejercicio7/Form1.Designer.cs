namespace Ejercicio7
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
            mnuMenu = new MenuStrip();
            tsToolbar = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            rtbText = new RichTextBox();
            statusStrip1 = new StatusStrip();
            tsmFile = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsmNew = new ToolStripMenuItem();
            tsmOpen = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            tsmCut = new ToolStripMenuItem();
            tsmCopy = new ToolStripMenuItem();
            tsmPaste = new ToolStripMenuItem();
            tsmFind = new ToolStripMenuItem();
            tsmFont = new ToolStripMenuItem();
            tsmColor = new ToolStripMenuItem();
            mnuMenu.SuspendLayout();
            tsToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenu
            // 
            mnuMenu.Items.AddRange(new ToolStripItem[] { tsmFile, tsmEdit });
            mnuMenu.Location = new Point(0, 0);
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Size = new Size(800, 24);
            mnuMenu.TabIndex = 0;
            mnuMenu.Text = "menuStrip1";
            // 
            // tsToolbar
            // 
            tsToolbar.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            tsToolbar.Location = new Point(0, 24);
            tsToolbar.Name = "tsToolbar";
            tsToolbar.Size = new Size(800, 25);
            tsToolbar.TabIndex = 1;
            tsToolbar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(0, 52);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(800, 373);
            rtbText.TabIndex = 2;
            rtbText.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { tsmNew, tsmOpen, tsmSave, tsmExit });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(60, 20);
            tsmFile.Text = "Archivo";
            // 
            // tsmEdit
            // 
            tsmEdit.DropDownItems.AddRange(new ToolStripItem[] { tsmCut, tsmCopy, tsmPaste, tsmFind, tsmFont, tsmColor });
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(49, 20);
            tsmEdit.Text = "Editar";
            // 
            // tsmNew
            // 
            tsmNew.Name = "tsmNew";
            tsmNew.Size = new Size(180, 22);
            tsmNew.Text = "Nuevo";
            tsmNew.Click += tsmNew_Click;
            // 
            // tsmOpen
            // 
            tsmOpen.Name = "tsmOpen";
            tsmOpen.Size = new Size(180, 22);
            tsmOpen.Text = "Abrir";
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(180, 22);
            tsmSave.Text = "Guardar";
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(180, 22);
            tsmExit.Text = "Salir";
            // 
            // tsmCut
            // 
            tsmCut.Name = "tsmCut";
            tsmCut.Size = new Size(180, 22);
            tsmCut.Text = "Cortar";
            // 
            // tsmCopy
            // 
            tsmCopy.Name = "tsmCopy";
            tsmCopy.Size = new Size(180, 22);
            tsmCopy.Text = "Copiar";
            // 
            // tsmPaste
            // 
            tsmPaste.Name = "tsmPaste";
            tsmPaste.Size = new Size(180, 22);
            tsmPaste.Text = "Pegar";
            // 
            // tsmFind
            // 
            tsmFind.Name = "tsmFind";
            tsmFind.Size = new Size(180, 22);
            tsmFind.Text = "Buscar";
            // 
            // tsmFont
            // 
            tsmFont.Name = "tsmFont";
            tsmFont.Size = new Size(180, 22);
            tsmFont.Text = "Fuente";
            // 
            // tsmColor
            // 
            tsmColor.Name = "tsmColor";
            tsmColor.Size = new Size(180, 22);
            tsmColor.Text = "Color";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(rtbText);
            Controls.Add(tsToolbar);
            Controls.Add(mnuMenu);
            MainMenuStrip = mnuMenu;
            Name = "Form1";
            Text = "Form1";
            mnuMenu.ResumeLayout(false);
            mnuMenu.PerformLayout();
            tsToolbar.ResumeLayout(false);
            tsToolbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenu;
        private ToolStrip tsToolbar;
        private RichTextBox rtbText;
        private StatusStrip statusStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmNew;
        private ToolStripMenuItem tsmOpen;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmExit;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem tsmCut;
        private ToolStripMenuItem tsmCopy;
        private ToolStripMenuItem tsmPaste;
        private ToolStripMenuItem tsmFind;
        private ToolStripMenuItem tsmFont;
        private ToolStripMenuItem tsmColor;
    }
}