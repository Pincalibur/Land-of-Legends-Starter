namespace Lol_Starter.UC
{
    partial class UCArsenal
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbOptionen = new System.Windows.Forms.Label();
            this.picBoxOK = new System.Windows.Forms.PictureBox();
            this.picBoxCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 20);
            this.tbName.TabIndex = 0;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(17, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbOptionen
            // 
            this.lbOptionen.AutoSize = true;
            this.lbOptionen.BackColor = System.Drawing.Color.Transparent;
            this.lbOptionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptionen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOptionen.Location = new System.Drawing.Point(74, 11);
            this.lbOptionen.Name = "lbOptionen";
            this.lbOptionen.Size = new System.Drawing.Size(113, 31);
            this.lbOptionen.TabIndex = 4;
            this.lbOptionen.Text = "Arsenal";
            // 
            // picBoxOK
            // 
            this.picBoxOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOK.Image = global::Lol_Starter.Properties.Resources.btnOK;
            this.picBoxOK.Location = new System.Drawing.Point(32, 90);
            this.picBoxOK.Name = "picBoxOK";
            this.picBoxOK.Size = new System.Drawing.Size(90, 35);
            this.picBoxOK.TabIndex = 10;
            this.picBoxOK.TabStop = false;
            this.picBoxOK.Click += new System.EventHandler(this.picBoxOK_Click);
            // 
            // picBoxCancel
            // 
            this.picBoxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCancel.Image = global::Lol_Starter.Properties.Resources.btnCancel;
            this.picBoxCancel.Location = new System.Drawing.Point(149, 90);
            this.picBoxCancel.Name = "picBoxCancel";
            this.picBoxCancel.Size = new System.Drawing.Size(90, 35);
            this.picBoxCancel.TabIndex = 11;
            this.picBoxCancel.TabStop = false;
            this.picBoxCancel.Click += new System.EventHandler(this.picBoxCancel_Click);
            // 
            // UCArsenal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.picBoxCancel);
            this.Controls.Add(this.picBoxOK);
            this.Controls.Add(this.lbOptionen);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Name = "UCArsenal";
            this.Size = new System.Drawing.Size(274, 136);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbOptionen;
        private System.Windows.Forms.PictureBox picBoxOK;
        private System.Windows.Forms.PictureBox picBoxCancel;
    }
}
