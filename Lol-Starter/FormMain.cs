using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lol_Starter.UC;
using System.Threading;

namespace Lol_Starter
{
    public partial class FormMain : Form
    {
        /// <summary>FormMain
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        Point mousePosition = new Point();
        UCTitle ucTitle = new UCTitle();
        UCBottom ucBottom = new UCBottom();
        UCMenu ucMenu = new UCMenu();
        UCNewsFeed ucNewsFeed = new UCNewsFeed();
        System.Windows.Forms.Timer updatePlayerCount;
        System.Windows.Forms.Timer updateServerStatus;
        public FormMain()
        {
            InitializeComponent();
            //Title
            ucTitle.pnlTitlePicB.MouseDown += new MouseEventHandler(Main_MouseDown);
            ucTitle.pnlTitlePicB.MouseMove += new MouseEventHandler(Main_MouseMove);
            ucTitle.picBoxTitleA.MouseDown += new MouseEventHandler(Main_MouseDown);
            ucTitle.picBoxTitleA.MouseMove += new MouseEventHandler(Main_MouseMove);
            this.pnlTitle.Controls.Add(ucTitle);

            //Bottom
            ucBottom.MouseDown += new MouseEventHandler(Main_MouseDown);
            ucBottom.MouseMove += new MouseEventHandler(Main_MouseMove);
            this.pnlButtom.Controls.Add(ucBottom);

            //Menu
            ucMenu.MouseDown += new MouseEventHandler(Main_MouseDown);
            ucMenu.MouseMove += new MouseEventHandler(Main_MouseMove);
            splitContMain.Panel1.Controls.Add(ucMenu);

            //News
            if (Properties.Settings.Default.BrowserActiv)
            {
                ucNewsFeed.MouseDown += new MouseEventHandler(Main_MouseDown);
                ucNewsFeed.MouseMove += new MouseEventHandler(Main_MouseMove);
                splitContMain.Panel2.Controls.Add(ucNewsFeed);
            }

            //UpdatePlayerCount
            updatePlayerCount = new System.Windows.Forms.Timer();
            updatePlayerCount.Interval = 1000 * 60 * 5; // 5 Minuten
            updatePlayerCount.Tick += new EventHandler(updatePlayerCount_Tick);
            updatePlayerCount.Start();

            //UpdateServerOnline
            updateServerStatus = new System.Windows.Forms.Timer();
            updatePlayerCount.Interval = 1000 * 60 * 1; // 1 Minute
            updatePlayerCount.Tick += new EventHandler(updateServerStatus_Tick);
            updatePlayerCount.Start();
            ucBottom.UpdateRealmStatus();

            //Über LightBrowser scrollen
            this.MouseWheel += new MouseEventHandler(FormMain_MouseWheel);
        }

        void FormMain_MouseWheel(object sender, MouseEventArgs e)
        {
            ucNewsFeed.Focus();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousemove = new Point(mousePosition.X - e.X, mousePosition.Y - e.Y);
                this.Location = new Point(this.Location.X - mousemove.X, this.Location.Y - mousemove.Y); 
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PlayRadioOnStart == false) ucMenu.wmpRadio.Ctlcontrols.stop();
            else ucMenu.wmpRadio.Ctlcontrols.play();

            if (Properties.Settings.Default.VoteReminding)
            {
                UCVote ucVote = new UCVote();
                FormPopUp popUp = new FormPopUp(ucVote);
                popUp.ShowDialog();
            }

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.RadioVolume = ucMenu.wmpRadio.settings.volume;
            Properties.Settings.Default.Save();
            updatePlayerCount.Stop();
        }

        private void updatePlayerCount_Tick(object sender, EventArgs e)
        {
            ucBottom.UpdatePlayerOnline();
        }

        private void updateServerStatus_Tick(object sender, EventArgs e)
        {
            ucBottom.UpdateRealmStatus();
        }
    }
}
