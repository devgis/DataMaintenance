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

namespace Main.SubjectForms
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
            if (string.IsNullOrEmpty(tbSubjectname.Text.Trim()))
            {
                MessageBox.Show("Name不能为空");
                tbSubjectname.Focus();
                return false;
            }

            foreach (DataGridViewRow row in dgProductList.Rows)
            {
                decimal quantity = 0m;
                try
                {
                    quantity = Convert.ToDecimal(row.Cells["CQuantity"].Value);
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Quantity必须为为大于0的数值类型！");
                        dgProductList.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Quantity必须为数值类型！");
                    dgProductList.Focus();
                    return false;
                }
            }
            return true;
        }

        public bool Add()
        {
            string newid = Guid.NewGuid().ToString();
            List<string> sqls = new List<string>();
            List<SqlParameter[]> parameterslist = new List<SqlParameter[]>();
            string sql = "insert into Subject (id,name) values(@id,@name)";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("name",SqlDbType.VarChar),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = tbSubjectname.Text;
            parameters[1].Value = newid;
            sqls.Add(sql);
            parameterslist.Add(parameters);

            //products
            if (selectedIDS != null && selectedIDS.Count > 0)
            {
                foreach (DataGridViewRow row in dgProductList.Rows)
                {
                    string prodid = row.Cells["CID"].Value.ToString();
                    decimal quantity = 0m;
                    try
                    {
                        quantity = Convert.ToDecimal(row.Cells["CQuantity"].Value);
                    }
                    catch
                    { }
                    sql = "insert into Subject_Product (subjectid,productid,quantity) values(@subjectid,@productid,@quantity)";
                    parameters = new SqlParameter[] {
                        new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("productid",SqlDbType.VarChar),
                         new SqlParameter("quantity",SqlDbType.Decimal)
                    };

                    parameters[0].Value = newid;
                    parameters[1].Value = prodid;
                    parameters[2].Value = quantity;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }

            //subject
            if (selectedSubjectIDS != null && selectedSubjectIDS.Count > 0)
            {
                foreach (var subjectid in selectedSubjectIDS)
                {
                    sql = "insert into Subject_Subject (subjectid,subsubjectid) values(@subjectid,@subsubjectid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("subsubjectid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = newid;
                    parameters[1].Value = subjectid;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }

            //offers
            if (selectedOfferIDS != null && selectedOfferIDS.Count > 0)
            {
                foreach (var offerid in selectedOfferIDS)
                {
                    sql = "insert into Subject_Offer (subjectid,offerid) values(@subjectid,@offerid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("offerid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = newid;
                    parameters[1].Value = offerid;

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

            string sql = "update Subject set name=@name where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("name",SqlDbType.VarChar),
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = tbSubjectname.Text;
            parameters[1].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);


            sql = "delete from Subject_Product where subjectid=@subjectid";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };

            parameters[0].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);

            sql = "delete from Subject_Subject where subjectid=@subjectid";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };

            parameters[0].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);

            sql = "delete from Subject_Offer where subjectid=@subjectid";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };

            parameters[0].Value = ID;
            sqls.Add(sql);
            parameterslist.Add(parameters);

            //products
            if (selectedIDS != null && selectedIDS.Count > 0)
            {
                foreach (DataGridViewRow row in dgProductList.Rows)
                {
                    string prodid = row.Cells["CID"].Value.ToString();
                    decimal quantity = 0m;
                    try
                    {
                        quantity = Convert.ToDecimal(row.Cells["CQuantity"].Value);
                    }
                    catch
                    { }
                    sql = "insert into Subject_Product (subjectid,productid,quantity) values(@subjectid,@productid,@quantity)";
                    parameters = new SqlParameter[] {
                        new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("productid",SqlDbType.VarChar),
                         new SqlParameter("quantity",SqlDbType.Decimal)
                    };

                    parameters[0].Value = ID;
                    parameters[1].Value = prodid;
                    parameters[2].Value = quantity;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }

            //subject
            if (selectedSubjectIDS != null && selectedSubjectIDS.Count > 0)
            {
                foreach (var subjectid in selectedSubjectIDS)
                {
                    sql = "insert into Subject_Subject (subjectid,subsubjectid) values(@subjectid,@subsubjectid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("subsubjectid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = ID;
                    parameters[1].Value = subjectid;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }

            //offers
            if (selectedOfferIDS != null && selectedOfferIDS.Count > 0)
            {
                foreach (var offerid in selectedOfferIDS)
                {
                    sql = "insert into Subject_Offer (subjectid,offerid) values(@subjectid,@offerid)";
                    parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar),
                         new SqlParameter("offerid",SqlDbType.VarChar)
                    };

                    parameters[0].Value = ID;
                    parameters[1].Value = offerid;

                    sqls.Add(sql);
                    parameterslist.Add(parameters);
                }
            }


            return SQLHelper.Instance.ExecSqlByTran(sqls, parameterslist);
        }

        public void LoadData(string id)
        {
            string sql = "select * from Subject where id=@id";
            SqlParameter[] parameters = new SqlParameter[] {
                         new SqlParameter("id",SqlDbType.VarChar)
                    };

            parameters[0].Value = id;

            DataTable dt = SQLHelper.Instance.GetDataTable(sql, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbSubjectname.Text = dt.Rows[0]["name"].ToString();
            }

            //load products
            sql = "select p.id,p.name,p.price,sp.quantity from Subject s left join Subject_Product sp on s.ID=sp.SubjectID left join Product p on sp.ProductID=p.id where s.ID=@subjectid";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };
            parameters[0].Value = id;
            DataTable dtproduct = SQLHelper.Instance.GetDataTable(sql, parameters);
            
            dgProductList.DataSource =dtproduct;

            selectedIDS = new List<string>();
            foreach (DataRow row in dtproduct.Rows)
            {
                selectedIDS.Add(row["id"].ToString());   
            }

            //load offers
            sql = "select * from Offer where id in (select offerid from Subject_Offer where subjectid=@subjectid)";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };
            parameters[0].Value = id;
            DataTable dtoffer = SQLHelper.Instance.GetDataTable(sql, parameters);

            dgOfferList.DataSource = dtoffer;

            selectedOfferIDS = new List<string>();
            foreach (DataRow row in dtoffer.Rows)
            {
                selectedOfferIDS.Add(row["id"].ToString());
            }

            //load subjects
            sql = "select * from Subject where id in (select SubSubjectID from Subject_Subject where subjectid=@subjectid)";
            parameters = new SqlParameter[] {
                         new SqlParameter("subjectid",SqlDbType.VarChar)
                    };
            parameters[0].Value = id;
            DataTable dtsubject = SQLHelper.Instance.GetDataTable(sql, parameters);
            dgSubjectList.DataSource = dtsubject;

            selectedSubjectIDS = new List<string>();
            foreach (DataRow row in dtsubject.Rows)
            {
                selectedSubjectIDS.Add(row["id"].ToString());
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

        List<string> selectedSubjectIDS = new List<string>();

        List<string> selectedOfferIDS = new List<string>();

        private void btSelectSubject_Click(object sender, EventArgs e)
        {
            SelectSubject selectSubject = new SelectSubject(selectedSubjectIDS);
            if (selectSubject.ShowDialog() == DialogResult.OK)
            {
                selectedSubjectIDS = selectSubject.SelectedIDS;
                dgSubjectList.DataSource = selectSubject.SelectedRows;
            }
        }

        private void btSelectOffer_Click(object sender, EventArgs e)
        {
            SelectOffer selectOffer = new SelectOffer(selectedOfferIDS);
            if (selectOffer.ShowDialog() == DialogResult.OK)
            {
                selectedOfferIDS = selectOffer.SelectedIDS;
                dgOfferList.DataSource = selectOffer.SelectedRows;
            }
        }
    }
}
