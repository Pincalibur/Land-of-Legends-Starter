namespace Lol_Starter.UC
{
    partial class UCNewsFeed
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
            this.pnlNewsFeed = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlNewsFeed
            // 
            this.pnlNewsFeed.AutoScroll = true;
            this.pnlNewsFeed.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewsFeed.Location = new System.Drawing.Point(0, 0);
            this.pnlNewsFeed.Name = "pnlNewsFeed";
            this.pnlNewsFeed.Size = new System.Drawing.Size(676, 366);
            this.pnlNewsFeed.TabIndex = 0;
            // 
            // UCNewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_light;
            this.Controls.Add(this.pnlNewsFeed);
            this.Name = "UCNewsFeed";
            this.Size = new System.Drawing.Size(676, 366);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewsFeed;

    }
}
