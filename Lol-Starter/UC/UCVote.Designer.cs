namespace Lol_Starter.UC
{
    partial class UCVote
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
            this.picBoxVote1 = new System.Windows.Forms.PictureBox();
            this.picBoxVote2 = new System.Windows.Forms.PictureBox();
            this.picBoxVote4 = new System.Windows.Forms.PictureBox();
            this.picBoxVote3 = new System.Windows.Forms.PictureBox();
            this.cbVotePopUp = new System.Windows.Forms.CheckBox();
            this.picBoxCloseButtonA = new System.Windows.Forms.PictureBox();
            this.lbOptionen = new System.Windows.Forms.Label();
            this.lbVoteSlogan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxVote1
            // 
            this.picBoxVote1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxVote1.BackgroundImage = global::Lol_Starter.Properties.Resources.vote;
            this.picBoxVote1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxVote1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxVote1.Location = new System.Drawing.Point(17, 110);
            this.picBoxVote1.Name = "picBoxVote1";
            this.picBoxVote1.Size = new System.Drawing.Size(90, 60);
            this.picBoxVote1.TabIndex = 10;
            this.picBoxVote1.TabStop = false;
            this.picBoxVote1.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxVote2
            // 
            this.picBoxVote2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxVote2.BackgroundImage = global::Lol_Starter.Properties.Resources.vote2;
            this.picBoxVote2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxVote2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxVote2.Location = new System.Drawing.Point(124, 110);
            this.picBoxVote2.Name = "picBoxVote2";
            this.picBoxVote2.Size = new System.Drawing.Size(88, 60);
            this.picBoxVote2.TabIndex = 11;
            this.picBoxVote2.TabStop = false;
            this.picBoxVote2.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxVote4
            // 
            this.picBoxVote4.BackColor = System.Drawing.Color.Transparent;
            this.picBoxVote4.BackgroundImage = global::Lol_Starter.Properties.Resources.vote4;
            this.picBoxVote4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxVote4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxVote4.Location = new System.Drawing.Point(124, 176);
            this.picBoxVote4.Name = "picBoxVote4";
            this.picBoxVote4.Size = new System.Drawing.Size(88, 51);
            this.picBoxVote4.TabIndex = 23;
            this.picBoxVote4.TabStop = false;
            this.picBoxVote4.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBoxVote3
            // 
            this.picBoxVote3.BackColor = System.Drawing.Color.Transparent;
            this.picBoxVote3.BackgroundImage = global::Lol_Starter.Properties.Resources.vote3;
            this.picBoxVote3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxVote3.Location = new System.Drawing.Point(17, 176);
            this.picBoxVote3.Name = "picBoxVote3";
            this.picBoxVote3.Size = new System.Drawing.Size(88, 57);
            this.picBoxVote3.TabIndex = 22;
            this.picBoxVote3.TabStop = false;
            this.picBoxVote3.Click += new System.EventHandler(this.picBox_Click);
            // 
            // cbVotePopUp
            // 
            this.cbVotePopUp.AutoSize = true;
            this.cbVotePopUp.BackColor = System.Drawing.Color.Transparent;
            this.cbVotePopUp.Checked = true;
            this.cbVotePopUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVotePopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVotePopUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbVotePopUp.Location = new System.Drawing.Point(17, 84);
            this.cbVotePopUp.Name = "cbVotePopUp";
            this.cbVotePopUp.Size = new System.Drawing.Size(204, 20);
            this.cbVotePopUp.TabIndex = 24;
            this.cbVotePopUp.Text = "Erinnerung bei Start aktivieren";
            this.cbVotePopUp.UseVisualStyleBackColor = false;
            this.cbVotePopUp.CheckedChanged += new System.EventHandler(this.cbVotePopUp_CheckedChanged);
            // 
            // picBoxCloseButtonA
            // 
            this.picBoxCloseButtonA.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCloseButtonA.BackgroundImage = global::Lol_Starter.Properties.Resources.closeButton;
            this.picBoxCloseButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxCloseButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCloseButtonA.Location = new System.Drawing.Point(206, 0);
            this.picBoxCloseButtonA.Name = "picBoxCloseButtonA";
            this.picBoxCloseButtonA.Size = new System.Drawing.Size(26, 26);
            this.picBoxCloseButtonA.TabIndex = 26;
            this.picBoxCloseButtonA.TabStop = false;
            this.picBoxCloseButtonA.Click += new System.EventHandler(this.picBoxCloseButtonA_Click);
            // 
            // lbOptionen
            // 
            this.lbOptionen.AutoSize = true;
            this.lbOptionen.BackColor = System.Drawing.Color.Transparent;
            this.lbOptionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptionen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOptionen.Location = new System.Drawing.Point(78, 12);
            this.lbOptionen.Name = "lbOptionen";
            this.lbOptionen.Size = new System.Drawing.Size(74, 31);
            this.lbOptionen.TabIndex = 27;
            this.lbOptionen.Text = "Vote";
            // 
            // lbVoteSlogan
            // 
            this.lbVoteSlogan.AutoSize = true;
            this.lbVoteSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lbVoteSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoteSlogan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbVoteSlogan.Location = new System.Drawing.Point(28, 53);
            this.lbVoteSlogan.Name = "lbVoteSlogan";
            this.lbVoteSlogan.Size = new System.Drawing.Size(184, 18);
            this.lbVoteSlogan.TabIndex = 28;
            this.lbVoteSlogan.Text = "Mehr Votes = Mehr Spieler";
            // 
            // UCVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.lbVoteSlogan);
            this.Controls.Add(this.lbOptionen);
            this.Controls.Add(this.picBoxCloseButtonA);
            this.Controls.Add(this.cbVotePopUp);
            this.Controls.Add(this.picBoxVote4);
            this.Controls.Add(this.picBoxVote2);
            this.Controls.Add(this.picBoxVote3);
            this.Controls.Add(this.picBoxVote1);
            this.Name = "UCVote";
            this.Size = new System.Drawing.Size(232, 239);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVote3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCloseButtonA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxVote1;
        private System.Windows.Forms.PictureBox picBoxVote2;
        private System.Windows.Forms.PictureBox picBoxVote4;
        private System.Windows.Forms.PictureBox picBoxVote3;
        private System.Windows.Forms.CheckBox cbVotePopUp;
        private System.Windows.Forms.PictureBox picBoxCloseButtonA;
        private System.Windows.Forms.Label lbOptionen;
        private System.Windows.Forms.Label lbVoteSlogan;
    }
}
