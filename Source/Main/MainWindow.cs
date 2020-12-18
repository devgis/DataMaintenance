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

        }

        private void miProduct_Click(object sender, EventArgs e)
        {
            Product.DataListForm dbAccessForm = new Product.DataListForm();
            dbAccessForm.MdiParent = this;
            dbAccessForm.Dock = DockStyle.Fill;
            dbAccessForm.Show();
        }

        private void miSubject_Click(object sender, EventArgs e)
        {

        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}
