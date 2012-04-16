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
    public partial class UCRealmlist : UserControl
    {
        /// <summary>UCRealmlist
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        List<RadioButton> rbList = new List<RadioButton>();
        List<RealmLabel> realmLabelList = new List<RealmLabel>();
        public UCRealmlist()
        {
            InitializeComponent();
            Utilitys.LoadRealmList();
            createRealms();
        }

        /// <summary>
        /// Ruft die Methode Edit Realm auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_Click(object sender, EventArgs e)
        {
            ((RealmLabel)sender).RadioButton.Checked = true;
        }

        /// <summary>btnEdit_Click
        /// Ruft das Bearbeiten Menü für den Realm auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            RealmLabel realmLabel = new RealmLabel();
            PictureBox btnEdit = (PictureBox)sender;
            foreach (RealmLabel rlb in realmLabelList)
            {
                if (rlb.EditButton == btnEdit)
                    realmLabel = rlb;
            }
            UCRealmEdit ucRealmEdit = new UCRealmEdit(realmLabel.Adresse, realmLabel.Text, realmLabel.Id);
            ucRealmEdit.newRealmInc += new UCRealmEdit.newRealm(UpdateRealms);
            FormPopUp popUp = new FormPopUp(ucRealmEdit);
            popUp.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRealm_Click(object sender, EventArgs e)
        {
            UCRealmAdd ucRealmAdd = new UCRealmAdd();
            ucRealmAdd.newRealmInc += new UCRealmAdd.newRealm(UpdateRealms);
            FormPopUp popUp = new FormPopUp(ucRealmAdd);
            popUp.ShowDialog();
        }

        /// <summary>createRealms
        /// Erzeugt alle Realms aus den Properties
        /// </summary>
        private void createRealms()
        {
            createAddRealm();
            int id = 0;
            foreach (string realm in Properties.Settings.Default.RealmList)
            {
                string name = Properties.Settings.Default.RealmName[id];
                createRealmLabel(id, name, realm);
                id++;
            }
            rbList[0].Checked = true;
        }

        void createAddRealm()
        {
            PictureBox picBoxAddRealm = new PictureBox();
            picBoxAddRealm.BackColor = System.Drawing.Color.Transparent;
            picBoxAddRealm.BackgroundImage = global::Lol_Starter.Properties.Resources.btnAdd;
            picBoxAddRealm.Cursor = System.Windows.Forms.Cursors.Hand;
            picBoxAddRealm.Location = new System.Drawing.Point(3, 3);
            picBoxAddRealm.Name = "picBoxAddRealm";
            picBoxAddRealm.Size = new System.Drawing.Size(16, 16);
            picBoxAddRealm.TabIndex = 8;
            picBoxAddRealm.TabStop = false;
            picBoxAddRealm.Click += new System.EventHandler(this.btnAddRealm_Click);
            this.Controls.Add(picBoxAddRealm);
        }

        /// <summary>
        /// Erzeugt einen Label und einen Radiobutton zu einer ID und Text
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="adresse"></param>
        private void createRealmLabel(int id, string text, string adresse)
        {
            // label erzeugen
            RealmLabel realmLabel = new RealmLabel();
            int posY = 4 + 17 * id;
            realmLabel.AutoSize = true;
            realmLabel.BackColor = System.Drawing.Color.Transparent;
            realmLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            realmLabel.ForeColor = System.Drawing.Color.Black;
            realmLabel.Location = new Point(59, posY);
            realmLabel.Name = "lbTest";
            realmLabel.Size = new System.Drawing.Size(122, 13);
            realmLabel.TabIndex = 0;
            realmLabel.Text = text;
            realmLabel.Click += new System.EventHandler(this.lb_Click);
            realmLabel.Adresse = adresse;
            realmLabel.Id = id;
            this.Controls.Add(realmLabel);
            realmLabelList.Add(realmLabel);
            // zugehöriger RadioButton
            RadioButton rb = new RadioButton();
            rb.AutoSize = true;
            rb.BackColor = System.Drawing.Color.Transparent;
            rb.Checked = false;
            rb.Location = new System.Drawing.Point(43, posY);
            rb.Name = adresse;
            rb.Size = new System.Drawing.Size(14, 13);
            rb.TabIndex = 3;
            rb.UseVisualStyleBackColor = false;
            this.Controls.Add(rb);
            rbList.Add(rb);
            realmLabel.RadioButton = rb;
            // PictureBox OnlineStatus
            PictureBox picBoxOnline = new PictureBox();
            picBoxOnline.BackColor = System.Drawing.Color.Transparent;
            picBoxOnline.BackgroundImage = global::Lol_Starter.Properties.Resources.icon_offline;
            picBoxOnline.Location = new System.Drawing.Point(22, posY);
            picBoxOnline.Name = "picBoxOnline";
            picBoxOnline.Size = new System.Drawing.Size(15, 14);
            picBoxOnline.TabIndex = 0;
            picBoxOnline.TabStop = false;
            realmLabel.StatusOnline = picBoxOnline;
            this.Controls.Add(picBoxOnline);
            //PictureBox Edit Button
            if (id > 0)
            {
                PictureBox picBoxEdit = new PictureBox();
                picBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
                picBoxEdit.BackColor = System.Drawing.Color.Transparent;
                picBoxEdit.BackgroundImage = global::Lol_Starter.Properties.Resources.btnEdit;
                picBoxEdit.Location = new System.Drawing.Point(2, posY - 1);
                picBoxEdit.Name = "btnEdit";
                picBoxEdit.Size = new System.Drawing.Size(16, 16);
                picBoxEdit.TabIndex = 0;
                picBoxEdit.TabStop = false;
                picBoxEdit.Click += new EventHandler(btnEdit_Click);
                realmLabel.EditButton = picBoxEdit;
                this.Controls.Add(picBoxEdit);
            }
        }

        /// <summary>
        /// Passt die größe des UC an die Anzahl der Label an
        /// </summary>
        /// <param name="rlb"></param>
        private void resizeUC(RealmLabel rlb)
        {
            int labelMaxPosY = rlb.Location.Y + rlb.Size.Height + 6;
            if (labelMaxPosY > this.Size.Height)
                this.Size = new Size(this.Size.Width, labelMaxPosY);
        }

        /// <summary>
        /// Gibt den angewählten Realm zurück
        /// </summary>
        /// <returns></returns>
        public string GetCheckedRealmAdresse()
        {
            string adresse = "";
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked == true)
                    {
                        adresse = rb.Name;
                        break;
                    }
                }
            }
            return adresse;
        }

        /// <summary>UpdateRealms
        /// Erstellt die Realmlist neu
        /// </summary>
        public void UpdateRealms()
        {
            this.Controls.Clear();
            rbList.Clear();
            realmLabelList.Clear();
            createRealms();
            UpdateRealmStatus();
        }

        /// <summary>UpdateRealmOnline
        /// Fragt die Erreichbarkeit der Server ab
        /// </summary>
        public void UpdateRealmStatus()
        {
            foreach (RealmLabel realm in realmLabelList)
            {
                string filteredAdresse = Utilitys.FilterRealmAdresse(realm.Adresse);
                if (Utilitys.PingabledAdresse(filteredAdresse))
                    realm.StatusOnline.BackgroundImage = global::Lol_Starter.Properties.Resources.icon_online;
                else
                    realm.StatusOnline.BackgroundImage = global::Lol_Starter.Properties.Resources.icon_offline;
            }
            
        }
    }
}
