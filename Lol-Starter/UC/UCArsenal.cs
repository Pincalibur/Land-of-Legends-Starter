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
    public partial class UCArsenal : UserControl
    {
        /// <summary>UCArsenal
        /// Release 10.04.2012 00:59 Uhr
        /// 
        /// Kevin Groß, Germany Kiel
        /// aka Pincalibur on www.landoflegends.de
        /// 
        /// Please tell me if you want to release a newer version or if you want to copy my source.
        /// Email: nuckydie@gmx.de
        /// </summary>
        public UCArsenal()
        {
            InitializeComponent();
            this.Name = "Arsenal";
        }

        private void picBoxOK_Click(object sender, EventArgs e)
        {
            OpenArsenal();
        }

        private void picBoxCancel_Click(object sender, EventArgs e)
        {
            ((Form)Parent.Parent).Close();
        }

        private void OpenArsenal()
        {
            System.Diagnostics.Process.Start("http://arsenal.landoflegends.de/search.xml?searchQuery=" + tbName.Text + "&searchType=all");
            ((Form)Parent.Parent).Close();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                OpenArsenal();
                e.Handled = true;
            }
        }
    }
}
