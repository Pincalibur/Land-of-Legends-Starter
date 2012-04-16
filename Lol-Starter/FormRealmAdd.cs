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
    public partial class FormRealmAdd : Form
    {
        Point mousePosition = new Point();
        public delegate void newRealm(object sender, string name, string adresse);
        public event newRealm newRealmInc;
        public FormRealmAdd()
        {
            InitializeComponent();
            pnlRealmAdd.MouseDown += new MouseEventHandler(FormRealmAdd_MouseDown);
            pnlRealmAdd.MouseMove += new MouseEventHandler(FormRealmAdd_MouseMove);
        }

        private void FormRealmAdd_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void FormRealmAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousemove = new Point(mousePosition.X - e.X, mousePosition.Y - e.Y);
                this.Location = new Point(this.Location.X - mousemove.X, this.Location.Y - mousemove.Y);
            }
        }

        private void picBoxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxOK_Click(object sender, EventArgs e)
        {
            //überprüfen ob Eingaben OK sind
            string filteredAdresse = "";
            if (tbName.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen","Felder müssen ausgefüllt werden",MessageBoxButtons.OK,MessageBoxIcon.Stop);
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
            newRealmInc(this, tbName.Text, filteredAdresse);
            this.Close();
        }
    }
}
