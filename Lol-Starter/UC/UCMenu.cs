using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lol_Starter.UC
{
    public partial class UCMenu : UserControl
    {
        /// <summary>UCMenu
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public UCMenu()
        {
            InitializeComponent();
            picBoxAccount.Name = "http://www.landoflegends.de/ucp.php?mode=register";
            picBoxHelp.Name = "http://www.landoflegends.de/viewtopic.php?f=48&t=28&p=32#p32";
            picBoxBugReport.Name = "http://bugs.landoflegends.de/login_page.php";
            picBoxGames.Name = "http://games.landoflegends.de/index.php/alle-server";
            wmpRadio.URL = Properties.Settings.Default.RadioPath;
            wmpRadio.settings.autoStart = Properties.Settings.Default.PlayRadioOnStart;
            wmpRadio.settings.volume = Properties.Settings.Default.RadioVolume;
            wmpRadio.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmpRadio_PlayStateChange);
            wmpRadio.windowlessVideo = true;
            lbAllianceGuildName.Text = Properties.Settings.Default.AllianceGuildName;
            lbHordGuildText.Text = Properties.Settings.Default.HordeGuildName;
        }

        void wmpRadio_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped || e.newState == 2)
            {
                Properties.Settings.Default.PlayRadioOnStart = false;
                Properties.Settings.Default.Save();
            }
            if (e.newState == 9)
            {
                Properties.Settings.Default.PlayRadioOnStart = true;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>picBox_Click
        /// Für einfache Links. Wird nur der picBox.Name als URL abgerufen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            System.Diagnostics.Process.Start(picBox.Name);
        }

        private void picBoxArsenal_Click(object sender, EventArgs e)
        {
            UCArsenal ucArsenal = new UCArsenal();
            FormPopUp popUp = new FormPopUp(ucArsenal);
            popUp.ShowDialog();
        }

        /// <summary>UpdatePlayerOnline
        /// Erneuert die aktuellen Spielerzahlen
        /// </summary>
        

        private void picBoxVote_Click(object sender, EventArgs e)
        {
            UCVote ucVote = new UCVote();
            FormPopUp popUp = new FormPopUp(ucVote);
            popUp.ShowDialog();
        }

        private void AllianceGuild_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.AllianceGuildLink);
        }

        private void HordeGuild_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.HordeGuildLink);
        }

        private void GuildConfig_Click(object sender, EventArgs e)
        {
            UCGuildConfig guildConfig;
            if (sender == picBoxAllianceConfig)
            {
                guildConfig = new UCGuildConfig(true);
            }
            else
            {
                guildConfig = new UCGuildConfig(false);
            }
            guildConfig.GuildChangedEvent += new UCGuildConfig.GuildChanged(guildConfig_GuildChangedEvent);
            FormPopUp popUp = new FormPopUp(guildConfig);
            popUp.ShowDialog();
        }

        void guildConfig_GuildChangedEvent()
        {
            lbAllianceGuildName.Text = Properties.Settings.Default.AllianceGuildName;
            lbHordGuildText.Text = Properties.Settings.Default.HordeGuildName;
        }
    }
}
