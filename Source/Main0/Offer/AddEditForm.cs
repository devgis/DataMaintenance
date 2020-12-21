using Main.SelectForms;
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

            cbWhyOffer.DataSource= new BindingSource(StaticData.DicWhyOffer,null);
            cbWhyOffer.DisplayMember = "key";
            cbWhyOffer.ValueMember = "value";
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
            if (string.IsNullOrEmpty(tbSubjectname.Text.Trim()))
            {
                MessageBox.Show("Subjectname不能为空");
                tbSubjectname.Focus();
                return false;
            }

            if (cbWhyOffer.SelectedItem==null)
            {
                MessageBox.Show("WhyOffer不能为空请选择！");
                cbWhyOffer.Focus();
                return false;
            }

            //if (string.IsNullOrEmpty(tbPrice.Text.Trim()))
            //{
            //    MessageBox.Show("Price不能为空");
            //    tbPrice.Focus();
            //    return false;
            //}
            //else
            //{
            //    try {
            //        Convert.ToDouble(tbPrice.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Price必须为数值类型");
            //        tbPrice.Focus();
            //        return false;
            //    }

            //}

            //if (string.IsNullOrEmpty(tbQuantity.Text.Trim()))
            //{
            //    MessageBox.Show("Quantity不能为空");
            //    tbQuantity.Focus();
            //    return false;
            //}
            //else
            //{
            //    try
            //    {
            //        Convert.ToDouble(tbQuantity.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Quantity必须为数值类型");
            //        tbQuantity.Focus();
            //        return false;
            //    }

            //}
            return true;
        }

        public bool Add()
        {
            string newid = Guid.NewGuid().ToString();
            List<string> sqls = new List<string>();
            List<SqlParameter[]> parameterslist = new List<SqlParameter[]>();
            string sql = "insert into Offer (id,subjectname,starttime,state,donetime) values(@id,@subjectname,@starttime,@state,@donetime)";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("subjectname",SqlDbType.VarChar),
                         new SqlParameter("startTime",SqlDbType.DateTime),
                         new SqlParameter("state",SqlDbType.Int),
                         new SqlParameter("donetime",SqlDbType.DateTime),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = tbSubjectname.Text;
            parameters[1].Value = dtpStartTime.Value;
            parameters[2].Value = Convert.ToInt32(cbWhyOffer.SelectedValue);
            parameters[3].Value = dtpDoneTime.Value;
            parameters[4].Value = newid;
            sqls.Add(sql);
            parameterslist.Add(parameters);


            if (selectedIDS != null && selectedIDS.Count > 0)
            {
                foreach (var prodid in selectedIDS)
                {
                    sql = "insert into Offer_Product (offerid,productid) values(@offerid,@productid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("offerid",SqlDbType.VarChar),
                         new SqlParameter("productid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = newid;
                    parameters[1].Value = prodid;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }


            return SQLHelper.Instance.ExecSqlByTran(sqls, parameterslist);
        }

        public bool Update()
        {
            List<string> sqls = new List<string>();
            List<SqlParameter[]> parameterslist = new List<SqlParameter[]>();

            string sql = "update Offer set subjectname=@subjectname,startTime=@starttime,state=@state,donetime=@donetime where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("subjectname",SqlDbType.VarChar),
                         new SqlParameter("startTime",SqlDbType.DateTime),
                         new SqlParameter("state",SqlDbType.Int),
                         new SqlParameter("donetime",SqlDbType.DateTime),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = tbSubjectname.Text;
            parameters[1].Value = dtpStartTime.Value;
            parameters[2].Value = Convert.ToInt32(cbWhyOffer.SelectedValue);
            parameters[3].Value = dtpDoneTime.Value;
            parameters[4].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);


            sql = "delete from Offer_Product where offerid=@offerid";
            parameters = new SqlParameter[] {
                         new SqlParameter("offerid",SqlDbType.VarChar)
                    };

            parameters[0].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);

            if (selectedIDS != null && selectedIDS.Count > 0)
            {
                foreach (var prodid in selectedIDS)
                {
                    sql = "insert into Offer_Product (offerid,productid) values(@offerid,@productid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("offerid",SqlDbType.VarChar),
                         new SqlParameter("productid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = ID;
                    parameters[1].Value = prodid;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }


            return SQLHelper.Instance.ExecSqlByTran(sqls, parameterslist);
        }

        public void LoadData(string id)
        {
            string sql = "select * from Offer where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = id;

            DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbSubjectname.Text = dt.Rows[0]["subjectname"].ToString();
                try {
                    dtpStartTime.Value = Convert.ToDateTime(dt.Rows[0]["starttime"]);
                }
                catch
                { }
                cbWhyOffer.SelectedValue = Convert.ToInt32(dt.Rows[0]["state"]);
                try
                {
                    dtpDoneTime.Value = Convert.ToDateTime(dt.Rows[0]["donetime"]);
                }
                catch
                { }
            }

            //load products
            sql = "select * from Product where id in (select productid from Offer_Product where OfferID=@offerid)";
            parameters = new SqlParameter[] {
                         new SqlParameter("offerid",SqlDbType.VarChar)
                    };
            parameters[0].Value = id;
            DataTable dtproduct = SQLHelper.Instance.GetDataTable(sql, parameters);
            
            dgProductList.DataSource =dtproduct;

            selectedIDS = new List<string>();
            foreach (DataRow row in dtproduct.Rows)
            {
                selectedIDS.Add(row["id"].ToString());   
            }
        }

        List<string> selectedIDS = new List<string>();

        private void btSelect_Click(object sender, EventArgs e)
        {
            SelectProducts selectProducts = new SelectProducts(selectedIDS);
            if (selectProducts.ShowDialog()==DialogResult.OK)
            {
                selectedIDS = selectProducts.SelectedIDS;
                dgProductList.DataSource = selectProducts.SelectedRows;
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
