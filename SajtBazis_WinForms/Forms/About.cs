using System;
using System.Windows.Forms;

namespace SajtBazis_WinForms.Forms
{
    public partial class About : Form
    {
        private int time = 10;
        public About()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutes = time / 60;
            int seconds = time - minutes * 60;
            toolStripStatusLabel1.Text = "This window will close in " + seconds + " seconds.";

            if (time > 0)
            {
                time--;
            }
            else
            {
                Close();
            }
        }
    }
}
