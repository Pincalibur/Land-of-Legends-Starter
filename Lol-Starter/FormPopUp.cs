using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lol_Starter
{
    public partial class FormPopUp : Form
    {
        /// <summary>FormPopUp
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        Point mousePosition = new Point();
        public FormPopUp(UserControl uc)
        {
            InitializeComponent();
            this.Size = new Size(uc.Size.Width + 2, uc.Size.Height + 2);
            pnlPopUp.Size = new Size(uc.Size.Width + 2, uc.Size.Height + 2);
            uc.MouseDown += new MouseEventHandler(FormPopUp_MouseDown);
            uc.MouseMove += new MouseEventHandler(FormPopUp_MouseMove);
            uc.Location = new Point(1, 1);
            this.Text = uc.Name;
            pnlPopUp.Controls.Add(uc);
        }

        private void FormPopUp_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void FormPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousemove = new Point(mousePosition.X - e.X, mousePosition.Y - e.Y);
                this.Location = new Point(this.Location.X - mousemove.X, this.Location.Y - mousemove.Y);
            }
        }
    }
}
