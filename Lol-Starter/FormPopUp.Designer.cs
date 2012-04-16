namespace Lol_Starter
{
    partial class FormPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopUp));
            this.pnlPopUp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPopUp
            // 
            this.pnlPopUp.Location = new System.Drawing.Point(0, 0);
            this.pnlPopUp.Name = "pnlPopUp";
            this.pnlPopUp.Size = new System.Drawing.Size(284, 262);
            this.pnlPopUp.TabIndex = 0;
            this.pnlPopUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPopUp_MouseDown);
            this.pnlPopUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPopUp_MouseMove);
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlPopUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopUp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPopUp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPopUp_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPopUp;
    }
}