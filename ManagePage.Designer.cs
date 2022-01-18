
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單ToolStripMenuItem,
            this.員工ToolStripMenuItem,
            this.庫存ToolStripMenuItem,
            this.會員ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(790, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 訂單ToolStripMenuItem
            // 
            this.訂單ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.訂單查詢ToolStripMenuItem});
            this.訂單ToolStripMenuItem.Name = "訂單ToolStripMenuItem";
            this.訂單ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.訂單ToolStripMenuItem.Text = "訂單";
            // 
            // 訂單查詢ToolStripMenuItem
            // 
            this.訂單查詢ToolStripMenuItem.Name = "訂單查詢ToolStripMenuItem";
            this.訂單查詢ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.訂單查詢ToolStripMenuItem.Text = "區間訂單查詢";
            this.訂單查詢ToolStripMenuItem.Click += new System.EventHandler(this.訂單查詢ToolStripMenuItem_Click);
            // 
            // 員工ToolStripMenuItem
            // 
            this.員工ToolStripMenuItem.Name = "員工ToolStripMenuItem";
            this.員工ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.員工ToolStripMenuItem.Text = "員工";
            // 
            // 庫存ToolStripMenuItem
            // 
            this.庫存ToolStripMenuItem.Name = "庫存ToolStripMenuItem";
            this.庫存ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.庫存ToolStripMenuItem.Text = "庫存";
            // 
            // 會員ToolStripMenuItem
            // 
            this.會員ToolStripMenuItem.Name = "會員ToolStripMenuItem";
            this.會員ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.會員ToolStripMenuItem.Text = "會員";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.button3);
            this.contentPanel.Controls.Add(this.button2);
            this.contentPanel.Controls.Add(this.button1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 27);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(790, 446);
            this.contentPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 473);
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
            this.contentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}