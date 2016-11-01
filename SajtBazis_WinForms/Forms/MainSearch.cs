using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Forms;
using System;
using System.Windows.Forms;
using SajtBazis_WinForms.Database;

namespace SajtBazis_WinForms
{
    public partial class MainSearch : Form
    {
        public MainSearch()
        {
            InitializeComponent();
            cmb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            cmb_Category.DataSource = Enum.GetValues(typeof(Categories));
            cmb_Market.DataSource = Enum.GetValues(typeof(Markets));
            cmb_Factory.DataSource = Enum.GetValues(typeof(Factories));
            cmb_Type.DataSource = Enum.GetValues(typeof(Types));
        }

        //##kérdés: listboxnál nem nulláza ki az értékeket, hanem hozzáadja a meglévőhöz
        private void MainSearch_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DatabaseManager.SelectAllProduct();
        }

        private void MainSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;

            //}
        }

        //Menustrip
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMaintenance userswindow = new UserMaintenance();
            userswindow.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductMaintenance productswindow = new ProductMaintenance();
            productswindow.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //##kérdés: partnumber konvertálásnál gondjai vannak, barcode ok
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int searchpartnumber = Convert.ToInt32(tbx_PartNumber.Text);
            string searchdescription = txb_Description.Text;
            int searchbrand = cmb_Brand.SelectedIndex;
            int searchcategory = cmb_Category.SelectedIndex;
            int searchmarket = cmb_Market.SelectedIndex;
            int searchfactory = cmb_Factory.SelectedIndex;
            int searchtype = cmb_Type.SelectedIndex;
            int searchbarcode = Convert.ToInt32(txb_BarCode.Text);

            listBox1.DataSource = null;
            listBox1.DataSource = DatabaseManager.SearchProduct(searchpartnumber, searchdescription, searchbrand, searchcategory, searchmarket, searchfactory, searchtype, searchbarcode);
        }


    }
}
