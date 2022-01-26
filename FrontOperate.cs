using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class FrontSide : Form
    {

        int padwidth = 22;
        List<Control> controls = new List<Control>();

        Panel.AddCustomer addCustomer = new Panel.AddCustomer();

        Color sideDefaultColor = Color.FromArgb(64, 64, 64);
        Color activeColor = Color.Gray;

        public FrontSide()
        {
            InitializeComponent();
        }

        private void FrontOperate_Load(object sender, EventArgs e)
        {
            slideOrderBtn.BackColor = activeColor;

            var productList = Model.GolbalVar.productList;

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
                    f.Controls.Add(b);
                }

                tpg.Controls.Add(f);
            }

            panel4.Size = new Size(new Panel.UserPurchaseItem().Width + padwidth, this.Height);
            panel3.Size = new Size((int)((this.Width - panel1.Width - panel4.Width)), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);

            for (int i = 0; i < 10; i++)
            {
                var p = new Panel.UserPurchaseItem();
                p.numberLabel.Text = (i + 1).ToString();
                //if (i % 2 == 0 && i % 3 > 0) { p.BackColor = Color.FromArgb(179, 204, 255); }
                //else if (i % 3 == 0) { p.BackColor = Color.FromArgb(179, 236, 255); }
                p.lblNote.Text = (i + new Random().Next(10, 1000)).GetHashCode().ToString();
                panel4.Controls.Add(p);
            }

            controls.Add(panel3);
            controls.Add(panel4);
            controls.Add(tabControl1);

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
            //manage.Closed += (s, args) => this.Close();
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
    }
}
