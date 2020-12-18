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

namespace Main.Product
{
    public partial class DataListForm : Form
    {
        public DataListForm()
        {
            InitializeComponent();
        }

        private void DBAccessForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string sql = "select * from Product";
            if (!string.IsNullOrEmpty(tbKeywords.Text.Trim()))
            {
                sql += (" where " + string.Format("name like '%{0}%'", tbKeywords.Text));
            }

            DataTable dt = SQLHelper.Instance.GetDataTable(sql);
            dgList.DataSource = dt;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选中行进行编辑！");
            }
            else
            {
                int id = Convert.ToInt32(dgList.SelectedRows[0].Cells["CID"].Value);
                AddEditForm addEditForm = new AddEditForm(id,true);
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选中行进行删除！");
            }
            else
            {
                int id = Convert.ToInt32(dgList.SelectedRows[0].Cells["CID"].Value);
                if (Delete(id))
                {
                    LoadData();
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
        private bool Delete(int id)
        {
            string sql = "delete from Product where ID=?";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("ID",OleDbType.Numeric)
                    };

            parameters[0].Value = id;

            return SQLHelper.Instance.ExecSql(sql, parameters);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
