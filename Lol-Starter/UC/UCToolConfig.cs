using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lol_Starter.UC
{
    public partial class UCToolConfig : UserControl
    {
        /// <summary>UCToolConfig
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        bool userClicked = false;
        public UCToolConfig()
        {
            InitializeComponent();
            this.Name = "Optionen";
            cbBrowser.Checked = Properties.Settings.Default.BrowserActiv;
            userClicked = true;
            this.comboBoxBrowserEntrys.Text = Properties.Settings.Default.NewsEntrysCount.ToString();
        }

        private void picBoxCloseButtonA_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent.Parent).Close();
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

        private void cbBrowser_CheckedChanged(object sender, EventArgs e)
        {
            if (userClicked)
            {
                Properties.Settings.Default.BrowserActiv = cbBrowser.Checked;
                Properties.Settings.Default.Save();
                MessageBox.Show("Änderung erfordert einen Neustart.", "Änderung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picBoxConfigReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sind Sie sicher, dass Sie alle Einstellungen zurücksetzen wollen?\nDie Anwendung muss anschließend manuell neugestartet werden.", "Wirklich sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }

        private void comboBoxBrowserEntrys_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBrowserEntrys.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.NewsEntrysCount = 1;
                    break;
                case 1:
                    Properties.Settings.Default.NewsEntrysCount = 3;
                    break;
                case 2:
                    Properties.Settings.Default.NewsEntrysCount = 5;
                    break;
                case 3:
                    Properties.Settings.Default.NewsEntrysCount = 10;
                    break;
            }
            Properties.Settings.Default.Save();
        }
    }
}
