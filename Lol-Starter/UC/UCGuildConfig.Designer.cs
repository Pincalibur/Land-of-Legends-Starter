namespace Lol_Starter.UC
{
    partial class UCGuildConfig
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
            this.picBoxCancel = new System.Windows.Forms.PictureBox();
            this.picBoxOK = new System.Windows.Forms.PictureBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCancel
            // 
            this.picBoxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCancel.Image = global::Lol_Starter.Properties.Resources.btnCancel;
            this.picBoxCancel.Location = new System.Drawing.Point(161, 109);
            this.picBoxCancel.Name = "picBoxCancel";
            this.picBoxCancel.Size = new System.Drawing.Size(90, 35);
            this.picBoxCancel.TabIndex = 16;
            this.picBoxCancel.TabStop = false;
            this.picBoxCancel.Click += new System.EventHandler(this.picBoxCancel_Click);
            // 
            // picBoxOK
            // 
            this.picBoxOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOK.Image = global::Lol_Starter.Properties.Resources.btnOK;
            this.picBoxOK.Location = new System.Drawing.Point(30, 109);
            this.picBoxOK.Name = "picBoxOK";
            this.picBoxOK.Size = new System.Drawing.Size(90, 35);
            this.picBoxOK.TabIndex = 15;
            this.picBoxOK.TabStop = false;
            this.picBoxOK.Click += new System.EventHandler(this.picBoxOK_Click);
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(95, 65);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(156, 20);
            this.tbAdresse.TabIndex = 14;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(9, 60);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(80, 32);
            this.lbAdresse.TabIndex = 13;
            this.lbAdresse.Text = "Gilden-\r\nHomepage:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(27, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name:";
            // 
            // UCGuildConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.picBoxCancel);
            this.Controls.Add(this.picBoxOK);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "UCGuildConfig";
            this.Size = new System.Drawing.Size(286, 163);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCancel;
        private System.Windows.Forms.PictureBox picBoxOK;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
    }
}
