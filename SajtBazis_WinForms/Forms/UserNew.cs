using SajtBazis_WinForms.Classes;
using System;
using System.Windows.Forms;

namespace SajtBazis_WinForms.Forms
{
    public partial class UserNew : Form
    {
        Users feldolgozandoUser;
        internal Users FeldolgozandoUser
        {
            get { return feldolgozandoUser; }
            //set { feldolgozandoUser = value; }
        }

        public UserNew()
        {
            InitializeComponent();
            cmb_Permission.DataSource = Enum.GetValues(typeof(Permissions));
        }
    }
}
