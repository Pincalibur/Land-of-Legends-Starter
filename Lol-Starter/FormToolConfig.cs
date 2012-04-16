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
    public partial class FormToolConfig : Form
    {
        Point mousePosition = new Point();
        public FormToolConfig()
        {
            InitializeComponent();
        }

        private void FormToolConfig_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void FormToolConfig_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousemove = new Point(mousePosition.X - e.X, mousePosition.Y - e.Y);
                this.Location = new Point(this.Location.X - mousemove.X, this.Location.Y - mousemove.Y);
            }
        }

        private void picBoxCloseButtonA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picBoxCloseButtonA_MouseHover(object sender, EventArgs e)
        {
            picBoxCloseButtonA.Image = Properties.Resources.closeButtonHighlight;
        }

        private void picBoxCloseButtonA_MouseLeave(object sender, EventArgs e)
        {
            picBoxCloseButtonA.Image = Properties.Resources.closeButton;
        }

        /// <summary>
        /// WoW Pfad ändern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxWoWPath_Click(object sender, EventArgs e)
        {
            string newPath = Utilitys.ChooseWowPath();
            if (Utilitys.CheckForWowExeInPath(newPath))
            {
                Properties.Settings.Default.WowPath = newPath;
                Properties.Settings.Default.Save();
                MessageBox.Show("WoW Pfad wurde erfolgreich geändert.", "Erfolg!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Link zum Forum Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.landoflegends.de/viewtopic.php?f=34&t=18381");
        }

        /// <summary>
        /// Realmlist Export
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxExport_Click(object sender, EventArgs e)
        {
            Utilitys.RealmListExport();
        }
    }
}
