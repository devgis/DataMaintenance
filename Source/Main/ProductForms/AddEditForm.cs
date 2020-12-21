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

namespace Main.ProductForms
{
    public partial class AddEditForm : Form
    {
        bool IsEdit = false;
        private string ID = string.Empty;
        public AddEditForm(string id="",bool isEdit=false)
        {
            InitializeComponent();
            IsEdit = isEdit;
            if (isEdit)
            {
                this.Text = "编辑";
                ID = id;
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
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("Name不能为空");
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbPrice.Text.Trim()))
            {
                MessageBox.Show("Price不能为空");
                tbPrice.Focus();
                return false;
            }
            else
            {
                try {
                    Convert.ToDouble(tbPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Price必须为数值类型");
                    tbPrice.Focus();
                    return false;
                }
                
            }

            if (string.IsNullOrEmpty(tbQuantity.Text.Trim()))
            {
                MessageBox.Show("Quantity不能为空");
                tbQuantity.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(tbQuantity.Text);
                }
                catch
                {
                    MessageBox.Show("Quantity必须为数值类型");
                    tbQuantity.Focus();
                    return false;
                }

            }
            return true;
        }

        public bool Add()
        {
            string sql = "insert into Product (id,name,price,quantity) values(@id,@name,@price,@quantity)";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("name",SqlDbType.VarChar),
                         new SqlParameter("price",SqlDbType.Decimal),
                         new SqlParameter("quantity",SqlDbType.Decimal),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = tbName.Text;
            parameters[1].Value = Convert.ToDecimal(tbPrice.Text);
            parameters[2].Value = Convert.ToDecimal(tbQuantity.Text);
            parameters[3].Value = Guid.NewGuid().ToString() ;

            return SQLHelper.Instance.ExecSql(sql, parameters);
        }

        public bool Update()
        {
            string sql = "update Product set name=@name,price=@price,quantity=@quantity where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("name",SqlDbType.VarChar),
                         new SqlParameter("price",SqlDbType.Decimal),
                         new SqlParameter("quantity",SqlDbType.Decimal),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };
           
            parameters[0].Value = tbName.Text;
            parameters[1].Value = Convert.ToDecimal(tbPrice.Text);
            parameters[2].Value = Convert.ToDecimal(tbQuantity.Text);
            parameters[3].Value = ID;

            return SQLHelper.Instance.ExecSql(sql, parameters);
        }

        public void LoadData(string id)
        {
            string sql = "select * from Product where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = id;

            DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbName.Text = dt.Rows[0]["name"].ToString();
                tbQuantity.Text = dt.Rows[0]["quantity"].ToString();
                tbPrice.Text = dt.Rows[0]["price"].ToString();
            }
        }

        //public bool ExistsID(int id)
        //{
        //    string sql = "select * from Student where ID=?";
        //    SqlParameter[] parameters = new SqlParameter[] {
        //                 new SqlParameter("ID",OleDbType.Numeric)
        //            };

        //    parameters[0].Value = id;

        //    DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
