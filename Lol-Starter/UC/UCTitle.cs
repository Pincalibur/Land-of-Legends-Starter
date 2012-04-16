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
    public partial class UCTitle : UserControl
    {
        /// <summary>UCTitle
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public UCTitle()
        {
            InitializeComponent();
            picBoxFacebook.Name = "http://www.facebook.com/Landoflegendswow";
            picBoxTwitter.Name = "http://twitter.com/#!/landoflegends";
            picBoxGooglep.Name = "http://plus.google.com/u/0/102997910509734441626";
            picBoxSteamgrp.Name = "http://steamcommunity.com/groups/LandOfLegends-Games";
        }

        private void picBoxCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picBoxConfig_Click(object sender, EventArgs e)
        {
            UCToolConfig ucTool = new UCToolConfig();
            FormPopUp popUp = new FormPopUp(ucTool);
            popUp.ShowDialog();
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

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent.Parent.Parent).WindowState = FormWindowState.Minimized;
        }
    }
}
