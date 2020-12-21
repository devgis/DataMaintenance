using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void miOffer_Click(object sender, EventArgs e)
        {
            OfferForms.DataListForm dbAccessForm = new OfferForms.DataListForm();
            dbAccessForm.MdiParent = this;
            dbAccessForm.Dock = DockStyle.Fill;
            dbAccessForm.Show();
        }

        private void miProduct_Click(object sender, EventArgs e)
        {
            ProductForms.DataListForm dbAccessForm = new ProductForms.DataListForm();
            dbAccessForm.MdiParent = this;
            dbAccessForm.Dock = DockStyle.Fill;
            dbAccessForm.Show();
        }

        private void miSubject_Click(object sender, EventArgs e)
        {
            SubjectForms.DataListForm dbAccessForm = new SubjectForms.DataListForm();
            dbAccessForm.MdiParent = this;
            dbAccessForm.Dock = DockStyle.Fill;
            dbAccessForm.Show();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void miTreeView_Click(object sender, EventArgs e)
        {
            TreeviewWindow treeviewWindow = new TreeviewWindow();
            treeviewWindow.MdiParent = this;
            treeviewWindow.Dock = DockStyle.Fill;
            treeviewWindow.Show();
        }
    }

}
