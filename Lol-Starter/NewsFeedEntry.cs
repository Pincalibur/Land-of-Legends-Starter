using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lol_Starter
{
    public class NewsFeedEntry
    {
        /// <summary>NewsFeedEntry
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        //Attribute
        string headline = "";
        string author = "";
        string content = "";
        bool isLolBote = false;
        string link = "";
        string timePublished = "";
        string timeUpdated = "";

        public string Headline
        {
            get { return headline; }
            set { headline = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = CleanContent(value); }
        }
        public bool IsLolBote
        {
            get { return isLolBote; }
            set { isLolBote = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public string TimePublished
        {
            get { return timePublished; }
            set { timePublished = Utilitys.GetReadableTimestamp(value); }
        }
        public string TimeUpdated
        {
            get { return timeUpdated; }
            set { timeUpdated = Utilitys.GetReadableTimestamp(value); }
        }

        //Konstruktoren
        public NewsFeedEntry()
        {
        }

        //Methoden
        private string CleanContent(string content)
        {
            int end = 0;
            string newContent = "";
            //content tag entfernen
            end = content.IndexOf("<![CDATA[") + 9;
            newContent = content.Remove(0, end);
            //Zeilenumbrüche und Bilder ersetzen
            newContent = newContent.Replace("<br />", "--br--"); //Zeilenumbrüche sichern
            //Bilder
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/a.png\" alt=\"Initial a\" />", "--A--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/b.png\" alt=\"Initial b\" />", "--B--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/c.png\" alt=\"Initial c\" />", "--C--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/d.png\" alt=\"Initial d\" />", "--D--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/e.png\" alt=\"Initial e\" />", "--E--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/f.png\" alt=\"Initial f\" />", "--F--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/g.png\" alt=\"Initial g\" />", "--G--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/h.png\" alt=\"Initial h\" />", "--H--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/i.png\" alt=\"Initial i\" />", "--I--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/j.png\" alt=\"Initial j\" />", "--J--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/k.png\" alt=\"Initial k\" />", "--K--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/l.png\" alt=\"Initial l\" />", "--L--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/m.png\" alt=\"Initial m\" />", "--M--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/n.png\" alt=\"Initial n\" />", "--N--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/o.png\" alt=\"Initial o\" />", "--O--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/p.png\" alt=\"Initial p\" />", "--P--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/q.png\" alt=\"Initial q\" />", "--Q--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/r.png\" alt=\"Initial r\" />", "--R--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/s.png\" alt=\"Initial s\" />", "--S--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/t.png\" alt=\"Initial t\" />", "--T--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/u.png\" alt=\"Initial u\" />", "--U--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/v.png\" alt=\"Initial v\" />", "--V--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/w.png\" alt=\"Initial s\" />", "--W--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/x.png\" alt=\"Initial x\" />", "--X--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/y.png\" alt=\"Initial y\" />", "--Y--");
            newContent = newContent.Replace("<img src=\"styles/uhula/initials/z.png\" alt=\"Initial z\" />", "--Z--");
            newContent = newContent.Replace("<li>", "\n");
            newContent = newContent.Replace("&#40;", "(");
            newContent = newContent.Replace("&#41;", ")");
            newContent = newContent.Replace("<img src=\"http://www.landoflegends.de/images/diamant16.png\" alt=\"Bild\" />", "--Diamant--");
            newContent = newContent.Replace("<img src=\"http://www.landoflegends.de/styles/uhula/images/lol_bote_banner.png\" alt=\"Bild\" />", "--LolBote--");
            newContent = Regex.Replace(newContent, @"<(.|\n)*?>", string.Empty); //HTML und URI entfernen
            newContent = newContent.Replace("--br--", "\n"); //Zeilenumbrüche wieder einsetzen
            newContent = newContent.Replace("quot;", ""); //Zeilenumbrüche wieder einsetzen
            newContent = newContent.Replace("Zum Weiterlesen bitte (Aufklappen)", string.Empty);
            newContent = newContent.Replace("\n\n", "\n");
            newContent = newContent.Replace("#39;", "'");

            return newContent;
        }
    }
}
