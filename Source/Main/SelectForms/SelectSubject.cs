using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main.SelectForms
{
    public partial class SelectSubject : Form
    {
        public List<string> SelectedIDS = null;
        public DataTable SelectedRows = null;
        public SelectSubject(List<string> selectedIDS)
        {
            InitializeComponent();
            SelectedIDS= selectedIDS;
        }

        private void DBAccessForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string sql = "select * from Subject";
            if (!string.IsNullOrEmpty(tbKeywords.Text.Trim()))
            {
                sql += (" where " + string.Format("name like '%{0}%'", tbKeywords.Text));
            }

            DataTable dt = SQLHelper.Instance.GetDataTable(sql);
            dgList.DataSource = dt;
            if (dt != null)
            {
                SelectedRows = dt.Clone();
            }

            if (SelectedIDS != null && SelectedIDS.Count > 0)
            {
                foreach (DataGridViewRow row in dgList.Rows)
                {
                    if (SelectedIDS.Contains(row.Cells["CID"].Value.ToString()))
                    {
                        (row.Cells["CSelected"] as DataGridViewCheckBoxCell).Value = true;
                        (row.Cells["CSelected"] as DataGridViewCheckBoxCell).EditingCellFormattedValue = true;
                    }
                }
            }
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            SelectedIDS = new List<string>();
            SelectedRows.Clear();
            foreach (DataGridViewRow row in dgList.Rows)
            {
                if (Convert.ToBoolean((row.Cells["CSelected"] as DataGridViewCheckBoxCell).EditingCellFormattedValue))
                {
                    SelectedIDS.Add(row.Cells["CID"].Value.ToString());
                    DataRow newrow=SelectedRows.NewRow();
                    newrow.ItemArray = (row.DataBoundItem as DataRowView).Row.ItemArray;
                    //SelectedRows.Rows.Add((row.DataBoundItem as DataRowView).Row);
                    SelectedRows.Rows.Add(newrow);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
