using MiddleProject.Panel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class FrontSide : Form
    {

        int padwidth = 22;
        // List<Control> controls = new List<Control>();

        Panel.AddCustomer addCustomer = new Panel.AddCustomer();

        Color sideDefaultColor = Color.FromArgb(64, 64, 64);
        Color activeColor = Color.Gray;

        Model.Product product1 = new Model.Product();

        List<Model.Ingredients> selectItem = new List<Model.Ingredients>();

        public FrontSide()
        {
            InitializeComponent();
        }

        private void FrontOperate_Load(object sender, EventArgs e)
        {
            slideOrderBtn.BackColor = activeColor;

            ReFreshProduct();

            panel4.Size = new Size(new Panel.UserPurchaseItem().Width + padwidth + 5, this.Height);
            panel3.Size = new Size((int)((this.Width - panel1.Width - panel4.Width)), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);

            authCheck();

        }

        void authCheck()
        {
            if (!Model.GolbalVar.userPermissionList.Contains("後台"))
            {
                SlideBackEndBtn.Visible = false;
            }
            if (!Model.GolbalVar.userPermissionList.Contains("新增會員"))
            {
                slideAddMemberBtn.Visible = false;
            }
        }

        private void productDetail(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Model.Product p = (Model.Product)button.Tag;
            product1 = new Model.Product(p.Name, p.Price);

            itemNameLabel.Text = p.Name;
            itemPriceLabel.Text = p.Price.ToString();

            ingredientPanel.Controls.Clear();
            foreach (var item in p.ingredient)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.name;
                cb.BackColor = Color.LightBlue;
                cb.AutoSize = true;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.Padding = new Padding(4);
                cb.Tag = item;
                cb.CheckedChanged += Cb_CheckedChanged;
                ingredientPanel.Controls.Add(cb);
            }
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Model.Ingredients tg = (Model.Ingredients)cb.Tag;
            if (cb.Checked)
            {
                selectItem.Add(tg);
            }
            else
            {
                selectItem.Remove(tg);
            }

            //throw new NotImplementedException();
        }

        private void Tpg_SizeChanged(object sender, EventArgs e)
        {
            var p = (TabPage)sender;
            Control.ControlCollection a = p.Controls;
            if (a.Count == 0) return;
            a[0].Size = p.Size;
        }

        private void FrontOperate_SizeChanged(object sender, EventArgs e)
        {
            panel4.Size = new Size(new Panel.UserPurchaseItem().Width + padwidth, this.Height);
            panel3.Size = new Size((int)((this.Width - panel1.Width - panel4.Width)), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);
        }

        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("確定關閉嗎?", "確認", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            var manage = new ManagePage();
            // manage.Closed += (s, args) => this.ReFreshProduct();
            manage.frontSide = this;
            manage.Show();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            addCustomer = new Panel.AddCustomer();
            addCustomer.Visible = true;
            addCustomer.Location = new Point(180, 0);
            this.Controls.Add(addCustomer);
            panel3.Visible = false;
            panel4.Visible = false;
            slideBtnColor(slideAddMemberBtn);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            addCustomer.Visible = false;
            slideBtnColor(slideOrderBtn);
        }

        void slideBtnColor(Button btn)
        {
            slideOrderBtn.BackColor = sideDefaultColor;
            slideAddMemberBtn.BackColor = sideDefaultColor;
            btn.BackColor = activeColor;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (product1 == null || product1.Name == null || product1.Name.Length <= 0)
            {
                MessageBox.Show("請點餐");
                return;
            }

            int count = (int)CountSelect.Value;
            if (CountSelect.Value.ToString().Length <= 0 || count < 1)
            {
                MessageBox.Show("請輸入數量");
                return;
            }

            var p = new Model.Product(product1.Name, product1.Price);

            p.Count = count;
            p.TotalPrice = count * p.Price;
            p.UserSelectIngredient = new List<Model.Ingredients>(selectItem);

            if (radioSweet1.Checked) p.Sweet = "正常";
            else if (radioSweet2.Checked) p.Sweet = "7分糖";
            else if (radioSweet3.Checked) p.Sweet = "5分糖";
            else if (radioSweet4.Checked) p.Sweet = "3分糖";
            else if (radioSweet5.Checked) p.Sweet = "無糖";
            else
            {
                MessageBox.Show("請選擇甜度");
                return;
            }

            if (radioTemp1.Checked) p.Temperature = "正常";
            else if (radioTemp2.Checked) p.Temperature = "少冰";
            else if (radioTemp3.Checked) p.Temperature = "微冰";
            else if (radioTemp4.Checked) p.Temperature = "去冰";
            else if (radioTemp5.Checked) p.Temperature = "常溫";
            else
            {
                MessageBox.Show("請選擇冰塊");
                return;
            }

            Model.GolbalVar.purchaseList.Add(p);

            this.panel4.Controls.Clear();
            int index = 1;
            foreach (var item in Model.GolbalVar.purchaseList)
            {
                UserPurchaseItem upanel = new UserPurchaseItem();
                upanel.lblName.Text = item.Name;
                upanel.lblCount.Text = item.Count.ToString();
                upanel.lblPrice.Text = item.Price.ToString();
                upanel.lblTotalPrice.Text = item.TotalPrice.ToString();
                upanel.lblNote.Text = ingredientTostr(item.UserSelectIngredient);
                // upanel.btnDeleteItem.Click += BtnDeleteItem_Click;
                upanel.btnDeleteItem.Tag = (UserPurchaseItem)upanel;
                upanel.Tag = index;
                upanel.numberLabel.Text = index.ToString();
                panel4.Controls.Add(upanel);
                index++;
            }

            defaultSelect();

        }

        string ingredientTostr(List<Model.Ingredients> list)
        {
            string s = "";
            foreach (var item in list)
            {
                s += item.name + ", ";
            }
            if (s.Length > 2) s = s.Substring(0, s.Length - 2);
            return s;
        }

        void defaultSelect()
        {

            radioSweet1.Checked = false;
            radioSweet2.Checked = false;
            radioSweet3.Checked = false;
            radioSweet4.Checked = false;
            radioSweet5.Checked = false;

            radioTemp1.Checked = false;
            radioTemp2.Checked = false;
            radioTemp3.Checked = false;
            radioTemp4.Checked = false;
            radioTemp5.Checked = false;

            CountSelect.Value = 1;

            itemNameLabel.Text = "";
            itemPriceLabel.Text = "";

            ingredientPanel.Controls.Clear();
            selectItem.Clear();

        }



        public void ReFreshProduct()
        {
            var productList = Model.GolbalVar.productDictionary;

            tabControl1.Controls.Clear();
            foreach (KeyValuePair<string, List<Model.Product>> item in productList)
            {
                TabPage tpg = new TabPage();
                tpg.Location = new System.Drawing.Point(4, 25);
                tpg.Name = item.Key;
                tpg.Padding = new System.Windows.Forms.Padding(3);
                tpg.Size = new System.Drawing.Size(192, 71);
                tpg.TabIndex = 0;
                tpg.Text = item.Key;
                tpg.UseVisualStyleBackColor = true;
                tpg.SizeChanged += Tpg_SizeChanged;
                tabControl1.Controls.Add(tpg);

                FlowLayoutPanel f = new FlowLayoutPanel();
                f.Size = tpg.Size;
                foreach (Model.Product item2 in item.Value)
                {
                    Button b = new Button();
                    b.Text = item2.Name;
                    b.Tag = item2;
                    // b.Padding = new Padding(10);
                    b.AutoSize = false;
                    b.Size = new Size(120, 45);
                    b.Click += productDetail;
                    f.Controls.Add(b);
                }

                tpg.Controls.Add(f);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckOutForm form = new CheckOutForm(CleanAll);
            int pirce = 0;
            foreach (var item in Model.GolbalVar.purchaseList)
            {
                pirce += item.TotalPrice;
            }
            form.price = pirce;
            form.ShowDialog();
        }


        void CleanAll()
        {
            Model.GolbalVar.purchaseList.Clear();
            defaultSelect();
            panel4.Controls.Clear();
            product1 = new Model.Product();
        }
    }
}
