using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace Lol_Starter
{
    public static class Utilitys
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
       
        /// <summary>startWoW
        /// Startet WoW aus einem Pfad
        /// </summary>
        /// <param name="path"></param>
        public static void startWoW(string path, string adresse)
        {
            //realmlist neu schreiben
            List<string> realmlist = getRealmListPath(path);
            foreach (string realm in realmlist)
            {
                File.Delete(realm);
                StreamWriter sw = new StreamWriter(realm);
                sw.WriteLine(adresse);
                sw.Close();
            }

            //WoW Starten
            Process wow = new Process();
            wow.StartInfo.FileName = path + "\\wow.exe";
            wow.Start();
        }

        /// <summary>checkWoWPath
        /// Überprüft den gespeicherten WoW Pfad und gibt zurück ob er OK ist
        /// </summary>
        /// <returns></returns>
        public static bool CheckWoWPath()
        {
            bool pathIsOK = false;
            do
            {
                if (Properties.Settings.Default.WowPath == "")
                {
                    MessageBox.Show("Bitte wählen Sie den Pfad zu Ihrer Wow.exe aus.", "WoW Pfad fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.WowPath = ChooseWowPath();
                    if (Properties.Settings.Default.WowPath == "")
                        return pathIsOK;
                    Properties.Settings.Default.Save(); 
                }
                pathIsOK = CheckForWowExeInPath(Properties.Settings.Default.WowPath);
                if (pathIsOK == false)
                {
                    Properties.Settings.Default.WowPath = "";
                    Properties.Settings.Default.Save();
                }
            } while (pathIsOK == false);
            return pathIsOK;
        }

        /// <summary>
        /// Ruft ein FolderBrowseDialog auf, in dem sich die Wow.exe befinden muss.
        /// </summary>
        public static string ChooseWowPath()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult dr = folderDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
                return "";
            return folderDialog.SelectedPath;
        }

        /// <summary>CheckForWoWExeInPath
        /// Überprüft ob sich in dem angegebenem Pfad eine Wow.exe befinden
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool CheckForWowExeInPath(string path)
        {
            bool returnValue = false;
            if (File.Exists(path + "\\wow.exe"))
                returnValue = true;
            else
                if(path != "")
                    MessageBox.Show("Ungültiger Pfad.\nEr enthält keine Wow.exe!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return returnValue;
        }

        /// <summary>LoadRealmList
        /// Sucht die Realmlist und überprüft ihre Einträge
        /// Lädt alle neuen Einträge in den Speicher und legt Namen dafür an
        /// </summary>
        public static void LoadRealmList()
        {
            string wowPath = Properties.Settings.Default.WowPath;
            List<string> realmListPaths = getRealmListPath(wowPath);
            foreach (string realmListPath in realmListPaths)
            {
                List<string> newRealmlist = new List<string>();
                if (realmListPath != "")
                {
                    //Hole alle Realmlists aus der relamlist.wtf
                    StreamReader sr = new StreamReader(realmListPath);
                    string realmList = sr.ReadToEnd();
                    sr.Close();
                    string[] splittStr = realmList.Split(';');
                    foreach (string s in splittStr) newRealmlist.Add(s); //Liste füllen, um doppelte Einträge aus der Liste zu entfernen
                    char[] TrimChars = { '\r', '\n', ';', ',' };
                    bool adresseIsInRealmList = false;
                    foreach (string str in newRealmlist)
                    {
                        string newRealmAdresse = str.TrimStart(TrimChars);
                        newRealmAdresse = str.TrimEnd(TrimChars);
                        adresseIsInRealmList = RealmIsInRealmList(newRealmAdresse);
                        if (adresseIsInRealmList == false && newRealmAdresse != "")
                        {
                            //trage neue hinzu
                            Properties.Settings.Default.RealmList.Add(newRealmAdresse);
                            Properties.Settings.Default.RealmName.Add(newRealmAdresse);
                            Properties.Settings.Default.Save(); //speichere Liste
                        }
                    }
                }
            }
        }

        /// <summary>getRealmListPath
        /// Gibt den Pfad der realmlist zurück
        /// </summary>
        /// <param name="wowPath"></param>
        /// <returns></returns>
        public static List<string> getRealmListPath(string wowPath)
        {
            List<String> possibleRealmListPath = new List<string>();
            List<string> realmlistPath = new List<string>();
            possibleRealmListPath.Add("\\Data\\deDE\\realmlist.wtf");
            possibleRealmListPath.Add("\\Data\\deAT\\realmlist.wtf");
            possibleRealmListPath.Add("\\Data\\enGB\\realmlist.wtf");
            possibleRealmListPath.Add("\\Data\\enUS\\realmlist.wtf");
            possibleRealmListPath.Add("\\Data\\frFR\\realmlist.wtf");
            possibleRealmListPath.Add("\\Data\\esES\\realmlist.wtf");

            foreach (string strPath in possibleRealmListPath)
            {
                if (File.Exists(wowPath + strPath))
                {
                    realmlistPath.Add(wowPath + strPath);
                    break;
                }
            }

            return realmlistPath;
        }

        /// <summary>RealmIsInRealmList
        /// Überprüft ob eine RealmAdresse bereits in der gespeicherten Realmlist ist
        /// </summary>
        /// <param name="newRealmAdresse"></param>
        /// <returns></returns>
        public static bool RealmIsInRealmList(string newRealmAdresse)
        {
            bool adresseIsInRealmList = false;
            foreach (string oldRealmAdresse in Properties.Settings.Default.RealmList)
            {
                //vergleiche sie mit gespeicherten
                if (oldRealmAdresse == newRealmAdresse)
                {
                    adresseIsInRealmList = true;
                    break;
                }
            }
            return adresseIsInRealmList;
        }

        /// <summary>RealmIsInRealmList
        /// Überprüft ob eine RealmAdresse bereits in der gespeicherten Realmlist ist, bis auf den index der angegeben ID
        /// </summary>
        /// <param name="newRealmAdresse"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool RealmIsInRealmList(string newRealmAdresse, int id)
        {
            bool adresseIsInRealmList = false;
            foreach (string oldRealmAdresse in Properties.Settings.Default.RealmList)
            {
                //vergleiche sie mit gespeicherten
                if (Properties.Settings.Default.RealmList[id] != oldRealmAdresse)
                {
                    if (oldRealmAdresse == newRealmAdresse)
                    {
                        adresseIsInRealmList = true;
                        break;
                    }
                }
            }
            return adresseIsInRealmList;
        }

        /// <summary>
        /// Gibt den Namen eines Realm zu einer Adresse raus
        /// </summary>
        /// <param name="Adresse"></param>
        /// <returns></returns>
        public static string GetRealmNameToAdresse(string adresse)
        {
            string name = "";
            int id = 0;

            foreach (string realmlistadresse in Properties.Settings.Default.RealmList)
            {
                if (adresse == realmlistadresse)
                {
                    name = Properties.Settings.Default.RealmName[id];
                    break;
                }
                id++;
                if (id > Properties.Settings.Default.RealmList.Count)
                    name = "NAME-ERROR";
            }

            return name;
        }

        /// <summary>FilterRealmAdresse
        /// Filtert die Adresse eines Servers aus einem String heraus.
        /// </summary>
        /// <param name="adresse"></param>
        /// <returns></returns>
        public static string FilterRealmAdresse(string adresse)
        {
            string returnValue = "";

            string[] splittstring = adresse.Split(new char[]{' ', ':'});
            foreach (string str in splittstring)
            {
                if(str.Contains('.'))
                {
                    returnValue = str;
                    break;
                }
            }

            return returnValue;
        }

        /// <summary>PingabledAdresse
        /// Überprüft ob eine Adresse anpingbar ist.
        /// </summary>
        /// <param name="adresse"></param>
        /// <returns></returns>
        public static bool PingabledAdresse(string adresse)
        {
            bool returnValue = false;
            Ping myPing = new Ping();
            string host = adresse;
            byte[] buffer = new byte[32];
            int timeout = 1000;

            // PingOptions übernimmt alle notwendigen Optionen
            PingOptions pingOptions = new PingOptions();

            try
            {
                // Den Ping mit Hilfe von PingReply ausführen
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);

                // Den zurückgelieferten Wert von PingReply abfragen
                if (reply.Status == IPStatus.Success)
                {
                    // erfolgreich
                    returnValue = true;
                }

                else if (reply.Status == IPStatus.TimedOut)
                {
                    // fehlgeschlagen
                    returnValue = false;
                }
            }
            catch
            {
            }
            return returnValue;
        }

        /// <summary>RealmListExport
        /// Exportiert alle gespeicherten Realmlists mit einem FileDialog in eine realmlist.wtf.
        /// </summary>
        public static void RealmListExport()
        {
            string realmstring = CreateRealmListString();
            Stream stream;
            StreamWriter sw;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WinTaper Data File (*.wtf)|*.wtf";
            sfd.FilterIndex = 1;
            sfd.FileName = "realmlist.wtf";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile()) != null)
                {
                    sw = new StreamWriter(stream);
                    sw.Write(realmstring);
                    sw.Close();
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Generiert einen String aus allen gespeicherten Realmlists
        /// </summary>
        /// <returns></returns>
        public static string CreateRealmListString()
        {
            string realmstring = "";

            foreach (string realm in Properties.Settings.Default.RealmList)
            {
                realmstring += realm + ";\r\n";
            }

            return realmstring;
        }

        /// <summary>FindStringBetweenStrings
        /// Sucht einen String, der sich zwischen zwei String befindet
        /// </summary>
        /// <param name="value">String in dem gesucht werden soll</param>
        /// <param name="start">String ab dem gesucht werden soll</param>
        /// <param name="end">String bis zu dem gesucht werden soll</param>
        /// <param name="startIndex">Gibt das Zeichen im value String an, ab dem der start String gesucht werden soll</param>
        /// <returns></returns>
        public static string FindStringBetweenStrings(string value, string start, string end, ref int startIndex)
        {
            string str = "";
            try
            {
                int posStringStart = value.IndexOf(start, startIndex) + start.Length;
                int posStringEnd = value.IndexOf(end, posStringStart) - end.Length;
                for (int i = posStringStart; i <= posStringEnd; i++)
                {
                    str += value[i];
                }
                startIndex = posStringEnd;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return str;
        }
        /// <summary>FindStringBetweenStrings
        /// Sucht einen String, der sich zwischen zwei String befindet
        /// </summary>
        /// <param name="value">String in dem gesucht werden soll</param>
        /// <param name="start">String ab dem gesucht werden soll</param>
        /// <param name="end">String bis zu dem gesucht werden soll</param>
        /// <returns></returns>
        public static string FindStringBetweenStrings(string value, string start, string end)
        {
            string str = "";
            try
            {
                int posStringStart = value.IndexOf(start) + start.Length;
                int posStringEnd = value.IndexOf(end, posStringStart) - end.Length;
                for (int i = posStringStart; i <= posStringEnd; i++)
                {
                    str += value[i];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return str;
        }

        public static string GetReadableTimestamp(string timestamp)
        {
            string newTimestamp = "";
            string year = "";
            string month = "";
            string day = "";
            string hour = "";
            string minute = "";

            string[] splittAll = timestamp.Split(new char[]{'-','T',':'});
            year = splittAll[0];
            month = splittAll[1];
            day = splittAll[2];
            hour = splittAll[3];
            minute = splittAll[4];
            newTimestamp = day + "." + month + "." + year + " " + hour + ":" + minute;

            return newTimestamp;
        }
    }
}
