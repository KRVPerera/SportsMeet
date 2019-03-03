using System;
using System.Windows.Forms;

namespace SportsMeet
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void btnAboutOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}