namespace Lol_Starter.UC
{
    partial class UCBottom
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
            this.components = new System.ComponentModel.Container();
            this.pnlRealmList = new System.Windows.Forms.Panel();
            this.picBoxWoWStart = new System.Windows.Forms.PictureBox();
            this.cbWDB = new System.Windows.Forms.CheckBox();
            this.cbWTF = new System.Windows.Forms.CheckBox();
            this.lbOptions = new System.Windows.Forms.Label();
            this.toolTipWDB = new System.Windows.Forms.ToolTip(this.components);
            this.cbThisClose = new System.Windows.Forms.CheckBox();
            this.pnlWoWStartOptions = new System.Windows.Forms.Panel();
            this.panelPlayerOnline = new System.Windows.Forms.Panel();
            this.labelPlayerVanillaValue = new System.Windows.Forms.Label();
            this.labelPlayerWotlkValue = new System.Windows.Forms.Label();
            this.labelPlayerVanilla = new System.Windows.Forms.Label();
            this.labelPlayerWotlk = new System.Windows.Forms.Label();
            this.lbConnectedPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWStart)).BeginInit();
            this.pnlWoWStartOptions.SuspendLayout();
            this.panelPlayerOnline.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRealmList
            // 
            this.pnlRealmList.AutoScroll = true;
            this.pnlRealmList.Location = new System.Drawing.Point(4, 3);
            this.pnlRealmList.Name = "pnlRealmList";
            this.pnlRealmList.Size = new System.Drawing.Size(211, 80);
            this.pnlRealmList.TabIndex = 0;
            // 
            // picBoxWoWStart
            // 
            this.picBoxWoWStart.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWoWStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxWoWStart.Image = global::Lol_Starter.Properties.Resources.wowstart;
            this.picBoxWoWStart.Location = new System.Drawing.Point(631, 16);
            this.picBoxWoWStart.Name = "picBoxWoWStart";
            this.picBoxWoWStart.Size = new System.Drawing.Size(250, 58);
            this.picBoxWoWStart.TabIndex = 1;
            this.picBoxWoWStart.TabStop = false;
            this.picBoxWoWStart.Click += new System.EventHandler(this.picBoxWoWStart_Click);
            // 
            // cbWDB
            // 
            this.cbWDB.AutoSize = true;
            this.cbWDB.BackColor = System.Drawing.Color.Transparent;
            this.cbWDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWDB.Location = new System.Drawing.Point(3, 21);
            this.cbWDB.Name = "cbWDB";
            this.cbWDB.Size = new System.Drawing.Size(153, 20);
            this.cbWDB.TabIndex = 3;
            this.cbWDB.Text = "WDB Ordner löschen";
            this.toolTipWDB.SetToolTip(this.cbWDB, "Entfernt heruntergeladene Daten des Servers.\r\nSollte aktiviert bleiben, wenn man " +
                    "auf mehreren Servern mit Custom-Items spielt.");
            this.cbWDB.UseVisualStyleBackColor = false;
            this.cbWDB.CheckedChanged += new System.EventHandler(this.cbWDB_CheckedChanged);
            // 
            // cbWTF
            // 
            this.cbWTF.AutoSize = true;
            this.cbWTF.BackColor = System.Drawing.Color.Transparent;
            this.cbWTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWTF.Location = new System.Drawing.Point(3, 40);
            this.cbWTF.Name = "cbWTF";
            this.cbWTF.Size = new System.Drawing.Size(151, 20);
            this.cbWTF.TabIndex = 4;
            this.cbWTF.Text = "WTF Ordner löschen";
            this.toolTipWDB.SetToolTip(this.cbWTF, "Entfernt alle Addoneinstellungen und WoW Konfigurationen.\r\nMan sollte eine Sicher" +
                    "heitskopie erstellen, bevor man diese Option aktiviert.\r\nKann Fehler im Spiel be" +
                    "heben.");
            this.cbWTF.UseVisualStyleBackColor = false;
            this.cbWTF.CheckedChanged += new System.EventHandler(this.cbWTF_CheckedChanged);
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.BackColor = System.Drawing.Color.Transparent;
            this.lbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptions.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOptions.Location = new System.Drawing.Point(3, 0);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(76, 18);
            this.lbOptions.TabIndex = 5;
            this.lbOptions.Text = "Optionen";
            // 
            // toolTipWDB
            // 
            this.toolTipWDB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipWDB.ToolTipTitle = "Hilfe";
            // 
            // cbThisClose
            // 
            this.cbThisClose.AutoSize = true;
            this.cbThisClose.BackColor = System.Drawing.Color.Transparent;
            this.cbThisClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThisClose.Location = new System.Drawing.Point(3, 59);
            this.cbThisClose.Name = "cbThisClose";
            this.cbThisClose.Size = new System.Drawing.Size(186, 20);
            this.cbThisClose.TabIndex = 6;
            this.cbThisClose.Text = "Starter bei WoW schließen";
            this.toolTipWDB.SetToolTip(this.cbThisClose, "Beendet dieses Tool, wenn WoW gestartet wird.");
            this.cbThisClose.UseVisualStyleBackColor = false;
            this.cbThisClose.CheckedChanged += new System.EventHandler(this.cbThisClose_CheckedChanged);
            // 
            // pnlWoWStartOptions
            // 
            this.pnlWoWStartOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWoWStartOptions.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.pnlWoWStartOptions.Controls.Add(this.lbOptions);
            this.pnlWoWStartOptions.Controls.Add(this.cbWDB);
            this.pnlWoWStartOptions.Controls.Add(this.cbThisClose);
            this.pnlWoWStartOptions.Controls.Add(this.cbWTF);
            this.pnlWoWStartOptions.Location = new System.Drawing.Point(223, 3);
            this.pnlWoWStartOptions.Name = "pnlWoWStartOptions";
            this.pnlWoWStartOptions.Size = new System.Drawing.Size(189, 80);
            this.pnlWoWStartOptions.TabIndex = 8;
            // 
            // panelPlayerOnline
            // 
            this.panelPlayerOnline.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.panelPlayerOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayerOnline.Controls.Add(this.labelPlayerVanillaValue);
            this.panelPlayerOnline.Controls.Add(this.labelPlayerWotlkValue);
            this.panelPlayerOnline.Controls.Add(this.labelPlayerVanilla);
            this.panelPlayerOnline.Controls.Add(this.labelPlayerWotlk);
            this.panelPlayerOnline.Controls.Add(this.lbConnectedPlayer);
            this.panelPlayerOnline.Location = new System.Drawing.Point(424, 16);
            this.panelPlayerOnline.Name = "panelPlayerOnline";
            this.panelPlayerOnline.Size = new System.Drawing.Size(194, 58);
            this.panelPlayerOnline.TabIndex = 28;
            // 
            // labelPlayerVanillaValue
            // 
            this.labelPlayerVanillaValue.AutoSize = true;
            this.labelPlayerVanillaValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerVanillaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerVanillaValue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayerVanillaValue.Location = new System.Drawing.Point(102, 34);
            this.labelPlayerVanillaValue.Name = "labelPlayerVanillaValue";
            this.labelPlayerVanillaValue.Size = new System.Drawing.Size(65, 15);
            this.labelPlayerVanillaValue.TabIndex = 30;
            this.labelPlayerVanillaValue.Text = "0 Spieler";
            // 
            // labelPlayerWotlkValue
            // 
            this.labelPlayerWotlkValue.AutoSize = true;
            this.labelPlayerWotlkValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerWotlkValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerWotlkValue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayerWotlkValue.Location = new System.Drawing.Point(102, 19);
            this.labelPlayerWotlkValue.Name = "labelPlayerWotlkValue";
            this.labelPlayerWotlkValue.Size = new System.Drawing.Size(65, 15);
            this.labelPlayerWotlkValue.TabIndex = 29;
            this.labelPlayerWotlkValue.Text = "0 Spieler";
            // 
            // labelPlayerVanilla
            // 
            this.labelPlayerVanilla.AutoSize = true;
            this.labelPlayerVanilla.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerVanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerVanilla.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayerVanilla.Location = new System.Drawing.Point(3, 34);
            this.labelPlayerVanilla.Name = "labelPlayerVanilla";
            this.labelPlayerVanilla.Size = new System.Drawing.Size(82, 15);
            this.labelPlayerVanilla.TabIndex = 28;
            this.labelPlayerVanilla.Text = "WoW Vanilla: ";
            // 
            // labelPlayerWotlk
            // 
            this.labelPlayerWotlk.AutoSize = true;
            this.labelPlayerWotlk.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerWotlk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerWotlk.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayerWotlk.Location = new System.Drawing.Point(3, 19);
            this.labelPlayerWotlk.Name = "labelPlayerWotlk";
            this.labelPlayerWotlk.Size = new System.Drawing.Size(79, 15);
            this.labelPlayerWotlk.TabIndex = 27;
            this.labelPlayerWotlk.Text = "WoW 3.3.5a: ";
            // 
            // lbConnectedPlayer
            // 
            this.lbConnectedPlayer.AutoSize = true;
            this.lbConnectedPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbConnectedPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectedPlayer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbConnectedPlayer.Location = new System.Drawing.Point(3, 0);
            this.lbConnectedPlayer.Name = "lbConnectedPlayer";
            this.lbConnectedPlayer.Size = new System.Drawing.Size(114, 16);
            this.lbConnectedPlayer.TabIndex = 26;
            this.lbConnectedPlayer.Text = "Spieler Online :";
            // 
            // UCBottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg;
            this.Controls.Add(this.panelPlayerOnline);
            this.Controls.Add(this.pnlWoWStartOptions);
            this.Controls.Add(this.picBoxWoWStart);
            this.Controls.Add(this.pnlRealmList);
            this.Name = "UCBottom";
            this.Size = new System.Drawing.Size(897, 87);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCBottom_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWoWStart)).EndInit();
            this.pnlWoWStartOptions.ResumeLayout(false);
            this.pnlWoWStartOptions.PerformLayout();
            this.panelPlayerOnline.ResumeLayout(false);
            this.panelPlayerOnline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRealmList;
        private System.Windows.Forms.CheckBox cbWDB;
        private System.Windows.Forms.CheckBox cbWTF;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.ToolTip toolTipWDB;
        private System.Windows.Forms.PictureBox picBoxWoWStart;
        private System.Windows.Forms.CheckBox cbThisClose;
        private System.Windows.Forms.Panel pnlWoWStartOptions;
        private System.Windows.Forms.Panel panelPlayerOnline;
        private System.Windows.Forms.Label labelPlayerVanillaValue;
        private System.Windows.Forms.Label labelPlayerWotlkValue;
        private System.Windows.Forms.Label labelPlayerVanilla;
        private System.Windows.Forms.Label labelPlayerWotlk;
        private System.Windows.Forms.Label lbConnectedPlayer;
    }
}
