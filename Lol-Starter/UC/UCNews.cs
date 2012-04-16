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
    public partial class UCNews : UserControl
    {
        /// <summary>UCNews
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public UCNews()
        {
            InitializeComponent();
            try
            {
                webBrowser.Navigate("http://www.landoflegends.de/portal.php");
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
            }
            catch
            {
                MessageBox.Show("Browser konnte nicht zu http://www.landoflegends.de/portal.php navigieren. Browser wird geschlossen");
                webBrowser.Dispose();
            }
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser.Document.Window.ScrollTo(233, 907);
            webBrowser.Document.Window.ScrollTo(22, 1618);
        }
    }
}
