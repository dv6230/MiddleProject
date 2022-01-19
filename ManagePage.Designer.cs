
namespace MiddleProject
{
    partial class ManagePage
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
            this.訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.員工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.會員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.單一訂單查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷售統計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單ToolStripMenuItem,
            this.員工ToolStripMenuItem,
            this.庫存ToolStripMenuItem,
            this.會員ToolStripMenuItem,
            this.商品ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(889, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 訂單ToolStripMenuItem
            // 
            this.訂單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單查詢ToolStripMenuItem,
            this.單一訂單查詢ToolStripMenuItem,
            this.銷售統計ToolStripMenuItem});
            this.訂單ToolStripMenuItem.Name = "訂單ToolStripMenuItem";
            this.訂單ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.訂單ToolStripMenuItem.Text = "訂單";
            // 
            // 訂單查詢ToolStripMenuItem
            // 
            this.訂單查詢ToolStripMenuItem.Name = "訂單查詢ToolStripMenuItem";
            this.訂單查詢ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.訂單查詢ToolStripMenuItem.Text = "區間訂單查詢";
            this.訂單查詢ToolStripMenuItem.Click += new System.EventHandler(this.訂單查詢ToolStripMenuItem_Click);
            // 
            // 員工ToolStripMenuItem
            // 
            this.員工ToolStripMenuItem.Name = "員工ToolStripMenuItem";
            this.員工ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.員工ToolStripMenuItem.Text = "員工";
            // 
            // 庫存ToolStripMenuItem
            // 
            this.庫存ToolStripMenuItem.Name = "庫存ToolStripMenuItem";
            this.庫存ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.庫存ToolStripMenuItem.Text = "庫存";
            // 
            // 會員ToolStripMenuItem
            // 
            this.會員ToolStripMenuItem.Name = "會員ToolStripMenuItem";
            this.會員ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.會員ToolStripMenuItem.Text = "會員";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 31);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(889, 537);
            this.contentPanel.TabIndex = 1;
            // 
            // 單一訂單查詢ToolStripMenuItem
            // 
            this.單一訂單查詢ToolStripMenuItem.Name = "單一訂單查詢ToolStripMenuItem";
            this.單一訂單查詢ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.單一訂單查詢ToolStripMenuItem.Text = "單一訂單查詢";
            // 
            // 銷售統計ToolStripMenuItem
            // 
            this.銷售統計ToolStripMenuItem.Name = "銷售統計ToolStripMenuItem";
            this.銷售統計ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.銷售統計ToolStripMenuItem.Text = "區間銷售統計";
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增商品ToolStripMenuItem,
            this.管理商品ToolStripMenuItem,
            this.配料管理ToolStripMenuItem});
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.商品ToolStripMenuItem.Text = "商品";
            // 
            // 新增商品ToolStripMenuItem
            // 
            this.新增商品ToolStripMenuItem.Name = "新增商品ToolStripMenuItem";
            this.新增商品ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.新增商品ToolStripMenuItem.Text = "新增商品";
            // 
            // 管理商品ToolStripMenuItem
            // 
            this.管理商品ToolStripMenuItem.Name = "管理商品ToolStripMenuItem";
            this.管理商品ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.管理商品ToolStripMenuItem.Text = "管理商品";
            // 
            // 配料管理ToolStripMenuItem
            // 
            this.配料管理ToolStripMenuItem.Name = "配料管理ToolStripMenuItem";
            this.配料管理ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.配料管理ToolStripMenuItem.Text = "配料管理";
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 568);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagePage";
            this.Text = "ManagePage";
            this.Load += new System.EventHandler(this.ManagePage_Load);
            this.SizeChanged += new System.EventHandler(this.ManagePage_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 訂單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 員工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 會員ToolStripMenuItem;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ToolStripMenuItem 單一訂單查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷售統計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配料管理ToolStripMenuItem;
    }
}