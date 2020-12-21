namespace Main
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOffer = new System.Windows.Forms.ToolStripMenuItem();
            this.miProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.miSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.miTreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tiOffer = new System.Windows.Forms.ToolStripButton();
            this.toolProduct = new System.Windows.Forms.ToolStripButton();
            this.toolSubject = new System.Windows.Forms.ToolStripButton();
            this.toolTreeView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.帮助关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(900, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(170, 26);
            this.miExit.Text = "退出系统(&E)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOffer,
            this.miProduct,
            this.miSubject,
            this.miTreeView});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.功能ToolStripMenuItem.Text = "功能(&F)";
            // 
            // miOffer
            // 
            this.miOffer.Name = "miOffer";
            this.miOffer.Size = new System.Drawing.Size(179, 26);
            this.miOffer.Text = "Offer(&O)";
            this.miOffer.ToolTipText = "Offer管理";
            this.miOffer.Click += new System.EventHandler(this.miOffer_Click);
            // 
            // miProduct
            // 
            this.miProduct.Name = "miProduct";
            this.miProduct.Size = new System.Drawing.Size(179, 26);
            this.miProduct.Text = "Product(&P)";
            this.miProduct.ToolTipText = "Product管理";
            this.miProduct.Click += new System.EventHandler(this.miProduct_Click);
            // 
            // miSubject
            // 
            this.miSubject.Name = "miSubject";
            this.miSubject.Size = new System.Drawing.Size(179, 26);
            this.miSubject.Text = "Subject(&S)";
            this.miSubject.ToolTipText = "Subject管理";
            this.miSubject.Click += new System.EventHandler(this.miSubject_Click);
            // 
            // miTreeView
            // 
            this.miTreeView.Name = "miTreeView";
            this.miTreeView.Size = new System.Drawing.Size(179, 26);
            this.miTreeView.Text = "TreeView(&T)";
            this.miTreeView.Click += new System.EventHandler(this.miTreeView_Click);
            // 
            // 帮助关于ToolStripMenuItem
            // 
            this.帮助关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.帮助关于ToolStripMenuItem.Name = "帮助关于ToolStripMenuItem";
            this.帮助关于ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.帮助关于ToolStripMenuItem.Text = "关于(&B)";
            this.帮助关于ToolStripMenuItem.Click += new System.EventHandler(this.miTreeView_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(143, 26);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.tiOffer,
            this.toolProduct,
            this.toolSubject,
            this.toolTreeView,
            this.toolStripSeparator1,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Main.Properties.Resources.exti;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "退出";
            this.toolStripButton1.Click += new System.EventHandler(this.miExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tiOffer
            // 
            this.tiOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tiOffer.Image = global::Main.Properties.Resources._3;
            this.tiOffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tiOffer.Name = "tiOffer";
            this.tiOffer.Size = new System.Drawing.Size(29, 24);
            this.tiOffer.Text = "Offer";
            this.tiOffer.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tiOffer.ToolTipText = "Offer管理";
            this.tiOffer.Click += new System.EventHandler(this.miOffer_Click);
            // 
            // toolProduct
            // 
            this.toolProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProduct.Image = global::Main.Properties.Resources.pv;
            this.toolProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProduct.Name = "toolProduct";
            this.toolProduct.Size = new System.Drawing.Size(29, 24);
            this.toolProduct.Text = "Product";
            this.toolProduct.ToolTipText = "Product管理";
            this.toolProduct.Click += new System.EventHandler(this.miProduct_Click);
            // 
            // toolSubject
            // 
            this.toolSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSubject.Image = global::Main.Properties.Resources._4;
            this.toolSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSubject.Name = "toolSubject";
            this.toolSubject.Size = new System.Drawing.Size(29, 24);
            this.toolSubject.Text = "Subject";
            this.toolSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolSubject.ToolTipText = "Subject管理";
            this.toolSubject.Click += new System.EventHandler(this.miSubject_Click);
            // 
            // toolTreeView
            // 
            this.toolTreeView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTreeView.Image = global::Main.Properties.Resources._2;
            this.toolTreeView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTreeView.Name = "toolTreeView";
            this.toolTreeView.Size = new System.Drawing.Size(29, 24);
            this.toolTreeView.Text = "TreeView";
            this.toolTreeView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTreeView.ToolTipText = "Treeview";
            this.toolTreeView.Click += new System.EventHandler(this.miTreeView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Main.Properties.Resources._6;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "关于";
            this.toolStripButton6.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据管理程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOffer;
        private System.Windows.Forms.ToolStripMenuItem miProduct;
        private System.Windows.Forms.ToolStripMenuItem miSubject;
        private System.Windows.Forms.ToolStripMenuItem 帮助关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tiOffer;
        private System.Windows.Forms.ToolStripButton toolProduct;
        private System.Windows.Forms.ToolStripButton toolSubject;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miTreeView;
        private System.Windows.Forms.ToolStripButton toolTreeView;
    }
}