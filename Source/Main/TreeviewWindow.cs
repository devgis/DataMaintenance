using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class TreeviewWindow : Form
    {
        public TreeviewWindow()
        {
            InitializeComponent();
        }

        private void TreeviewWindow_Load(object sender, EventArgs e)
        {
            List<Subject> list = GetList();
            if (list != null && list.Count > 0)
            {
                foreach (Subject s in list)
                {
                    TreeNode t = CreateSubjectNode(s);

                    tvSubjects.Nodes.Add(t);
                }

            }
            tvSubjects.ExpandAll();
        }

        private TreeNode CreateSubjectNode(Subject s)
        {
            TreeNode t = new TreeNode("Subject:" + s.name);
            if (s.net != null && s.net.Count > 0)
            {
                TreeNode tSubject = new TreeNode("SubjectLists:");
                foreach (var subsub in s.net)
                {
                    TreeNode tsubsub = CreateSubjectNode(subsub);
                    tSubject.Nodes.Add(tsubsub);
                }
                t.Nodes.Add(tSubject);
            }

            if (s.onhand != null && s.onhand.Count > 0)
            {
                TreeNode tSubject = new TreeNode("ProductLists:");
                foreach (var subsub in s.onhand)
                {
                    TreeNode tsubsub = new TreeNode(subsub.name + " " + subsub.price + " " + subsub.quantity);
                    tSubject.Nodes.Add(tsubsub);
                }
                t.Nodes.Add(tSubject);
            }

            if (s.plan != null && s.plan.Count > 0)
            {
                TreeNode tSubject = new TreeNode("OfferLists:");
                foreach (var offer in s.plan)
                {
                    TreeNode tsubsub = new TreeNode(offer.subjectname);
                    tSubject.Nodes.Add(tsubsub);
                }
                t.Nodes.Add(tSubject);
            }

            return t;
        }

        public List<Subject> GetList()
        {
            List<Subject> list = new List<Subject>();

            //subject
            string sql = "select * from subject";
            DataTable dtSubject = SQLHelper.Instance.GetDataTable(sql);
            if (dtSubject != null && dtSubject.Rows.Count > 0)
            {
                //load sbujct_products
                sql = "select s.ID as SubjectID,p.id,p.name,p.price,sp.quantity from Subject s left join Subject_Product sp on s.ID=sp.SubjectID left join Product p on sp.ProductID=p.id ";
                DataTable sbujct_products = SQLHelper.Instance.GetDataTable(sql);
                //load sbujct_offers
                sql = "select so.SubjectID,* from  Subject_Offer so left join Offer o on o.id=so.OfferID";
                DataTable sbujct_offers = SQLHelper.Instance.GetDataTable(sql);

                //offer_products
                sql = "select o.ID as SubjectID,p.id,p.name,p.price,op.quantity from Offer o left join Offer_Product op on o.ID=op.OfferID left join Product p on op.ProductID=p.id ";
                DataTable offer_products = SQLHelper.Instance.GetDataTable(sql);

                //load sbujct_subjects
                sql = "select ss.SubjectID,* from  Subject_Subject ss left join Subject s on ss.SubSubjectID=s.id";
                DataTable sbujct_subjects = SQLHelper.Instance.GetDataTable(sql);

                foreach (DataRow row in dtSubject.Rows)
                {
                    string subjectid = row["id"].ToString();
                    Subject subject= GetSubJect(subjectid, dtSubject, sbujct_subjects, sbujct_products, sbujct_offers, offer_products);
                    list.Add(subject);
                }
            }

            return list;
        }

        private Subject GetSubJect(string subjectid, DataTable dtSubject, DataTable sbujct_subjects, DataTable sbujct_products, DataTable sbujct_offers, DataTable offer_products)
        {
            DataRow[] querysubject = dtSubject.Select(string.Format("id='{0}'", subjectid));
            if (string.IsNullOrEmpty(subjectid)||querysubject == null || querysubject.Length <= 0)
            {
                return null;
            }
            DataRow row = querysubject[0];
            Subject subject = new Subject();
            subject.name = row["name"].ToString();
            subject.net = new List<Subject>();
            subject.onhand = new List<Product>();
            subject.plan = new List<Offer>();

            DataRow[] sbujct_offers_arr = sbujct_offers.Select(string.Format("SubjectID='{0}'", subjectid));
            if (sbujct_offers_arr != null && sbujct_offers_arr.Length > 0)
            {
                foreach (var row_offer in sbujct_offers_arr)
                {
                    Offer o = new Offer();
                    string offerid = row_offer["id"].ToString();
                    o.doneTime = Convert.ToDateTime(row_offer["doneTime"]);
                    o.productList = new List<Product>();
                    o.startTime = Convert.ToDateTime(row_offer["startTime"]);
                    o.state = (WhyOffer)Convert.ToInt32(row_offer["state"]);
                    o.subjectname = row_offer["subjectname"].ToString();
                    subject.plan.Add(o);
                }
            }

            DataRow[] sbujct_product_arr = sbujct_products.Select(string.Format("SubjectID='{0}'", subjectid));
            if (sbujct_product_arr != null && sbujct_product_arr.Length > 0)
            {
                foreach (var row_product in sbujct_product_arr)
                {
                    Product o = new Product();
                    string offerid = row_product["id"].ToString();
                    o.name = row_product["name"].ToString();
                    o.price = Convert.ToDouble(row_product["price"]);
                    o.quantity = Convert.ToDouble(row_product["quantity"]);
                    subject.onhand.Add(o);
                }
            }

            DataRow[] sbujct_subject_arr = sbujct_subjects.Select(string.Format("SubjectID='{0}'", subjectid));
            if (sbujct_subject_arr != null && sbujct_subject_arr.Length > 0)
            {
                foreach (var row_subject in sbujct_subject_arr)
                {
                    string id = row_subject["id"].ToString();
                    if(id!= subjectid)
                    {
                        Subject o = GetSubJect(row_subject["id"].ToString(), dtSubject, sbujct_subjects, sbujct_products, sbujct_offers, offer_products);
                        if (o != null)
                        {
                            subject.net.Add(o);
                        }
                    }
                }
            }
            return subject;
        }
    }

    public enum WhyOffer { OFFERER = 1000, OFFEREE = 1001, DEAL = 1002, HELPLESS = 1003 };
    public class Offer
    {
        public string subjectname;
        public DateTime startTime;
        public List<Product> productList;
        public WhyOffer state;
        public DateTime doneTime;
    }
    public class Product
    {
        public string name;
        public double price;
        public double quantity;
        public double getTotal() { return price * quantity; }
    }

    public class Subject
    {
        public string name;
        public List<Subject> net;
        public List<Offer> plan;
        public List<Product> onhand;
        public WhyOffer trade() { return WhyOffer.DEAL; }
    }
}
