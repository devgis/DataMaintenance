namespace Main
{
    partial class TreeviewWindow
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
            this.tvSubjects = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvSubjects
            // 
            this.tvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSubjects.Location = new System.Drawing.Point(0, 0);
            this.tvSubjects.Name = "tvSubjects";
            this.tvSubjects.Size = new System.Drawing.Size(800, 450);
            this.tvSubjects.TabIndex = 0;
            // 
            // TreeviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvSubjects);
            this.Name = "TreeviewWindow";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TreeviewWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvSubjects;
    }
}