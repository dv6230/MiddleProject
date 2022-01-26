
namespace MiddleProject
{
    partial class FrontSide
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseSystem = new System.Windows.Forms.Button();
            this.SlideBackEndBtn = new System.Windows.Forms.Button();
            this.slideAddMemberBtn = new System.Windows.Forms.Button();
            this.slideOrderBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCloseSystem);
            this.panel1.Controls.Add(this.SlideBackEndBtn);
            this.panel1.Controls.Add(this.slideAddMemberBtn);
            this.panel1.Controls.Add(this.slideOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 558);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseSystem
            // 
            this.btnCloseSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCloseSystem.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnCloseSystem.Location = new System.Drawing.Point(0, 481);
            this.btnCloseSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseSystem.Name = "btnCloseSystem";
            this.btnCloseSystem.Size = new System.Drawing.Size(180, 38);
            this.btnCloseSystem.TabIndex = 3;
            this.btnCloseSystem.Text = "關閉";
            this.btnCloseSystem.UseVisualStyleBackColor = false;
            this.btnCloseSystem.Click += new System.EventHandler(this.btnCloseSystem_Click);
            // 
            // SlideBackEndBtn
            // 
            this.SlideBackEndBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SlideBackEndBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SlideBackEndBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SlideBackEndBtn.Location = new System.Drawing.Point(0, 413);
            this.SlideBackEndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SlideBackEndBtn.Name = "SlideBackEndBtn";
            this.SlideBackEndBtn.Size = new System.Drawing.Size(180, 50);
            this.SlideBackEndBtn.TabIndex = 2;
            this.SlideBackEndBtn.Text = "後台管理";
            this.SlideBackEndBtn.UseVisualStyleBackColor = false;
            this.SlideBackEndBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // slideAddMemberBtn
            // 
            this.slideAddMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slideAddMemberBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideAddMemberBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slideAddMemberBtn.Location = new System.Drawing.Point(0, 87);
            this.slideAddMemberBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slideAddMemberBtn.Name = "slideAddMemberBtn";
            this.slideAddMemberBtn.Size = new System.Drawing.Size(180, 50);
            this.slideAddMemberBtn.TabIndex = 1;
            this.slideAddMemberBtn.Text = "新增會員";
            this.slideAddMemberBtn.UseVisualStyleBackColor = false;
            this.slideAddMemberBtn.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // slideOrderBtn
            // 
            this.slideOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slideOrderBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.slideOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slideOrderBtn.Location = new System.Drawing.Point(0, 23);
            this.slideOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slideOrderBtn.Name = "slideOrderBtn";
            this.slideOrderBtn.Size = new System.Drawing.Size(180, 50);
            this.slideOrderBtn.TabIndex = 0;
            this.slideOrderBtn.Text = "點餐";
            this.slideOrderBtn.UseVisualStyleBackColor = false;
            this.slideOrderBtn.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(709, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 558);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(180, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 558);
            this.panel3.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(392, 507);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "加入";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(521, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(515, 298);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(392, 457);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 32);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "加入";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "甜度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(87, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 36);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(87, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 36);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "冰塊";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrontSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrontSide";
            this.Text = "點餐";
            this.Load += new System.EventHandler(this.FrontOperate_Load);
            this.SizeChanged += new System.EventHandler(this.FrontOperate_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCloseSystem;
        private System.Windows.Forms.Button SlideBackEndBtn;
        private System.Windows.Forms.Button slideAddMemberBtn;
        private System.Windows.Forms.Button slideOrderBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}