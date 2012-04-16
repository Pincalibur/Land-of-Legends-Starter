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
    public partial class UCRealmAdd : UserControl
    {
        /// <summary>UCRealmAdd
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
        public UCRealmAdd()
        {
            InitializeComponent();
            this.Name = "Realm Hinzufügen";
        }

        private void picBoxCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent.Parent).Close();
        }

        private void picBoxOK_Click(object sender, EventArgs e)
        {
            //überprüfen ob Eingaben OK sind
            string filteredAdresse = "";
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
            filteredAdresse = Utilitys.FilterRealmAdresse(tbAdresse.Text);
            if (filteredAdresse == "")
            {
                MessageBox.Show("Sie haben keine gültige Adresse angegeben.\nAchten sie auf korrekte Leerzeichen und auf die Vollständigkeit der Adresse.", "Adresse ist ungültig", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            filteredAdresse = "set realmlist " + filteredAdresse;
            if (Utilitys.RealmIsInRealmList(filteredAdresse) == true)
            {
                MessageBox.Show("Realm bereits unter dem Namen '" + Utilitys.GetRealmNameToAdresse(filteredAdresse) + "' vorhanden.", "Realm bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Properties.Settings.Default.RealmList.Add(filteredAdresse);
            Properties.Settings.Default.RealmName.Add(tbName.Text);
            Properties.Settings.Default.Save();
            newRealmInc();
            ((Form)this.Parent.Parent).Close();
        }
    }
}
