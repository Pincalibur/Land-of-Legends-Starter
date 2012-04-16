namespace Lol_Starter.UC
{
    partial class UCTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTitle));
            this.pnlTitlePicB = new System.Windows.Forms.Panel();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panelSN = new System.Windows.Forms.Panel();
            this.picBoxFacebook = new System.Windows.Forms.PictureBox();
            this.picBoxTwitter = new System.Windows.Forms.PictureBox();
            this.picBoxGooglep = new System.Windows.Forms.PictureBox();
            this.picBoxSteamgrp = new System.Windows.Forms.PictureBox();
            this.picBoxConfig = new System.Windows.Forms.PictureBox();
            this.picBoxCloseButtonA = new System.Windows.Forms.PictureBox();
            this.picBoxTitleA = new System.Windows.Forms.PictureBox();
            this.pnlTitlePicB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            this.panelSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGooglep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSteamgrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitleA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitlePicB
            // 
            this.pnlTitlePicB.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_header_animiert2;
            this.pnlTitlePicB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTitlePicB.Controls.Add(this.picBoxMinimize);
            this.pnlTitlePicB.Controls.Add(this.panelSN);
            this.pnlTitlePicB.Controls.Add(this.picBoxConfig);
            this.pnlTitlePicB.Controls.Add(this.picBoxCloseButtonA);
            this.pnlTitlePicB.Location = new System.Drawing.Point(99, 0);
            this.pnlTitlePicB.Name = "pnlTitlePicB";
            this.pnlTitlePicB.Size = new System.Drawing.Size(799, 126);
            this.pnlTitlePicB.TabIndex = 1;
            // 
            // picBoxMinimize
            // 
            this.picBoxMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMinimize.BackgroundImage = global::Lol_Starter.Properties.Resources.minimizeButton;
            this.picBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimize.Location = new System.Drawing.Point(746, 0);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(26, 26);
            this.picBoxMinimize.TabIndex = 26;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.picBoxMinimize_Click);
            // 
            // panelSN
            // 
            this.panelSN.BackColor = System.Drawing.Color.Transparent;
            this.panelSN.Controls.Add(this.picBoxFacebook);
            this.panelSN.Controls.Add(this.picBoxTwitter);
            this.panelSN.Controls.Add(this.picBoxGooglep);
            this.panelSN.Controls.Add(this.picBoxSteamgrp);
            this.panelSN.Location = new System.Drawing.Point(641, 85);
            this.panelSN.Name = "panelSN";
            this.panelSN.Size = new System.Drawing.Size(155, 38);
            this.panelSN.TabIndex = 25;
            // 
            // picBoxFacebook
            // 
            this.picBoxFacebook.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFacebook.BackgroundImage = global::Lol_Starter.Properties.Resources.facebookbuttonlol;
            this.picBoxFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFacebook.Location = new System.Drawing.Point(2, 2);
            this.picBoxFacebook.Name = "picBoxFacebook";
            this.picBoxFacebook.Size = new System.Drawing.Size(32, 32);
            this.picBoxFacebook.TabIndex = 6;
            this.picBoxFacebook.TabStop = false;
            this.picBoxFacebook.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxTwitter
            // 
            this.picBoxTwitter.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTwitter.BackgroundImage = global::Lol_Starter.Properties.Resources.buttontwitterlol;
            this.picBoxTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTwitter.Location = new System.Drawing.Point(40, 2);
            this.picBoxTwitter.Name = "picBoxTwitter";
            this.picBoxTwitter.Size = new System.Drawing.Size(32, 32);
            this.picBoxTwitter.TabIndex = 7;
            this.picBoxTwitter.TabStop = false;
            this.picBoxTwitter.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxGooglep
            // 
            this.picBoxGooglep.BackColor = System.Drawing.Color.Transparent;
            this.picBoxGooglep.BackgroundImage = global::Lol_Starter.Properties.Resources.gprofilebutton64;
            this.picBoxGooglep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxGooglep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxGooglep.Location = new System.Drawing.Point(78, 2);
            this.picBoxGooglep.Name = "picBoxGooglep";
            this.picBoxGooglep.Size = new System.Drawing.Size(32, 32);
            this.picBoxGooglep.TabIndex = 8;
            this.picBoxGooglep.TabStop = false;
            this.picBoxGooglep.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxSteamgrp
            // 
            this.picBoxSteamgrp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSteamgrp.BackgroundImage = global::Lol_Starter.Properties.Resources.steama0a8132cpng;
            this.picBoxSteamgrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxSteamgrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxSteamgrp.Location = new System.Drawing.Point(116, 2);
            this.picBoxSteamgrp.Name = "picBoxSteamgrp";
            this.picBoxSteamgrp.Size = new System.Drawing.Size(32, 32);
            this.picBoxSteamgrp.TabIndex = 9;
            this.picBoxSteamgrp.TabStop = false;
            this.picBoxSteamgrp.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxConfig
            // 
            this.picBoxConfig.BackColor = System.Drawing.Color.Transparent;
            this.picBoxConfig.BackgroundImage = global::Lol_Starter.Properties.Resources.btnConfig;
            this.picBoxConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxConfig.Location = new System.Drawing.Point(603, 87);
            this.picBoxConfig.Name = "picBoxConfig";
            this.picBoxConfig.Size = new System.Drawing.Size(32, 32);
            this.picBoxConfig.TabIndex = 15;
            this.picBoxConfig.TabStop = false;
            this.picBoxConfig.WaitOnLoad = true;
            this.picBoxConfig.Click += new System.EventHandler(this.picBoxConfig_Click);
            // 
            // picBoxCloseButtonA
            // 
            this.picBoxCloseButtonA.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCloseButtonA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxCloseButtonA.BackgroundImage")));
            this.picBoxCloseButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxCloseButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCloseButtonA.Location = new System.Drawing.Point(773, 0);
            this.picBoxCloseButtonA.Name = "picBoxCloseButtonA";
            this.picBoxCloseButtonA.Size = new System.Drawing.Size(26, 26);
            this.picBoxCloseButtonA.TabIndex = 0;
            this.picBoxCloseButtonA.TabStop = false;
            this.picBoxCloseButtonA.Click += new System.EventHandler(this.picBoxCloseButton_Click);
            // 
            // picBoxTitleA
            // 
            this.picBoxTitleA.Image = global::Lol_Starter.Properties.Resources.lol_header_animiert;
            this.picBoxTitleA.Location = new System.Drawing.Point(0, 0);
            this.picBoxTitleA.Name = "picBoxTitleA";
            this.picBoxTitleA.Size = new System.Drawing.Size(99, 126);
            this.picBoxTitleA.TabIndex = 0;
            this.picBoxTitleA.TabStop = false;
            // 
            // UCTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTitlePicB);
            this.Controls.Add(this.picBoxTitleA);
            this.Name = "UCTitle";
            this.Size = new System.Drawing.Size(898, 126);
            this.pnlTitlePicB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).EndInit();
            this.panelSN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGooglep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSteamgrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitleA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlTitlePicB;
        public System.Windows.Forms.PictureBox picBoxTitleA;
        private System.Windows.Forms.PictureBox picBoxCloseButtonA;
        private System.Windows.Forms.PictureBox picBoxConfig;
        private System.Windows.Forms.Panel panelSN;
        private System.Windows.Forms.PictureBox picBoxFacebook;
        private System.Windows.Forms.PictureBox picBoxTwitter;
        private System.Windows.Forms.PictureBox picBoxGooglep;
        private System.Windows.Forms.PictureBox picBoxSteamgrp;
        private System.Windows.Forms.PictureBox picBoxMinimize;
    }
}
