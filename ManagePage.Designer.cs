
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
            this.員工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.會員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
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
            this.會員ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 訂單ToolStripMenuItem
            // 
            this.訂單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單查詢ToolStripMenuItem});
            this.訂單ToolStripMenuItem.Name = "訂單ToolStripMenuItem";
            this.訂單ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.訂單ToolStripMenuItem.Text = "訂單";
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
            // 訂單查詢ToolStripMenuItem
            // 
            this.訂單查詢ToolStripMenuItem.Name = "訂單查詢ToolStripMenuItem";
            this.訂單查詢ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.訂單查詢ToolStripMenuItem.Text = "訂單查詢";
            // 
            // 會員ToolStripMenuItem
            // 
            this.會員ToolStripMenuItem.Name = "會員ToolStripMenuItem";
            this.會員ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.會員ToolStripMenuItem.Text = "會員";
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(0, 34);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(200, 100);
            this.contentPanel.TabIndex = 1;
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 568);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
    }
}