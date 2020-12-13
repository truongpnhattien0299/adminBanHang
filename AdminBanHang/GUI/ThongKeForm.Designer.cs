namespace AdminBanHang.GUI
{
    partial class ThongKeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewData = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongkeToolStripMenuItem,
            this.TrendingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThongkeToolStripMenuItem
            // 
            this.ThongkeToolStripMenuItem.Name = "ThongkeToolStripMenuItem";
            this.ThongkeToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.ThongkeToolStripMenuItem.Text = "Thống kê Doanh thu";
            // 
            // TrendingToolStripMenuItem
            // 
            this.TrendingToolStripMenuItem.Name = "TrendingToolStripMenuItem";
            this.TrendingToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.TrendingToolStripMenuItem.Text = "Sản phẩm bán chạy";
            this.TrendingToolStripMenuItem.Click += new System.EventHandler(this.TrendingToolStripMenuItem_Click);
            // 
            // listViewData
            // 
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(12, 95);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(1014, 423);
            this.listViewData.TabIndex = 1;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 530);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThongkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrendingToolStripMenuItem;
        private System.Windows.Forms.ListView listViewData;
    }
}