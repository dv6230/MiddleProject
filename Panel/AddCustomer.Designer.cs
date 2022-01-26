namespace MiddleProject.Panel
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearTxtBox = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tpBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.showIsUsedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "電話";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tBoxName.Location = new System.Drawing.Point(155, 32);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(157, 30);
            this.tBoxName.TabIndex = 2;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tBoxPhone.Location = new System.Drawing.Point(155, 89);
            this.tBoxPhone.MaxLength = 10;
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(157, 30);
            this.tBoxPhone.TabIndex = 3;
            this.tBoxPhone.TextChanged += new System.EventHandler(this.tBoxPhone_TextChanged);
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tBoxAddress.Location = new System.Drawing.Point(155, 201);
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(237, 30);
            this.tBoxAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(46, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "地址";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tBoxEmail.Location = new System.Drawing.Point(155, 259);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(237, 30);
            this.tBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(46, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "email";
            // 
            // btnClearTxtBox
            // 
            this.btnClearTxtBox.Location = new System.Drawing.Point(463, 247);
            this.btnClearTxtBox.Name = "btnClearTxtBox";
            this.btnClearTxtBox.Size = new System.Drawing.Size(104, 38);
            this.btnClearTxtBox.TabIndex = 8;
            this.btnClearTxtBox.Text = "清空";
            this.btnClearTxtBox.UseVisualStyleBackColor = true;
            this.btnClearTxtBox.Click += new System.EventHandler(this.btnClearTxtBox_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.Location = new System.Drawing.Point(463, 309);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(104, 38);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "送出";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(160, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("新細明體", 12F);
            this.radioButton2.Location = new System.Drawing.Point(82, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女性";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男性";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(46, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "性別";
            // 
            // tpBirth
            // 
            this.tpBirth.CalendarFont = new System.Drawing.Font("新細明體", 10F);
            this.tpBirth.Font = new System.Drawing.Font("新細明體", 12F);
            this.tpBirth.Location = new System.Drawing.Point(156, 318);
            this.tpBirth.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.tpBirth.Name = "tpBirth";
            this.tpBirth.Size = new System.Drawing.Size(200, 31);
            this.tpBirth.TabIndex = 12;
            this.tpBirth.Value = new System.DateTime(2022, 1, 26, 11, 7, 18, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(46, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "生日";
            // 
            // showIsUsedLabel
            // 
            this.showIsUsedLabel.AutoSize = true;
            this.showIsUsedLabel.BackColor = System.Drawing.Color.Transparent;
            this.showIsUsedLabel.ForeColor = System.Drawing.Color.Red;
            this.showIsUsedLabel.Location = new System.Drawing.Point(319, 99);
            this.showIsUsedLabel.Name = "showIsUsedLabel";
            this.showIsUsedLabel.Size = new System.Drawing.Size(82, 15);
            this.showIsUsedLabel.TabIndex = 14;
            this.showIsUsedLabel.Text = "電話被使用";
            this.showIsUsedLabel.Visible = false;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showIsUsedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tpBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnClearTxtBox);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxPhone);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Size = new System.Drawing.Size(624, 434);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearTxtBox;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tpBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label showIsUsedLabel;
    }
}
