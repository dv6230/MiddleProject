
namespace MiddleProject.Panel
{
    partial class SearchOrderPanel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 73);
            this.panel1.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(23, 23);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(151, 29);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "區間訂單查詢";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 402);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.startTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.endTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 59);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("新細明體", 12F);
            this.startTimePicker.Location = new System.Drawing.Point(28, 13);
            this.startTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.startTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(187, 31);
            this.startTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(221, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("新細明體", 12F);
            this.endTimePicker.Location = new System.Drawing.Point(268, 13);
            this.endTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.endTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(187, 31);
            this.endTimePicker.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(488, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(668, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // SearchOrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SearchOrderPanel";
            this.Size = new System.Drawing.Size(744, 475);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.SizeChanged += new System.EventHandler(this.UserControl1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
