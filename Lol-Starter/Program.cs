using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Lol_Starter
{
    static class Program
    {
        /// <summary>Program
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            if (Utilitys.CheckWoWPath() == true)
            {
                FormMain formMain = new FormMain();
                formMain.SuspendLayout();
                try
                {
                    Application.Run(formMain);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bitte berichten Sie folgenden Fehler:\n" + e.Message, "Schwerwiegender Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
