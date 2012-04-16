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
    public partial class UCVote : UserControl
    {
        /// <summary>UCVote
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public UCVote()
        {
            InitializeComponent();
            picBoxVote1.Name = "http://www.gamesites200.com/wowprivate/in.php?id=7670";
            picBoxVote2.Name = "http://www.koobold.de/index.php?a=in&u=darkman";
            picBoxVote3.Name = "http://www.top100arena.com/in.asp?id=37170&incentive=11927";
            picBoxVote4.Name = "http://www.wowstatus.net/in.php?server=63556&user=11927";
            cbVotePopUp.Checked = Properties.Settings.Default.VoteReminding;
        }

        private void cbVotePopUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VoteReminding = cbVotePopUp.Checked;
            Properties.Settings.Default.Save();
        }

        private void picBoxCloseButtonA_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent.Parent).Close();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            System.Diagnostics.Process.Start(picBox.Name);
        }
    }
}
