namespace Main.Offer
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubjectname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWhyOffer = new System.Windows.Forms.ComboBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDoneTime = new System.Windows.Forms.DateTimePicker();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgList, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbSubjectname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbWhyOffer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpDoneTime, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbProducts, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subjectname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(38, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(46, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "WhyOffer";
            // 
            // tbSubjectname
            // 
            this.tbSubjectname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubjectname.Location = new System.Drawing.Point(123, 43);
            this.tbSubjectname.Name = "tbSubjectname";
            this.tbSubjectname.Size = new System.Drawing.Size(440, 25);
            this.tbSubjectname.TabIndex = 7;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 34);
            this.panel1.TabIndex = 13;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(322, 6);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(212, 6);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "确定";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(46, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "DoneTime";
            // 
            // cbWhyOffer
            // 
            this.cbWhyOffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWhyOffer.FormattingEnabled = true;
            this.cbWhyOffer.Location = new System.Drawing.Point(123, 103);
            this.cbWhyOffer.Name = "cbWhyOffer";
            this.cbWhyOffer.Size = new System.Drawing.Size(440, 23);
            this.cbWhyOffer.TabIndex = 15;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(123, 73);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(440, 25);
            this.dtpStartTime.TabIndex = 16;
            // 
            // dtpDoneTime
            // 
            this.dtpDoneTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpDoneTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDoneTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoneTime.Location = new System.Drawing.Point(123, 133);
            this.dtpDoneTime.Name = "dtpDoneTime";
            this.dtpDoneTime.Size = new System.Drawing.Size(440, 25);
            this.dtpDoneTime.TabIndex = 17;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(123, 163);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(440, 23);
            this.cbProducts.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(22, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "ProductList";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(569, 163);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(44, 23);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CName,
            this.CPrice,
            this.CQuantity});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point(123, 193);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgList, 4);
            this.dgList.RowTemplate.Height = 27;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(440, 114);
            this.dgList.TabIndex = 21;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            this.CID.Width = 60;
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.DataPropertyName = "name";
            this.CName.HeaderText = "Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CPrice
            // 
            this.CPrice.DataPropertyName = "price";
            this.CPrice.HeaderText = "Price";
            this.CPrice.MinimumWidth = 6;
            this.CPrice.Name = "CPrice";
            this.CPrice.ReadOnly = true;
            this.CPrice.Width = 125;
            // 
            // CQuantity
            // 
            this.CQuantity.DataPropertyName = "quantity";
            this.CQuantity.HeaderText = "Quantity";
            this.CQuantity.MinimumWidth = 6;
            this.CQuantity.Name = "CQuantity";
            this.CQuantity.ReadOnly = true;
            this.CQuantity.Width = 125;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubjectname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWhyOffer;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpDoneTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQuantity;
    }
}