namespace photo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Image = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActual = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ctxMenuPhoto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(13, 57);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(307, 218);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoad,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuFileLoad.Size = new System.Drawing.Size(140, 22);
            this.mnuFileLoad.Text = "Load";
            this.mnuFileLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(140, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImage});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mnuImage
            // 
            this.mnuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToFitToolStripMenuItem,
            this.mnuImageStretch,
            this.mnuImageScale});
            this.mnuImage.Name = "mnuImage";
            this.mnuImage.Size = new System.Drawing.Size(107, 22);
            this.mnuImage.Text = "Image";
            this.mnuImage.DropDownOpening += new System.EventHandler(this.mnuImage_DropDownOpening);
            this.mnuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuImage_DropDownItemClicked);
            // 
            // scaleToFitToolStripMenuItem
            // 
            this.scaleToFitToolStripMenuItem.Checked = true;
            this.scaleToFitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scaleToFitToolStripMenuItem.Name = "scaleToFitToolStripMenuItem";
            this.scaleToFitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scaleToFitToolStripMenuItem.Tag = "Zoom";
            this.scaleToFitToolStripMenuItem.Text = "Scale to Fit";
            // 
            // mnuImageStretch
            // 
            this.mnuImageStretch.Name = "mnuImageStretch";
            this.mnuImageStretch.Size = new System.Drawing.Size(141, 22);
            this.mnuImageStretch.Tag = "StretchImage";
            this.mnuImageStretch.Text = "Stretch to Fit";
            // 
            // mnuImageScale
            // 
            this.mnuImageScale.Name = "mnuImageScale";
            this.mnuImageScale.Size = new System.Drawing.Size(141, 22);
            this.mnuImageScale.Tag = "Normal";
            this.mnuImageScale.Text = "Actual to Fit";
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Image});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.Size = new System.Drawing.Size(108, 26);
            // 
            // Image
            // 
            this.Image.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScale,
            this.mnuStretch,
            this.mnuActual});
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(107, 22);
            this.Image.Text = "Image";
            this.Image.DropDownOpening += new System.EventHandler(this.mnuImage_DropDownOpening);
            this.Image.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuImage_DropDownItemClicked);
            // 
            // mnuScale
            // 
            this.mnuScale.Checked = true;
            this.mnuScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuScale.Name = "mnuScale";
            this.mnuScale.Size = new System.Drawing.Size(152, 22);
            this.mnuScale.Tag = "Zoom";
            this.mnuScale.Text = "Scale to Fit";
            // 
            // mnuStretch
            // 
            this.mnuStretch.Name = "mnuStretch";
            this.mnuStretch.Size = new System.Drawing.Size(152, 22);
            this.mnuStretch.Tag = "StretchImage";
            this.mnuStretch.Text = "Stretch to Fit";
            // 
            // mnuActual
            // 
            this.mnuActual.Name = "mnuActual";
            this.mnuActual.Size = new System.Drawing.Size(152, 22);
            this.mnuActual.Tag = "Normal";
            this.mnuActual.Text = "Actual to Fit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusAlbumPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(332, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.AutoSize = false;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(247, 19);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "Desc";
            // 
            // statusImageSize
            // 
            this.statusImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(42, 19);
            this.statusImageSize.Text = "W x H";
            // 
            // statusAlbumPos
            // 
            this.statusAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusAlbumPos.Name = "statusAlbumPos";
            this.statusAlbumPos.Size = new System.Drawing.Size(28, 19);
            this.statusAlbumPos.Text = "1/1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 320);
            this.ContextMenuStrip = this.ctxMenuPhoto;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImage;
        private System.Windows.Forms.ToolStripMenuItem scaleToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImageStretch;
        private System.Windows.Forms.ToolStripMenuItem mnuImageScale;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusAlbumPos;
        private System.Windows.Forms.ToolStripMenuItem Image;
        private System.Windows.Forms.ToolStripMenuItem mnuScale;
        private System.Windows.Forms.ToolStripMenuItem mnuStretch;
        private System.Windows.Forms.ToolStripMenuItem mnuActual;
    }
}

