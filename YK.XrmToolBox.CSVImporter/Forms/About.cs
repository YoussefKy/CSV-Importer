using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK.XrmToolBox.CSVImporter.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent ( );
        }

        private void llblDeveloper_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start ( "http://youssefk.com" );
        }

        private void llblTwitter_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start ( "https://twitter.com/kl_yssf" );
        }

        private void llblGithubRepo_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start ( "https://github.com/K-Youssef/CSV-Importer" );
        }
    }
}
