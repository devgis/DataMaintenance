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

namespace Main.Offer
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
            string sql = "select * from Offer";
            if (!string.IsNullOrEmpty(tbKeywords.Text.Trim()))
            {
                sql += (" where " + string.Format("subjectname like '%{0}%'", tbKeywords.Text));
            }

            DataTable dt = SQLHelper.Instance.GetDataTable(sql);
            dgList.DataSource = dt;

            if (dgList.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgList.Rows)
                {
                    try
                    {
                        row.Cells["CStateText"].Value = StaticData.GetKey(Convert.ToInt32(row.Cells["CState"].Value));
                    }
                    catch
                    { }
                }
            }
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
                string id =dgList.SelectedRows[0].Cells["CID"].Value.ToString();
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
                string id = dgList.SelectedRows[0].Cells["CID"].Value.ToString();
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
        private bool Delete(string id)
        {
            string sql = "delete from Offer where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("id",SqlDbType.VarChar)
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
