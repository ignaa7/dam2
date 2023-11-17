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
            tsmFile = new ToolStripMenuItem();
            tsmNew = new ToolStripMenuItem();
            tsmOpen = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsmCut = new ToolStripMenuItem();
            tsmCopy = new ToolStripMenuItem();
            tsmPaste = new ToolStripMenuItem();
            tsmOpenSearch = new ToolStripMenuItem();
            tsmSearchBox = new ToolStripTextBox();
            tsmSearch = new ToolStripMenuItem();
            tsmFont = new ToolStripMenuItem();
            tsmColor = new ToolStripMenuItem();
            tsToolbar = new ToolStrip();
            tsbNew = new ToolStripButton();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbCut = new ToolStripButton();
            tsbCopy = new ToolStripButton();
            tsbPaste = new ToolStripButton();
            tsbFont = new ToolStripButton();
            tsbColor = new ToolStripButton();
            tsbSearchBox = new ToolStripTextBox();
            tsbSearch = new ToolStripButton();
            rtbText = new RichTextBox();
            statusStrip1 = new StatusStrip();
            tsslCurrentLine = new ToolStripStatusLabel();
            mnuMenu.SuspendLayout();
            tsToolbar.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { tsmNew, tsmOpen, tsmSave, tsmExit });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(60, 20);
            tsmFile.Text = "Archivo";
            // 
            // tsmNew
            // 
            tsmNew.Name = "tsmNew";
            tsmNew.Size = new Size(116, 22);
            tsmNew.Text = "Nuevo";
            tsmNew.Click += tsmNew_Click;
            // 
            // tsmOpen
            // 
            tsmOpen.Name = "tsmOpen";
            tsmOpen.Size = new Size(116, 22);
            tsmOpen.Text = "Abrir";
            tsmOpen.Click += tsmOpen_Click;
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(116, 22);
            tsmSave.Text = "Guardar";
            tsmSave.Click += tsmSave_Click;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(116, 22);
            tsmExit.Text = "Salir";
            tsmExit.Click += tsmExit_Click;
            // 
            // tsmEdit
            // 
            tsmEdit.DropDownItems.AddRange(new ToolStripItem[] { tsmCut, tsmCopy, tsmPaste, tsmOpenSearch, tsmFont, tsmColor });
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(49, 20);
            tsmEdit.Text = "Editar";
            // 
            // tsmCut
            // 
            tsmCut.Name = "tsmCut";
            tsmCut.Size = new Size(110, 22);
            tsmCut.Text = "Cortar";
            tsmCut.Click += tsmCut_Click;
            // 
            // tsmCopy
            // 
            tsmCopy.Name = "tsmCopy";
            tsmCopy.Size = new Size(110, 22);
            tsmCopy.Text = "Copiar";
            tsmCopy.Click += tsmCopy_Click;
            // 
            // tsmPaste
            // 
            tsmPaste.Name = "tsmPaste";
            tsmPaste.Size = new Size(110, 22);
            tsmPaste.Text = "Pegar";
            tsmPaste.Click += tsmPaste_Click;
            // 
            // tsmOpenSearch
            // 
            tsmOpenSearch.DropDownItems.AddRange(new ToolStripItem[] { tsmSearchBox, tsmSearch });
            tsmOpenSearch.Name = "tsmOpenSearch";
            tsmOpenSearch.Size = new Size(110, 22);
            tsmOpenSearch.Text = "Buscar";
            // 
            // tsmSearchBox
            // 
            tsmSearchBox.BorderStyle = BorderStyle.FixedSingle;
            tsmSearchBox.Name = "tsmSearchBox";
            tsmSearchBox.Size = new Size(100, 23);
            // 
            // tsmSearch
            // 
            tsmSearch.Name = "tsmSearch";
            tsmSearch.Size = new Size(160, 22);
            tsmSearch.Text = "Buscar";
            tsmSearch.Click += tsmSearch_Click;
            // 
            // tsmFont
            // 
            tsmFont.Name = "tsmFont";
            tsmFont.Size = new Size(110, 22);
            tsmFont.Text = "Fuente";
            tsmFont.Click += tsmFont_Click;
            // 
            // tsmColor
            // 
            tsmColor.Name = "tsmColor";
            tsmColor.Size = new Size(110, 22);
            tsmColor.Text = "Color";
            tsmColor.Click += tsmColor_Click;
            // 
            // tsToolbar
            // 
            tsToolbar.Items.AddRange(new ToolStripItem[] { tsbNew, tsbOpen, tsbSave, tsbCut, tsbCopy, tsbPaste, tsbFont, tsbColor, tsbSearchBox, tsbSearch });
            tsToolbar.Location = new Point(0, 24);
            tsToolbar.Name = "tsToolbar";
            tsToolbar.Size = new Size(800, 25);
            tsToolbar.TabIndex = 1;
            tsToolbar.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNew.Image = Properties.Resources._new;
            tsbNew.ImageTransparentColor = Color.Magenta;
            tsbNew.Name = "tsbNew";
            tsbNew.Size = new Size(23, 22);
            tsbNew.Text = "toolStripButton1";
            tsbNew.Click += tsbNew_Click;
            // 
            // tsbOpen
            // 
            tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpen.Image = Properties.Resources.open;
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(23, 22);
            tsbOpen.Text = "toolStripButton1";
            tsbOpen.Click += tsbOpen_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = Properties.Resources.save;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(23, 22);
            tsbSave.Text = "toolStripButton2";
            tsbSave.Click += tsbSave_Click;
            // 
            // tsbCut
            // 
            tsbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCut.Image = Properties.Resources.cut;
            tsbCut.ImageTransparentColor = Color.Magenta;
            tsbCut.Name = "tsbCut";
            tsbCut.Size = new Size(23, 22);
            tsbCut.Text = "toolStripButton3";
            tsbCut.Click += tsbCut_Click;
            // 
            // tsbCopy
            // 
            tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCopy.Image = Properties.Resources.copy;
            tsbCopy.ImageTransparentColor = Color.Magenta;
            tsbCopy.Name = "tsbCopy";
            tsbCopy.Size = new Size(23, 22);
            tsbCopy.Text = "toolStripButton4";
            tsbCopy.Click += tsbCopy_Click;
            // 
            // tsbPaste
            // 
            tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPaste.Image = Properties.Resources.paste;
            tsbPaste.ImageTransparentColor = Color.Magenta;
            tsbPaste.Name = "tsbPaste";
            tsbPaste.Size = new Size(23, 22);
            tsbPaste.Text = "toolStripButton5";
            tsbPaste.Click += tsbPaste_Click;
            // 
            // tsbFont
            // 
            tsbFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFont.Image = Properties.Resources.font;
            tsbFont.ImageTransparentColor = Color.Magenta;
            tsbFont.Name = "tsbFont";
            tsbFont.Size = new Size(23, 22);
            tsbFont.Text = "toolStripButton7";
            tsbFont.Click += tsbFont_Click;
            // 
            // tsbColor
            // 
            tsbColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbColor.Image = Properties.Resources.color1;
            tsbColor.ImageTransparentColor = Color.Magenta;
            tsbColor.Name = "tsbColor";
            tsbColor.Size = new Size(23, 22);
            tsbColor.Text = "toolStripButton8";
            tsbColor.Click += tsbColor_Click;
            // 
            // tsbSearchBox
            // 
            tsbSearchBox.BorderStyle = BorderStyle.FixedSingle;
            tsbSearchBox.Name = "tsbSearchBox";
            tsbSearchBox.Size = new Size(100, 25);
            // 
            // tsbSearch
            // 
            tsbSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSearch.Image = Properties.Resources.search;
            tsbSearch.ImageTransparentColor = Color.Magenta;
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new Size(23, 22);
            tsbSearch.Text = "toolStripButton6";
            tsbSearch.Click += tsbSearch_Click;
            // 
            // rtbText
            // 
            rtbText.Location = new Point(0, 52);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(800, 373);
            rtbText.TabIndex = 2;
            rtbText.Text = "";
            rtbText.SelectionChanged += rtbText_SelectionChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslCurrentLine });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslCurrentLine
            // 
            tsslCurrentLine.Name = "tsslCurrentLine";
            tsslCurrentLine.Size = new Size(118, 17);
            tsslCurrentLine.Text = "toolStripStatusLabel1";
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenu;
        private ToolStrip tsToolbar;
        private RichTextBox rtbText;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmNew;
        private ToolStripMenuItem tsmOpen;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmExit;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem tsmCut;
        private ToolStripMenuItem tsmCopy;
        private ToolStripMenuItem tsmPaste;
        private ToolStripMenuItem tsmOpenSearch;
        private ToolStripMenuItem tsmFont;
        private ToolStripMenuItem tsmColor;
        private ToolStripTextBox tsmSearchBox;
        private ToolStripMenuItem tsmSearch;
        private ToolStripButton tsbNew;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbCut;
        private ToolStripButton tsbCopy;
        private ToolStripButton tsbPaste;
        private ToolStripButton tsbSearch;
        private ToolStripButton tsbFont;
        private ToolStripButton tsbColor;
        private ToolStripStatusLabel tsslCurrentLine;
        private ToolStripTextBox tsbSearchBox;
    }
}