using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace Lol_Starter.UC
{
    /// <summary>
    /// Light Version vom UCNews -> Ohne Ressourcen fressenden Browser
    /// </summary>
    public partial class UCNewsFeed : UserControl
    {
        /// <summary>UCNewsFeed
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        List<string> EntryStrings = new List<string>();
        List<NewsFeedEntry> newsFeedEntrys = new List<NewsFeedEntry>();
        public UCNewsFeed()
        {
            InitializeComponent();
            CreateNewsFeed();
        }

        /// <summary>CreateNewsFeed
        /// Erstellt den NewsFeed
        /// </summary>
        private void CreateNewsFeed()
        {
            this.MouseWheel += new MouseEventHandler(UCNewsFeed_MouseWheel);
            try
            {
                ReadFeed();
                CreateEntrys();
                CreateLinkToPortal();
                DrawEntrys();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>ReadFeed
        /// Erstellt eine List<string> aus allen Einträgen
        /// </summary>
        private void ReadFeed()
        {
            string url = "http://www.landoflegends.de/feed.php?mode=news";
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.Timeout = 3000;
            HttpWebResponse webResponse = (HttpWebResponse)httpRequest.GetResponse();
            StreamReader responseStream = new StreamReader(webResponse.GetResponseStream());
            string content = responseStream.ReadToEnd();
            foreach (string s in Regex.Split(content, "<entry>"))
                EntryStrings.Add(s);
            EntryStrings.RemoveAt(0);
        }

        /// <summary>CreateEntrys
        /// Erstellt Objekte der Klasse NewsFeedEntry
        /// </summary>
        private void CreateEntrys()
        {
            string startString = "";
            string endString = "";
            int startIndex = 0;
                foreach (string entry in EntryStrings)
                {
                    NewsFeedEntry newsFeedEntry = new NewsFeedEntry();                
                    // Autor
                    startString = "<author><name><![CDATA[";
                    endString = "]";
                    newsFeedEntry.Author = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    //Letztes Update
                    startString = "<updated>";
                    endString = "<";
                    newsFeedEntry.TimeUpdated = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    // Veröffentlicht
                    startString = "<published>";
                    endString = "<";
                    newsFeedEntry.TimePublished = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    //Link
                    startString = "<link href=" + '"';
                    endString = '"' + "";
                    newsFeedEntry.Link = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    // Überschrift
                    startString = "<title type=" + '"' + "html" + '"' + "><![CDATA[";
                    endString = "]";
                    newsFeedEntry.Headline = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    //Inhalt
                    startString = "<content";
                    endString = "</content>";
                    newsFeedEntry.Content = Utilitys.FindStringBetweenStrings(entry, startString, endString, ref startIndex);
                    // Lol Bote?
                    startString = "<author><name><![CDATA[";
                    endString = "]";
                    newsFeedEntry.IsLolBote = (Regex.IsMatch(newsFeedEntry.Content, "--LolBote--", RegexOptions.IgnoreCase) ? true : false);
                    startIndex = 0;
                    newsFeedEntrys.Add(newsFeedEntry);
                }
        }

        /// <summary> DrawEntrys
        /// Zeichnet die Controls auf das panel zum anzeigen der News
        /// </summary>
        private void DrawEntrys()
        {
            int posY = 3;
            int entryCount = 0;
            foreach (NewsFeedEntry entry in newsFeedEntrys)
            {
                // 
                // picBoxHeader
                // 
                Label lbHeader = new Label();
                lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbHeader.ForeColor = System.Drawing.Color.PeachPuff;
                lbHeader.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_serverstatus;
                lbHeader.Location = new System.Drawing.Point(32, posY);
                lbHeader.Name = "labelHeader";
                lbHeader.Size = new System.Drawing.Size(620, 32);
                lbHeader.TabIndex = 0;
                lbHeader.Text = "   " + entry.Headline + "      " + entry.TimeUpdated;
                lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                pnlNewsFeed.Controls.Add(lbHeader);
                // 
                // picBoxHeaderLeft
                // 
                PictureBox picBoxHeaderLeft = new PictureBox();
                picBoxHeaderLeft.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bg_serverstatus_left;
                picBoxHeaderLeft.Location = new System.Drawing.Point(3, posY);
                picBoxHeaderLeft.Name = "picBoxHeaderLeft";
                picBoxHeaderLeft.Size = new System.Drawing.Size(29, 32);
                picBoxHeaderLeft.TabIndex = 0;
                picBoxHeaderLeft.TabStop = false;
                pnlNewsFeed.Controls.Add(picBoxHeaderLeft);
                posY += 32 + 4;    
                // Content
                CreateContent(entry, ref posY);
                entryCount++;
                if (entryCount >= Properties.Settings.Default.NewsEntrysCount)
                    break;
            }
        }

        /// <summary>DrawContent
        /// Splittet den Content an den Bildern auf und setzt PictureBoxen ein
        /// </summary>
        private void CreateContent(NewsFeedEntry entry, ref int posY)
        {
            if (entry.IsLolBote)
            {
                string restContent = entry.Content;
                // LolBote Bild
                while(restContent.Contains("--"))
                {
                    CreatePicture(ref restContent, ref posY);
                }
                CreateTextLabel(restContent, 3, ref posY, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Color.SaddleBrown);

            }
            else
            {
                CreateTextLabel(entry.Content, 3, ref posY, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Color.SaddleBrown);
            }
        }

        /// <summary>CreatePicture
        /// Erstellt die Bilder zu den Texten und Tags oder... alter war das nervig!!! >_<
        /// Unübersichtlich!
        /// </summary>
        /// <param name="restContent"></param>
        /// <param name="posY"></param>
        private void CreatePicture(ref string restContent, ref int posY)
        {
            string[] splittString;
            string[] stringSeparators = new string[] { "--" };
            int picWidth = 0;
            int oldPosY = 0;
            // überprüfen ob string davor kommt?
            //splitt beim nächsten \n switch bild zeichnen, string zeichnen posY ++
            splittString = restContent.Split(stringSeparators, System.StringSplitOptions.None);
            if (splittString[1].Contains("LolBote"))
            {
                splittString = restContent.Split(new char[]{'\n'},3);
                splittString[1] = splittString[1].Replace("--LolBote--", "");
                picWidth = 237;
                // Lol Bote Zeichnen
                PictureBox picBoxLolBote = new PictureBox();
                picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.lol_bote_banner1;
                picBoxLolBote.Location = new System.Drawing.Point(3, posY);
                picBoxLolBote.Name = "picBoxLolBote";
                picBoxLolBote.Size = new System.Drawing.Size(picWidth, 45);
                pnlNewsFeed.Controls.Add(picBoxLolBote);
                posY += 50;
                //CreateTextLabel(splittString[1], picWidth + 5, ref posY, new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Color.SaddleBrown);
                restContent = "\n" + splittString[2];
            }
            else if (splittString[1].Contains("Diamant"))
            {
                splittString = restContent.Split(new char[] { '\n' }, 2);
                splittString[0] = splittString[0].Replace("--Diamant--", "");
                string strCompare = (char)splittString[1][0] + "" +(char)splittString[1][1] + "";
                while (splittString[1][0] != '-' && splittString[1][1] != '-' && strCompare != "\n\n")
                {
                    string[] _splitString = splittString[1].Split(new char[] { '\n' }, 2);
                    if(_splitString[0].Contains("--"))
                    {
                        string[] _splitStringB = _splitString[0].Split(stringSeparators, System.StringSplitOptions.None);
                        _splitString[0] = _splitStringB[0];
                        string _strTemp = "";
                        for (int i = 1; i < _splitStringB.Length; i++)
                        {
                            _strTemp +=  "--" + _splitStringB[i] + ""; 
                        }
                        _strTemp += "\n";
                        _splitString[1] = _strTemp + " " +  _splitString[1];
                        splittString[0] += "\n" + _splitString[0];
                        splittString[1] = _splitString[1];
                        break;
                    }
                    splittString[0] += "\n" + _splitString[0];
                    if (_splitString.Length > 1)
                        splittString[1] = _splitString[1];
                    else
                    {
                        splittString[1] = ""; 
                        break;
                    }
                }
                if(splittString[0][0] == ' ')
                    splittString[0] = splittString[0].Remove(0, 1);
                picWidth = 16;
                PictureBox picBoxLolBote = new PictureBox();
                picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.diamant16;
                picBoxLolBote.Location = new System.Drawing.Point(3, posY);
                picBoxLolBote.Name = "picBoxLolBote";
                picBoxLolBote.Size = new System.Drawing.Size(picWidth, 15);
                pnlNewsFeed.Controls.Add(picBoxLolBote);
                oldPosY = posY;
                CreateTextLabel(splittString[0], picWidth + 5, ref posY, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Color.SaddleBrown);
                posY += 5;
                restContent = splittString[1];
            }
            else // Buchstabe
            {
                PictureBox picBoxLolBote = new PictureBox();
                switch (splittString[1])
                {
                    case "A":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.a;
                        break;
                    case "B":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.b;
                        break;
                    case "C":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.c;
                        break;
                    case "D":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.d;
                        break;
                    case "E":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.e;
                        break;
                    case "F":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.f;
                        break;
                    case "G":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.g;
                        break;
                    case "H":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.h;
                        break;
                    case "I":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.i;
                        break;
                    case "J":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.j;
                        break;
                    case "K":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.k;
                        break;
                    case "L":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.l;
                        break;
                    case "M":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.m;
                        break;
                    case "N":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.n;
                        break;
                    case "O":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.o;
                        break;
                    case "P":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.p;
                        break;
                    case "Q":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.q;
                        break;
                    case "R":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.r;
                        break;
                    case "S":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.s;
                        break;
                    case "T":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.t;
                        break;
                    case "U":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.u;
                        break;
                    case "V":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.v;
                        break;
                    case "W":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.w;
                        break;
                    case "X":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.x;
                        break;
                    case "Y":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.y;
                        break;
                    case "Z":
                        picBoxLolBote.BackgroundImage = global::Lol_Starter.Properties.Resources.z;
                        break;

                }
                posY += 5;
                while (restContent[0] == '\n')
                    restContent = restContent.Remove(0, 1);
                splittString = restContent.Split(new char[] { '\n' }, 2);
                splittString[0] = splittString[0].Remove(0, 5);
                while (splittString[1][0] != '-' && splittString[1][1] != '-')
                {
                    string[] _splitString = splittString[1].Split(new char[] { '\n' }, 2);
                    splittString[0] += " " + _splitString[0];
                    splittString[1] = _splitString[1];
                }
                picWidth = 30;
                picBoxLolBote.Location = new System.Drawing.Point(3, posY);
                picBoxLolBote.Name = "picBoxLetter";
                picBoxLolBote.Size = new System.Drawing.Size(picWidth, 28);
                pnlNewsFeed.Controls.Add(picBoxLolBote);
                posY += 16;
                CreateTextLabel(splittString[0], picWidth, ref posY, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Color.SaddleBrown);
                posY += 3;
                restContent = splittString[1];
            }
        }

        /// <summary>CreateTextLabel
        /// Erstellt ein Label an den Positionen
        /// </summary>
        /// <param name="text"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        private void CreateTextLabel(string text, int posX, ref int posY, Font font, Color color)
        {
            Label lbText = new Label();
            lbText.AutoSize = false;
            lbText.Font = font;
            lbText.ForeColor = color;
            lbText.Location = new System.Drawing.Point(posX, posY);
            lbText.Name = "lbText";
            lbText.Width = 650 - posX;
            lbText.TabIndex = 0;
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(text, lbText.Font, lbText.Width);
                lbText.Height = (int)Math.Ceiling(size.Height);
                lbText.Text = text;
            }
            pnlNewsFeed.Controls.Add(lbText);

            posY += lbText.Height + 3;    
        }

        /// <summary>
        /// Link zum Portal
        /// </summary>
        private void CreateLinkToPortal()
        {
            PictureBox btnExtLink = new PictureBox();
            btnExtLink.Location = new Point(pnlNewsFeed.Width - 45, 37);
            btnExtLink.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExtLink.Size = new Size(24, 24);
            btnExtLink.BackgroundImage = Properties.Resources.btnExtLink;
            btnExtLink.Click += new EventHandler(btnExtLink_Click);
            this.pnlNewsFeed.Controls.Add(btnExtLink);
        }
        private void btnExtLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.landoflegends.de/portal.php");
        }

        // Damit der MouseWheel über das richtige Control geht
        void UCNewsFeed_MouseWheel(object sender, MouseEventArgs e)
        {
            pnlNewsFeed.Focus();
        }
    }
}
