namespace Lol_Starter.UC
{
    partial class UCRealmEdit
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.picBoxOK = new System.Windows.Forms.PictureBox();
            this.picBoxCancel = new System.Windows.Forms.PictureBox();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(56, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 6;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(42, 68);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(62, 16);
            this.lbAdresse.TabIndex = 7;
            this.lbAdresse.Text = "Adresse:";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(120, 67);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(156, 20);
            this.tbAdresse.TabIndex = 8;
            // 
            // picBoxOK
            // 
            this.picBoxOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOK.Image = global::Lol_Starter.Properties.Resources.btnOK;
            this.picBoxOK.Location = new System.Drawing.Point(14, 118);
            this.picBoxOK.Name = "picBoxOK";
            this.picBoxOK.Size = new System.Drawing.Size(90, 35);
            this.picBoxOK.TabIndex = 9;
            this.picBoxOK.TabStop = false;
            this.picBoxOK.Click += new System.EventHandler(this.picBoxOK_Click);
            // 
            // picBoxCancel
            // 
            this.picBoxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCancel.Image = global::Lol_Starter.Properties.Resources.btnCancel;
            this.picBoxCancel.Location = new System.Drawing.Point(129, 118);
            this.picBoxCancel.Name = "picBoxCancel";
            this.picBoxCancel.Size = new System.Drawing.Size(90, 35);
            this.picBoxCancel.TabIndex = 10;
            this.picBoxCancel.TabStop = false;
            this.picBoxCancel.Click += new System.EventHandler(this.picBoxCancel_Click);
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxDelete.Image = global::Lol_Starter.Properties.Resources.btnDelete;
            this.picBoxDelete.Location = new System.Drawing.Point(240, 118);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(90, 35);
            this.picBoxDelete.TabIndex = 11;
            this.picBoxDelete.TabStop = false;
            this.picBoxDelete.Click += new System.EventHandler(this.picBoxDelete_Click);
            // 
            // UCRealmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.picBoxDelete);
            this.Controls.Add(this.picBoxCancel);
            this.Controls.Add(this.picBoxOK);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "UCRealmEdit";
            this.Size = new System.Drawing.Size(352, 169);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.PictureBox picBoxOK;
        private System.Windows.Forms.PictureBox picBoxCancel;
        private System.Windows.Forms.PictureBox picBoxDelete;
    }
}
