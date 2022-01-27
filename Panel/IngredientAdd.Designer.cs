namespace MiddleProject.Panel
{
    partial class IngredientAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxIgredientName = new System.Windows.Forms.TextBox();
            this.tBoxIgredientPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(423, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(123, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "配料單價";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxIgredientName
            // 
            this.tBoxIgredientName.Font = new System.Drawing.Font("新細明體", 12F);
            this.tBoxIgredientName.Location = new System.Drawing.Point(255, 113);
            this.tBoxIgredientName.Name = "tBoxIgredientName";
            this.tBoxIgredientName.Size = new System.Drawing.Size(125, 31);
            this.tBoxIgredientName.TabIndex = 3;
            // 
            // tBoxIgredientPrice
            // 
            this.tBoxIgredientPrice.Font = new System.Drawing.Font("新細明體", 12F);
            this.tBoxIgredientPrice.Location = new System.Drawing.Point(255, 173);
            this.tBoxIgredientPrice.Name = "tBoxIgredientPrice";
            this.tBoxIgredientPrice.Size = new System.Drawing.Size(125, 31);
            this.tBoxIgredientPrice.TabIndex = 4;
            this.tBoxIgredientPrice.Text = "0";
            this.tBoxIgredientPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(123, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "配料名稱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngredientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxIgredientPrice);
            this.Controls.Add(this.tBoxIgredientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "IngredientAdd";
            this.Size = new System.Drawing.Size(790, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxIgredientName;
        private System.Windows.Forms.TextBox tBoxIgredientPrice;
        private System.Windows.Forms.Label label1;
    }
}
