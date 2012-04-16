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
    public partial class UCGuildConfig : UserControl
    {
        bool isAlliance = false;
        public delegate void GuildChanged();
        public event GuildChanged GuildChangedEvent;
        public UCGuildConfig(bool isAlliance)
        {
            InitializeComponent();
            this.isAlliance = isAlliance;
            if (isAlliance)
            {
                tbAdresse.Text = Properties.Settings.Default.AllianceGuildLink;
                tbName.Text = Properties.Settings.Default.AllianceGuildName;
            }
            else
            {
                tbAdresse.Text = Properties.Settings.Default.HordeGuildLink;
                tbName.Text = Properties.Settings.Default.HordeGuildName;
            }
        }

        private void picBoxCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent.Parent).Close();
        }

        private void picBoxOK_Click(object sender, EventArgs e)
        {
            if (tbAdresse.Text == "")
            {
                MessageBox.Show("Feld Gilden-Homepage darf nicht leer sein."); return;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Feld Name darf nicht leer sein."); return;
            }
            if (isAlliance)
            {
                Properties.Settings.Default.AllianceGuildLink = tbAdresse.Text;
                Properties.Settings.Default.AllianceGuildName = tbName.Text;
            }
            else
            {
                Properties.Settings.Default.HordeGuildLink = tbAdresse.Text;
                Properties.Settings.Default.HordeGuildName = tbName.Text;
            }
            Properties.Settings.Default.Save();
            GuildChangedEvent();
            ((Form)this.Parent.Parent).Close();
        }
    }
}
