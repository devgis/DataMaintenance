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
    public partial class AddEditForm : Form
    {
        bool IsEdit = false;
        public AddEditForm(int id=0,bool isEdit=false)
        {
            InitializeComponent();
            IsEdit = isEdit;
            if (isEdit)
            {
                this.Text = "编辑";
                LoadData(id);
            }
            else
            {
                this.Text = "新增";
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (IsEdit)
                {
                    if (Update())
                    {
                        MessageBox.Show("修改成功！");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else
                {
                    if (Add())
                    {
                        MessageBox.Show("新增成功！");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("新增失败！");
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(tbID.Text.Trim()))
            {
                MessageBox.Show("编号不能为空");
                tbID.Focus();
                return false;
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(tbID.Text);
                    if(!IsEdit)
                    {
                        if (ExistsID(id))
                        {
                            MessageBox.Show("编号已存在");
                            tbID.Focus();
                            return false;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("编号必须为整数");
                    tbID.Focus();
                    return false;
                }

            }

            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("姓名不能为空");
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbAge.Text.Trim()))
            {
                MessageBox.Show("年龄不能为空");
                tbAge.Focus();
                return false;
            }
            else
            {
                try {
                    int age = Convert.ToInt32(tbAge.Text);

                    if (age < 1 || age > 100)
                    {
                        MessageBox.Show("年龄必须为1~100");
                        tbAge.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("年龄必须为整数");
                    tbAge.Focus();
                    return false;
                }
                
            }
            return true;
        }

        public bool Add()
        {
            string sql = "insert into Student (ID,Name,Address,Age,Sex,Remark) values(?,?,?,?,?,?)";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("ID",OleDbType.Numeric),
                         new SqlParameter("Name",OleDbType.VarChar),
                        new SqlParameter("Address",OleDbType.VarChar),
                         new SqlParameter("Age",OleDbType.Numeric),
                         new SqlParameter("Sex",OleDbType.VarChar),
                         new SqlParameter("Remark",OleDbType.VarChar)
                    };
            parameters[0].Value = Convert.ToInt32(tbID.Text);
            parameters[1].Value = tbName.Text;
            parameters[2].Value = tbAddress.Text;
            parameters[3].Value = Convert.ToInt32(tbAge.Text);
            parameters[4].Value = cbSex.Text;
            parameters[5].Value = tbRemark.Text;

            return SQLHelper.Instance.ExecSql(sql, parameters);
        }

        public bool Update()
        {
            string sql = "update Student set Name=?,Address=?,Age=?,Sex=?,Remark=? where ID=?";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("Name",OleDbType.VarChar),
                         new SqlParameter("Address",OleDbType.VarChar),
                         new SqlParameter("Age",OleDbType.Numeric),
                         new SqlParameter("Sex",OleDbType.VarChar),
                         new SqlParameter("Remark",OleDbType.VarChar),
                         new SqlParameter("ID",OleDbType.Numeric)
                    };
           
            parameters[0].Value = tbName.Text;
            parameters[1].Value = tbAddress.Text;
            parameters[2].Value = Convert.ToInt32(tbAge.Text);
            parameters[3].Value = cbSex.Text;
            parameters[4].Value = tbRemark.Text;
            parameters[5].Value = Convert.ToInt32(tbID.Text);

            return SQLHelper.Instance.ExecSql(sql, parameters);
        }

        public void LoadData(int id)
        {
            string sql = "select * from Student where ID=?";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("ID",OleDbType.Numeric)
                    };

            parameters[0].Value = id;

            DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbID.Text = id.ToString();
                tbID.ReadOnly = true;
                tbName.Text = dt.Rows[0]["Name"].ToString();
                cbSex.Text = dt.Rows[0]["Sex"].ToString();
                tbAge.Text = dt.Rows[0]["Age"].ToString();
                tbAddress.Text = dt.Rows[0]["Address"].ToString();
                tbRemark.Text = dt.Rows[0]["Remark"].ToString();
            }
        }

        public bool ExistsID(int id)
        {
            string sql = "select * from Student where ID=?";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("ID",OleDbType.Numeric)
                    };

            parameters[0].Value = id;

            DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
