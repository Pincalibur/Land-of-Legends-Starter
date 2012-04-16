namespace Lol_Starter
{
    partial class FormRealmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealmAdd));
            this.pnlRealmAdd = new System.Windows.Forms.Panel();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.picBoxOK = new System.Windows.Forms.PictureBox();
            this.picBoxCancel = new System.Windows.Forms.PictureBox();
            this.pnlRealmAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRealmAdd
            // 
            this.pnlRealmAdd.BackgroundImage = global::Lol_Starter.Properties.Resources.texture_pergament;
            this.pnlRealmAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRealmAdd.Controls.Add(this.lbAdresse);
            this.pnlRealmAdd.Controls.Add(this.lbName);
            this.pnlRealmAdd.Controls.Add(this.tbAdresse);
            this.pnlRealmAdd.Controls.Add(this.tbName);
            this.pnlRealmAdd.Controls.Add(this.picBoxOK);
            this.pnlRealmAdd.Controls.Add(this.picBoxCancel);
            this.pnlRealmAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlRealmAdd.Name = "pnlRealmAdd";
            this.pnlRealmAdd.Size = new System.Drawing.Size(284, 162);
            this.pnlRealmAdd.TabIndex = 0;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(24, 71);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(62, 16);
            this.lbAdresse.TabIndex = 5;
            this.lbAdresse.Text = "Adresse:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(24, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name:";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(92, 70);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(156, 20);
            this.tbAdresse.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 2;
            // 
            // picBoxOK
            // 
            this.picBoxOK.Image = global::Lol_Starter.Properties.Resources.btnOK;
            this.picBoxOK.Location = new System.Drawing.Point(27, 114);
            this.picBoxOK.Name = "picBoxOK";
            this.picBoxOK.Size = new System.Drawing.Size(90, 35);
            this.picBoxOK.TabIndex = 1;
            this.picBoxOK.TabStop = false;
            this.picBoxOK.Click += new System.EventHandler(this.picBoxOK_Click);
            // 
            // picBoxCancel
            // 
            this.picBoxCancel.Image = global::Lol_Starter.Properties.Resources.btnCancel;
            this.picBoxCancel.Location = new System.Drawing.Point(158, 114);
            this.picBoxCancel.Name = "picBoxCancel";
            this.picBoxCancel.Size = new System.Drawing.Size(90, 35);
            this.picBoxCancel.TabIndex = 0;
            this.picBoxCancel.TabStop = false;
            this.picBoxCancel.Click += new System.EventHandler(this.picBoxCancel_Click);
            // 
            // FormRealmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.pnlRealmAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRealmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Realm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRealmAdd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRealmAdd_MouseMove);
            this.pnlRealmAdd.ResumeLayout(false);
            this.pnlRealmAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRealmAdd;
        private System.Windows.Forms.PictureBox picBoxOK;
        private System.Windows.Forms.PictureBox picBoxCancel;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbName;
    }
}