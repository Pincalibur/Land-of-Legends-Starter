namespace Lol_Starter
{
    partial class FormToolConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToolConfig));
            this.picBoxCloseButtonA = new System.Windows.Forms.PictureBox();
            this.lbOptionen = new System.Windows.Forms.Label();
            this.picBoxWoWPath = new System.Windows.Forms.PictureBox();
            this.pnlFormToolConfig = new System.Windows.Forms.Panel();
            this.lbVersionInfo = new System.Windows.Forms.Label();
            this.lbVersionTitle = new System.Windows.Forms.Label();
            this.picBoxExport = new System.Windows.Forms.PictureBox();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWPath)).BeginInit();
            this.pnlFormToolConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCloseButtonA
            // 
            this.picBoxCloseButtonA.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCloseButtonA.BackgroundImage = global::Lol_Starter.Properties.Resources.closeButton;
            this.picBoxCloseButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxCloseButtonA.Location = new System.Drawing.Point(243, -1);
            this.picBoxCloseButtonA.Name = "picBoxCloseButtonA";
            this.picBoxCloseButtonA.Size = new System.Drawing.Size(40, 26);
            this.picBoxCloseButtonA.TabIndex = 1;
            this.picBoxCloseButtonA.TabStop = false;
            this.picBoxCloseButtonA.Click += new System.EventHandler(this.picBoxCloseButtonA_Click);
            this.picBoxCloseButtonA.MouseLeave += new System.EventHandler(this.picBoxCloseButtonA_MouseLeave);
            this.picBoxCloseButtonA.MouseHover += new System.EventHandler(this.picBoxCloseButtonA_MouseHover);
            // 
            // lbOptionen
            // 
            this.lbOptionen.AutoSize = true;
            this.lbOptionen.BackColor = System.Drawing.Color.Transparent;
            this.lbOptionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptionen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOptionen.Location = new System.Drawing.Point(68, 8);
            this.lbOptionen.Name = "lbOptionen";
            this.lbOptionen.Size = new System.Drawing.Size(132, 31);
            this.lbOptionen.TabIndex = 2;
            this.lbOptionen.Text = "Optionen";
            // 
            // picBoxWoWPath
            // 
            this.picBoxWoWPath.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWoWPath.BackgroundImage = global::Lol_Starter.Properties.Resources.btnWoWPath;
            this.picBoxWoWPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxWoWPath.Location = new System.Drawing.Point(26, 65);
            this.picBoxWoWPath.Name = "picBoxWoWPath";
            this.picBoxWoWPath.Size = new System.Drawing.Size(90, 35);
            this.picBoxWoWPath.TabIndex = 3;
            this.picBoxWoWPath.TabStop = false;
            this.picBoxWoWPath.Click += new System.EventHandler(this.picBoxWoWPath_Click);
            // 
            // pnlFormToolConfig
            // 
            this.pnlFormToolConfig.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormToolConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormToolConfig.Controls.Add(this.lbVersionInfo);
            this.pnlFormToolConfig.Controls.Add(this.lbVersionTitle);
            this.pnlFormToolConfig.Controls.Add(this.picBoxExport);
            this.pnlFormToolConfig.Controls.Add(this.picBoxUpdate);
            this.pnlFormToolConfig.Controls.Add(this.picBoxWoWPath);
            this.pnlFormToolConfig.Controls.Add(this.picBoxCloseButtonA);
            this.pnlFormToolConfig.Controls.Add(this.lbOptionen);
            this.pnlFormToolConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlFormToolConfig.Name = "pnlFormToolConfig";
            this.pnlFormToolConfig.Size = new System.Drawing.Size(284, 262);
            this.pnlFormToolConfig.TabIndex = 4;
            this.pnlFormToolConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormToolConfig_MouseDown);
            this.pnlFormToolConfig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormToolConfig_MouseMove);
            // 
            // lbVersionInfo
            // 
            this.lbVersionInfo.AutoSize = true;
            this.lbVersionInfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbVersionInfo.Location = new System.Drawing.Point(23, 207);
            this.lbVersionInfo.Name = "lbVersionInfo";
            this.lbVersionInfo.Size = new System.Drawing.Size(254, 39);
            this.lbVersionInfo.TabIndex = 7;
            this.lbVersionInfo.Text = "Release v0.4.3   06.04.2012 16:48\r\nGeistiges Eigentum von Kevin Groß\r\nEinige Graf" +
                "iken sind Eigentum von Activsion Blizzard";
            // 
            // lbVersionTitle
            // 
            this.lbVersionTitle.AutoSize = true;
            this.lbVersionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersionTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbVersionTitle.Location = new System.Drawing.Point(23, 181);
            this.lbVersionTitle.Name = "lbVersionTitle";
            this.lbVersionTitle.Size = new System.Drawing.Size(166, 16);
            this.lbVersionTitle.TabIndex = 6;
            this.lbVersionTitle.Text = "Versions Informationen";
            // 
            // picBoxExport
            // 
            this.picBoxExport.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExport.BackgroundImage = global::Lol_Starter.Properties.Resources.btnExport;
            this.picBoxExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxExport.Location = new System.Drawing.Point(68, 117);
            this.picBoxExport.Name = "picBoxExport";
            this.picBoxExport.Size = new System.Drawing.Size(140, 35);
            this.picBoxExport.TabIndex = 5;
            this.picBoxExport.TabStop = false;
            this.picBoxExport.Click += new System.EventHandler(this.picBoxExport_Click);
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUpdate.BackgroundImage = global::Lol_Starter.Properties.Resources.btnUpdate;
            this.picBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxUpdate.Location = new System.Drawing.Point(148, 65);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(90, 35);
            this.picBoxUpdate.TabIndex = 4;
            this.picBoxUpdate.TabStop = false;
            this.picBoxUpdate.Click += new System.EventHandler(this.picBoxUpdate_Click);
            // 
            // FormToolConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.texture_pergament;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFormToolConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormToolConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToolConfig";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormToolConfig_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormToolConfig_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWPath)).EndInit();
            this.pnlFormToolConfig.ResumeLayout(false);
            this.pnlFormToolConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCloseButtonA;
        private System.Windows.Forms.Label lbOptionen;
        private System.Windows.Forms.PictureBox picBoxWoWPath;
        private System.Windows.Forms.Panel pnlFormToolConfig;
        private System.Windows.Forms.PictureBox picBoxUpdate;
        private System.Windows.Forms.Label lbVersionInfo;
        private System.Windows.Forms.Label lbVersionTitle;
        private System.Windows.Forms.PictureBox picBoxExport;
    }
}