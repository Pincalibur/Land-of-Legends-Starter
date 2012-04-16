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
    public partial class FormRealmEdit : Form
    {
        Point mousePosition = new Point();
        public delegate void newRealm();
        public event newRealm newRealmInc;
        int id = 0;
        public FormRealmEdit(string adresse, string name, int id)
        {
            InitializeComponent();
            pnlRealmAdd.MouseDown += new MouseEventHandler(FormRealmEdit_MouseDown);
            pnlRealmAdd.MouseMove += new MouseEventHandler(FormRealmEdit_MouseMove);
            this.id = id;
            tbAdresse.Text = adresse;
            tbName.Text = name;
        }

        private void FormRealmEdit_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
        }

        private void FormRealmEdit_MouseMove(object sender, MouseEventArgs e)
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
            if (Utilitys.RealmIsInRealmList(tbAdresse.Text, id) == true)
            {
                MessageBox.Show("Realm bereits unter dem Namen '" + Utilitys.GetRealmNameToAdresse(tbAdresse.Text) + "' vorhanden.", "Realm bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Properties.Settings.Default.RealmList[id] = tbAdresse.Text;
            Properties.Settings.Default.RealmName[id] = tbName.Text;
            Properties.Settings.Default.Save();
            newRealmInc();
            this.Close();
        }

        private void picBoxDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Wollen Sie den Realm wirklich löschen?", "Wirklich löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.RealmList.RemoveAt(id);
                Properties.Settings.Default.RealmName.RemoveAt(id);
                Properties.Settings.Default.Save();
                this.Close();
                newRealmInc();
            }
        }
    }
}
