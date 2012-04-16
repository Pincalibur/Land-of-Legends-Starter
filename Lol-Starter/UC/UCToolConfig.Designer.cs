namespace Lol_Starter.UC
{
    partial class UCToolConfig
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxCloseButtonA = new System.Windows.Forms.PictureBox();
            this.lbOptionen = new System.Windows.Forms.Label();
            this.picBoxWoWPath = new System.Windows.Forms.PictureBox();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            this.picBoxExport = new System.Windows.Forms.PictureBox();
            this.lbVersionTitle = new System.Windows.Forms.Label();
            this.lbVersionInfo = new System.Windows.Forms.Label();
            this.cbBrowser = new System.Windows.Forms.CheckBox();
            this.picBoxConfigReset = new System.Windows.Forms.PictureBox();
            this.lbBrowserEntryCount = new System.Windows.Forms.Label();
            this.comboBoxBrowserEntrys = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfigReset)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCloseButtonA
            // 
            this.picBoxCloseButtonA.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCloseButtonA.BackgroundImage = global::Lol_Starter.Properties.Resources.closeButton;
            this.picBoxCloseButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxCloseButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCloseButtonA.Location = new System.Drawing.Point(258, 0);
            this.picBoxCloseButtonA.Name = "picBoxCloseButtonA";
            this.picBoxCloseButtonA.Size = new System.Drawing.Size(26, 26);
            this.picBoxCloseButtonA.TabIndex = 2;
            this.picBoxCloseButtonA.TabStop = false;
            this.picBoxCloseButtonA.Click += new System.EventHandler(this.picBoxCloseButtonA_Click);
            // 
            // lbOptionen
            // 
            this.lbOptionen.AutoSize = true;
            this.lbOptionen.BackColor = System.Drawing.Color.Transparent;
            this.lbOptionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptionen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOptionen.Location = new System.Drawing.Point(74, 10);
            this.lbOptionen.Name = "lbOptionen";
            this.lbOptionen.Size = new System.Drawing.Size(132, 31);
            this.lbOptionen.TabIndex = 3;
            this.lbOptionen.Text = "Optionen";
            // 
            // picBoxWoWPath
            // 
            this.picBoxWoWPath.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWoWPath.BackgroundImage = global::Lol_Starter.Properties.Resources.btnWoWPath;
            this.picBoxWoWPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxWoWPath.Location = new System.Drawing.Point(36, 112);
            this.picBoxWoWPath.Name = "picBoxWoWPath";
            this.picBoxWoWPath.Size = new System.Drawing.Size(90, 35);
            this.picBoxWoWPath.TabIndex = 4;
            this.picBoxWoWPath.TabStop = false;
            this.picBoxWoWPath.Click += new System.EventHandler(this.picBoxWoWPath_Click);
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUpdate.BackgroundImage = global::Lol_Starter.Properties.Resources.btnUpdate;
            this.picBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxUpdate.Location = new System.Drawing.Point(155, 112);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(90, 35);
            this.picBoxUpdate.TabIndex = 5;
            this.picBoxUpdate.TabStop = false;
            this.picBoxUpdate.Click += new System.EventHandler(this.picBoxUpdate_Click);
            // 
            // picBoxExport
            // 
            this.picBoxExport.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExport.BackgroundImage = global::Lol_Starter.Properties.Resources.btnExport;
            this.picBoxExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxExport.Location = new System.Drawing.Point(66, 153);
            this.picBoxExport.Name = "picBoxExport";
            this.picBoxExport.Size = new System.Drawing.Size(140, 35);
            this.picBoxExport.TabIndex = 6;
            this.picBoxExport.TabStop = false;
            this.picBoxExport.Click += new System.EventHandler(this.picBoxExport_Click);
            // 
            // lbVersionTitle
            // 
            this.lbVersionTitle.AutoSize = true;
            this.lbVersionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersionTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbVersionTitle.Location = new System.Drawing.Point(15, 242);
            this.lbVersionTitle.Name = "lbVersionTitle";
            this.lbVersionTitle.Size = new System.Drawing.Size(166, 16);
            this.lbVersionTitle.TabIndex = 7;
            this.lbVersionTitle.Text = "Versions Informationen";
            // 
            // lbVersionInfo
            // 
            this.lbVersionInfo.AutoSize = true;
            this.lbVersionInfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbVersionInfo.Location = new System.Drawing.Point(15, 268);
            this.lbVersionInfo.Name = "lbVersionInfo";
            this.lbVersionInfo.Size = new System.Drawing.Size(254, 39);
            this.lbVersionInfo.TabIndex = 8;
            this.lbVersionInfo.Text = "Release v1.3.1   10.04.2012 20:46\r\nGeistiges Eigentum von Kevin Groß\r\nEinige Graf" +
                "iken sind Eigentum von Activsion Blizzard";
            // 
            // cbBrowser
            // 
            this.cbBrowser.AutoSize = true;
            this.cbBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowser.Location = new System.Drawing.Point(69, 63);
            this.cbBrowser.Name = "cbBrowser";
            this.cbBrowser.Size = new System.Drawing.Size(137, 20);
            this.cbBrowser.TabIndex = 9;
            this.cbBrowser.Text = "Browser aktivieren";
            this.cbBrowser.UseVisualStyleBackColor = true;
            this.cbBrowser.CheckedChanged += new System.EventHandler(this.cbBrowser_CheckedChanged);
            // 
            // picBoxConfigReset
            // 
            this.picBoxConfigReset.BackColor = System.Drawing.Color.Transparent;
            this.picBoxConfigReset.BackgroundImage = global::Lol_Starter.Properties.Resources.btnConfigReset;
            this.picBoxConfigReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxConfigReset.Location = new System.Drawing.Point(66, 194);
            this.picBoxConfigReset.Name = "picBoxConfigReset";
            this.picBoxConfigReset.Size = new System.Drawing.Size(140, 35);
            this.picBoxConfigReset.TabIndex = 10;
            this.picBoxConfigReset.TabStop = false;
            this.picBoxConfigReset.Click += new System.EventHandler(this.picBoxConfigReset_Click);
            // 
            // lbBrowserEntryCount
            // 
            this.lbBrowserEntryCount.AutoSize = true;
            this.lbBrowserEntryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrowserEntryCount.Location = new System.Drawing.Point(119, 86);
            this.lbBrowserEntryCount.Name = "lbBrowserEntryCount";
            this.lbBrowserEntryCount.Size = new System.Drawing.Size(126, 16);
            this.lbBrowserEntryCount.TabIndex = 11;
            this.lbBrowserEntryCount.Text = "Anzahl Neuigkeiten:";
            // 
            // comboBoxBrowserEntrys
            // 
            this.comboBoxBrowserEntrys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrowserEntrys.FormattingEnabled = true;
            this.comboBoxBrowserEntrys.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10"});
            this.comboBoxBrowserEntrys.Location = new System.Drawing.Point(69, 85);
            this.comboBoxBrowserEntrys.Name = "comboBoxBrowserEntrys";
            this.comboBoxBrowserEntrys.Size = new System.Drawing.Size(45, 21);
            this.comboBoxBrowserEntrys.TabIndex = 12;
            this.comboBoxBrowserEntrys.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrowserEntrys_SelectedIndexChanged);
            // 
            // UCToolConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.comboBoxBrowserEntrys);
            this.Controls.Add(this.lbBrowserEntryCount);
            this.Controls.Add(this.picBoxConfigReset);
            this.Controls.Add(this.cbBrowser);
            this.Controls.Add(this.lbVersionInfo);
            this.Controls.Add(this.lbVersionTitle);
            this.Controls.Add(this.picBoxExport);
            this.Controls.Add(this.picBoxUpdate);
            this.Controls.Add(this.picBoxWoWPath);
            this.Controls.Add(this.lbOptionen);
            this.Controls.Add(this.picBoxCloseButtonA);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UCToolConfig";
            this.Size = new System.Drawing.Size(284, 317);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfigReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCloseButtonA;
        private System.Windows.Forms.Label lbOptionen;
        private System.Windows.Forms.PictureBox picBoxWoWPath;
        private System.Windows.Forms.PictureBox picBoxUpdate;
        private System.Windows.Forms.PictureBox picBoxExport;
        private System.Windows.Forms.Label lbVersionTitle;
        private System.Windows.Forms.Label lbVersionInfo;
        private System.Windows.Forms.CheckBox cbBrowser;
        private System.Windows.Forms.PictureBox picBoxConfigReset;
        private System.Windows.Forms.Label lbBrowserEntryCount;
        private System.Windows.Forms.ComboBox comboBoxBrowserEntrys;
    }
}
