namespace Lol_Starter.UC
{
    partial class UCMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMenu));
            this.wmpRadio = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.picBoxRadio = new System.Windows.Forms.PictureBox();
            this.picBoxAccount = new System.Windows.Forms.PictureBox();
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            this.picBoxBugReport = new System.Windows.Forms.PictureBox();
            this.picBoxArsenal = new System.Windows.Forms.PictureBox();
            this.picBoxGames = new System.Windows.Forms.PictureBox();
            this.picBoxVote = new System.Windows.Forms.PictureBox();
            this.pnlGuild = new System.Windows.Forms.Panel();
            this.picBoxHordeGuildConfig = new System.Windows.Forms.PictureBox();
            this.picBoxAllianceConfig = new System.Windows.Forms.PictureBox();
            this.lbHordGuildText = new System.Windows.Forms.Label();
            this.picBoxHordeGuild = new System.Windows.Forms.PictureBox();
            this.picBoxAllianceGuild = new System.Windows.Forms.PictureBox();
            this.lbAllianceGuildName = new System.Windows.Forms.Label();
            this.lbGuildsHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpRadio)).BeginInit();
            this.panelRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArsenal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote)).BeginInit();
            this.pnlGuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHordeGuildConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAllianceConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHordeGuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAllianceGuild)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpRadio
            // 
            this.wmpRadio.Enabled = true;
            this.wmpRadio.Location = new System.Drawing.Point(1, 39);
            this.wmpRadio.Name = "wmpRadio";
            this.wmpRadio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpRadio.OcxState")));
            this.wmpRadio.Size = new System.Drawing.Size(209, 34);
            this.wmpRadio.TabIndex = 14;
            // 
            // panelRadio
            // 
            this.panelRadio.BackColor = System.Drawing.Color.Transparent;
            this.panelRadio.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.panelRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRadio.Controls.Add(this.picBoxRadio);
            this.panelRadio.Controls.Add(this.wmpRadio);
            this.panelRadio.Location = new System.Drawing.Point(3, 283);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(212, 78);
            this.panelRadio.TabIndex = 16;
            // 
            // picBoxRadio
            // 
            this.picBoxRadio.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnRadio;
            this.picBoxRadio.Location = new System.Drawing.Point(20, 6);
            this.picBoxRadio.Name = "picBoxRadio";
            this.picBoxRadio.Size = new System.Drawing.Size(170, 25);
            this.picBoxRadio.TabIndex = 15;
            this.picBoxRadio.TabStop = false;
            // 
            // picBoxAccount
            // 
            this.picBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAccount.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnAccount;
            this.picBoxAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAccount.Location = new System.Drawing.Point(24, 15);
            this.picBoxAccount.Name = "picBoxAccount";
            this.picBoxAccount.Size = new System.Drawing.Size(170, 25);
            this.picBoxAccount.TabIndex = 17;
            this.picBoxAccount.TabStop = false;
            this.picBoxAccount.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHelp.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnHelp;
            this.picBoxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxHelp.Location = new System.Drawing.Point(24, 46);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(170, 25);
            this.picBoxHelp.TabIndex = 18;
            this.picBoxHelp.TabStop = false;
            this.picBoxHelp.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxBugReport
            // 
            this.picBoxBugReport.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBugReport.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnBugReport;
            this.picBoxBugReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxBugReport.Location = new System.Drawing.Point(24, 77);
            this.picBoxBugReport.Name = "picBoxBugReport";
            this.picBoxBugReport.Size = new System.Drawing.Size(170, 25);
            this.picBoxBugReport.TabIndex = 19;
            this.picBoxBugReport.TabStop = false;
            this.picBoxBugReport.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxArsenal
            // 
            this.picBoxArsenal.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnArsenal;
            this.picBoxArsenal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxArsenal.Location = new System.Drawing.Point(24, 108);
            this.picBoxArsenal.Name = "picBoxArsenal";
            this.picBoxArsenal.Size = new System.Drawing.Size(170, 25);
            this.picBoxArsenal.TabIndex = 20;
            this.picBoxArsenal.TabStop = false;
            this.picBoxArsenal.Click += new System.EventHandler(this.picBoxArsenal_Click);
            // 
            // picBoxGames
            // 
            this.picBoxGames.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnGames;
            this.picBoxGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxGames.Location = new System.Drawing.Point(24, 139);
            this.picBoxGames.Name = "picBoxGames";
            this.picBoxGames.Size = new System.Drawing.Size(170, 25);
            this.picBoxGames.TabIndex = 21;
            this.picBoxGames.TabStop = false;
            this.picBoxGames.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxVote
            // 
            this.picBoxVote.BackgroundImage = global::Lol_Starter.Properties.Resources.menubtnVote;
            this.picBoxVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxVote.Location = new System.Drawing.Point(24, 170);
            this.picBoxVote.Name = "picBoxVote";
            this.picBoxVote.Size = new System.Drawing.Size(170, 25);
            this.picBoxVote.TabIndex = 28;
            this.picBoxVote.TabStop = false;
            this.picBoxVote.Click += new System.EventHandler(this.picBoxVote_Click);
            // 
            // pnlGuild
            // 
            this.pnlGuild.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.pnlGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuild.Controls.Add(this.picBoxHordeGuildConfig);
            this.pnlGuild.Controls.Add(this.picBoxAllianceConfig);
            this.pnlGuild.Controls.Add(this.lbHordGuildText);
            this.pnlGuild.Controls.Add(this.picBoxHordeGuild);
            this.pnlGuild.Controls.Add(this.picBoxAllianceGuild);
            this.pnlGuild.Controls.Add(this.lbAllianceGuildName);
            this.pnlGuild.Controls.Add(this.lbGuildsHeader);
            this.pnlGuild.Location = new System.Drawing.Point(3, 209);
            this.pnlGuild.Name = "pnlGuild";
            this.pnlGuild.Size = new System.Drawing.Size(212, 68);
            this.pnlGuild.TabIndex = 29;
            // 
            // picBoxHordeGuildConfig
            // 
            this.picBoxHordeGuildConfig.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHordeGuildConfig.BackgroundImage = global::Lol_Starter.Properties.Resources.btnEdit;
            this.picBoxHordeGuildConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxHordeGuildConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxHordeGuildConfig.Location = new System.Drawing.Point(3, 43);
            this.picBoxHordeGuildConfig.Name = "picBoxHordeGuildConfig";
            this.picBoxHordeGuildConfig.Size = new System.Drawing.Size(16, 16);
            this.picBoxHordeGuildConfig.TabIndex = 33;
            this.picBoxHordeGuildConfig.TabStop = false;
            this.picBoxHordeGuildConfig.Click += new System.EventHandler(this.GuildConfig_Click);
            // 
            // picBoxAllianceConfig
            // 
            this.picBoxAllianceConfig.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAllianceConfig.BackgroundImage = global::Lol_Starter.Properties.Resources.btnEdit;
            this.picBoxAllianceConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAllianceConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAllianceConfig.Location = new System.Drawing.Point(3, 21);
            this.picBoxAllianceConfig.Name = "picBoxAllianceConfig";
            this.picBoxAllianceConfig.Size = new System.Drawing.Size(16, 16);
            this.picBoxAllianceConfig.TabIndex = 32;
            this.picBoxAllianceConfig.TabStop = false;
            this.picBoxAllianceConfig.Click += new System.EventHandler(this.GuildConfig_Click);
            // 
            // lbHordGuildText
            // 
            this.lbHordGuildText.AutoSize = true;
            this.lbHordGuildText.BackColor = System.Drawing.Color.Transparent;
            this.lbHordGuildText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHordGuildText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHordGuildText.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbHordGuildText.Location = new System.Drawing.Point(58, 43);
            this.lbHordGuildText.Name = "lbHordGuildText";
            this.lbHordGuildText.Size = new System.Drawing.Size(111, 15);
            this.lbHordGuildText.TabIndex = 31;
            this.lbHordGuildText.Text = "Meine Horde Gilde";
            this.lbHordGuildText.Click += new System.EventHandler(this.HordeGuild_Click);
            // 
            // picBoxHordeGuild
            // 
            this.picBoxHordeGuild.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHordeGuild.BackgroundImage = global::Lol_Starter.Properties.Resources.btnHordeGuild;
            this.picBoxHordeGuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxHordeGuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxHordeGuild.Location = new System.Drawing.Point(29, 43);
            this.picBoxHordeGuild.Name = "picBoxHordeGuild";
            this.picBoxHordeGuild.Size = new System.Drawing.Size(16, 16);
            this.picBoxHordeGuild.TabIndex = 30;
            this.picBoxHordeGuild.TabStop = false;
            this.picBoxHordeGuild.Click += new System.EventHandler(this.HordeGuild_Click);
            // 
            // picBoxAllianceGuild
            // 
            this.picBoxAllianceGuild.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAllianceGuild.BackgroundImage = global::Lol_Starter.Properties.Resources.btnAllianceGuild;
            this.picBoxAllianceGuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAllianceGuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAllianceGuild.Location = new System.Drawing.Point(29, 21);
            this.picBoxAllianceGuild.Name = "picBoxAllianceGuild";
            this.picBoxAllianceGuild.Size = new System.Drawing.Size(16, 16);
            this.picBoxAllianceGuild.TabIndex = 29;
            this.picBoxAllianceGuild.TabStop = false;
            this.picBoxAllianceGuild.Click += new System.EventHandler(this.AllianceGuild_Click);
            // 
            // lbAllianceGuildName
            // 
            this.lbAllianceGuildName.AutoSize = true;
            this.lbAllianceGuildName.BackColor = System.Drawing.Color.Transparent;
            this.lbAllianceGuildName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAllianceGuildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllianceGuildName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbAllianceGuildName.Location = new System.Drawing.Point(58, 22);
            this.lbAllianceGuildName.Name = "lbAllianceGuildName";
            this.lbAllianceGuildName.Size = new System.Drawing.Size(113, 15);
            this.lbAllianceGuildName.TabIndex = 28;
            this.lbAllianceGuildName.Text = "Meine Allianz Gilde";
            this.lbAllianceGuildName.Click += new System.EventHandler(this.AllianceGuild_Click);
            // 
            // lbGuildsHeader
            // 
            this.lbGuildsHeader.AutoSize = true;
            this.lbGuildsHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbGuildsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuildsHeader.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbGuildsHeader.Location = new System.Drawing.Point(3, 0);
            this.lbGuildsHeader.Name = "lbGuildsHeader";
            this.lbGuildsHeader.Size = new System.Drawing.Size(91, 16);
            this.lbGuildsHeader.TabIndex = 27;
            this.lbGuildsHeader.Text = "Meine Gilde";
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg;
            this.Controls.Add(this.pnlGuild);
            this.Controls.Add(this.picBoxVote);
            this.Controls.Add(this.picBoxGames);
            this.Controls.Add(this.picBoxArsenal);
            this.Controls.Add(this.picBoxBugReport);
            this.Controls.Add(this.picBoxHelp);
            this.Controls.Add(this.picBoxAccount);
            this.Controls.Add(this.panelRadio);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(218, 366);
            ((System.ComponentModel.ISupportInitialize)(this.wmpRadio)).EndInit();
            this.panelRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArsenal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote)).EndInit();
            this.pnlGuild.ResumeLayout(false);
            this.pnlGuild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHordeGuildConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAllianceConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHordeGuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAllianceGuild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRadio;
        public AxWMPLib.AxWindowsMediaPlayer wmpRadio;
        private System.Windows.Forms.PictureBox picBoxAccount;
        private System.Windows.Forms.PictureBox picBoxHelp;
        private System.Windows.Forms.PictureBox picBoxBugReport;
        private System.Windows.Forms.PictureBox picBoxRadio;
        private System.Windows.Forms.PictureBox picBoxArsenal;
        private System.Windows.Forms.PictureBox picBoxGames;
        private System.Windows.Forms.PictureBox picBoxVote;
        private System.Windows.Forms.Panel pnlGuild;
        private System.Windows.Forms.PictureBox picBoxHordeGuildConfig;
        private System.Windows.Forms.PictureBox picBoxAllianceConfig;
        private System.Windows.Forms.Label lbHordGuildText;
        private System.Windows.Forms.PictureBox picBoxHordeGuild;
        private System.Windows.Forms.PictureBox picBoxAllianceGuild;
        private System.Windows.Forms.Label lbAllianceGuildName;
        private System.Windows.Forms.Label lbGuildsHeader;
    }
}
