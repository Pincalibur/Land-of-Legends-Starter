using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Lol_Starter.UC
{
    public partial class UCBottom : UserControl
    {
        /// <summary>UCBottom
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        UCRealmlist ucRealmlist = new UCRealmlist();
        Pen pen = new Pen(Brushes.SaddleBrown, 1);
        int realmListHeightPos;
        int realmListWidthPos;
        int optionsHeightPos;
        int optionsWidthPos;
            
        public UCBottom()
        {
            InitializeComponent();
            pnlRealmList.Controls.Add(ucRealmlist);
            realmListHeightPos = pnlRealmList.Location.X + pnlRealmList.Height - 1;
            realmListWidthPos = pnlRealmList.Location.Y + pnlRealmList.Width + 1;
            optionsHeightPos = pnlWoWStartOptions.Location.Y + pnlWoWStartOptions.Height;
            optionsWidthPos = pnlWoWStartOptions.Location.X + pnlWoWStartOptions.Width;
            cbWDB.Checked = Properties.Settings.Default.WDBDelete;
            cbWTF.Checked = Properties.Settings.Default.WTFDelete;
            cbThisClose.Checked = Properties.Settings.Default.StarterClose;
            UpdatePlayerOnline();
        }

        private void picBoxWoWStart_Click(object sender, EventArgs e)
        {
            //WDB delete
            if (cbWDB.Checked)
            {
                if (Directory.Exists(Properties.Settings.Default.WowPath + "\\Cache"))
                    Directory.Delete(Properties.Settings.Default.WowPath + "\\Cache", true);
            }
            //WTF delete
            if (cbWTF.Checked)
            {
                if (Directory.Exists(Properties.Settings.Default.WowPath + "\\WTF"))
                    Directory.Delete(Properties.Settings.Default.WowPath + "\\WTF", true);
            }
            //WoW Starten
            string adresse = ucRealmlist.GetCheckedRealmAdresse();
            Utilitys.startWoW(Properties.Settings.Default.WowPath, adresse);

            if (cbThisClose.Checked)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Zeichnet den Rahmen um das UCRealmlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCBottom_Paint(object sender, PaintEventArgs e)
        {
            //Rahmen Zeichnen pnl RealmList
            e.Graphics.DrawLine(pen, pnlRealmList.Location.X - 1, pnlRealmList.Location.Y - 1, realmListWidthPos, pnlRealmList.Location.Y - 1);
            e.Graphics.DrawLine(pen, pnlRealmList.Location.X - 1, pnlRealmList.Location.Y - 1, pnlRealmList.Location.X - 1, realmListHeightPos);
            e.Graphics.DrawLine(pen, realmListWidthPos, pnlRealmList.Location.Y - 1, realmListWidthPos, realmListHeightPos);
            e.Graphics.DrawLine(pen, pnlRealmList.Location.X - 1, realmListHeightPos, realmListWidthPos, realmListHeightPos);

            //Rahmen Zeichnen pnl Options
            e.Graphics.DrawLine(pen, pnlWoWStartOptions.Location.X - 1, pnlWoWStartOptions.Location.Y - 1, optionsWidthPos, pnlWoWStartOptions.Location.Y - 1);
            e.Graphics.DrawLine(pen, pnlWoWStartOptions.Location.X - 1, pnlWoWStartOptions.Location.Y - 1, pnlWoWStartOptions.Location.X - 1, optionsHeightPos);
            e.Graphics.DrawLine(pen, optionsWidthPos, pnlWoWStartOptions.Location.Y - 1, optionsWidthPos, optionsHeightPos);
            e.Graphics.DrawLine(pen, pnlWoWStartOptions.Location.X - 1, optionsHeightPos, optionsWidthPos, optionsHeightPos);
        }



        /// <summary>
        /// Fügt den neuen Realm der RealmList hinzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="adresse"></param>
        private void NewRealmInc()
        {
            ucRealmlist.UpdateRealms();
        }

        private void cbWDB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WDBDelete = cbWDB.Checked;
            Properties.Settings.Default.Save();
        }
        private void cbWTF_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WTFDelete = cbWTF.Checked;
            Properties.Settings.Default.Save();
        }
        private void cbThisClose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StarterClose = cbThisClose.Checked;
            Properties.Settings.Default.Save();
        }

        public void UpdateRealmStatus()
        {
            ucRealmlist.UpdateRealmStatus();
        }

        public void UpdatePlayerOnline()
        {
            try
            {
                string url = "http://www.landoflegends.de/cache/playersonline.wow";
                string playerWotlk = "";
                string playerVanilla = "";
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.Timeout = 3000;
                HttpWebResponse webResponse = (HttpWebResponse)httpRequest.GetResponse();
                StreamReader responseStream = new StreamReader(webResponse.GetResponseStream());
                string content = responseStream.ReadToEnd();
                string[] splitString = content.Split(new char[] { ':', '"' });
                playerWotlk = splitString[9];
                playerVanilla = splitString[17];

                labelPlayerVanillaValue.Text = playerVanilla + "  Spieler";
                labelPlayerWotlkValue.Text = playerWotlk + "  Spieler";
            }
            catch
            {
            }
        }
    }
}
