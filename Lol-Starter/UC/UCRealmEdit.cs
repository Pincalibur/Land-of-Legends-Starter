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
    public partial class UCRealmEdit : UserControl
    {
        /// <summary>UCRealmEdit
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public delegate void newRealm();
        public event newRealm newRealmInc;
        int id = 0;
        public UCRealmEdit(string adresse, string name, int id)
        {
            InitializeComponent();
            this.id = id;
            tbAdresse.Text = adresse;
            tbName.Text = name;
            this.Name = "Realm Bearbeiten";
        }

        private void picBoxCancel_Click(object sender, EventArgs e)
        {
            ((Form)Parent.Parent).Close();
        }

        private void picBoxOK_Click(object sender, EventArgs e)
        {
            //überprüfen ob Eingaben OK sind
            if (tbName.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Felder müssen ausgefüllt werden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (tbAdresse.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Felder müssen ausgefüllt werden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (Utilitys.RealmIsInRealmList(tbAdresse.Text, id) == true)
            {
                MessageBox.Show("Realm bereits unter dem Namen '" + Utilitys.GetRealmNameToAdresse(tbAdresse.Text) + "' vorhanden.", "Realm bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Properties.Settings.Default.RealmList[id] = tbAdresse.Text;
            Properties.Settings.Default.RealmName[id] = tbName.Text;
            Properties.Settings.Default.Save();
            newRealmInc();
            ((Form)Parent.Parent).Close();
        }

        private void picBoxDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Wollen Sie den Realm wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.RealmList.RemoveAt(id);
                Properties.Settings.Default.RealmName.RemoveAt(id);
                Properties.Settings.Default.Save();
                ((Form)Parent.Parent).Close();
                newRealmInc();
            }
        }
    }
}
