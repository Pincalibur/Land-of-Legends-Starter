using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lol_Starter
{
    public class RealmLabel : Label
    {
        /// <summary>RealmLabel
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        //Attribute
        int id = 0;
        string adresse = "";
        PictureBox statusOnline;
        RadioButton radioButton;
        PictureBox editButton = new PictureBox();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public PictureBox StatusOnline
        {
            get { return statusOnline; }
            set { statusOnline = value; }
        }
        public RadioButton RadioButton
        {
            get { return radioButton; }
            set { radioButton = value; }
        }
        public PictureBox EditButton
        {
            get { return editButton; }
            set { editButton = value; }
        }

        //Konstruktoren
        public RealmLabel()
        {

        }

        //Methoden
    }
}
