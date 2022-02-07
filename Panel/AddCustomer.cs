using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class AddCustomer : UserControl
    {

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;

            if (tBoxName.Text.Length <= 0 && tBoxPhone.Text.Length <= 0)
            {
                MessageBox.Show("姓名電話不可為空");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("性別為空");
                return;
            }

            var customer = new Model.Customer()
            {
                name = tBoxName.Text,
                address = tBoxAddress.Text,
                phone = tBoxPhone.Text,
                gender = radioButton1.Checked ? 1 : 0,
                email = tBoxEmail.Text,
                birth = tpBirth.Value
            };
           
            var id = Model.GolbalVar.db.Insertable(customer).ExecuteReturnIdentity();
            cleanInput();
            MessageBox.Show($"新增成功 編號為:{id}");

            btnAddCustomer.Enabled = true;
        }

        void cleanInput()
        {
            this.tBoxAddress.Text = "";
            this.tBoxEmail.Text = "";
            this.tBoxName.Text = "";
            this.tBoxPhone.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            this.tpBirth.Value = DateTime.Now;
        }

        private void btnClearTxtBox_Click(object sender, EventArgs e)
        {
            cleanInput();
        }

        private void tBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tBoxPhone_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void tBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (tBoxPhone.Text.Length == 0)
            {
                return;

            }
            var db = Model.GolbalVar.db;

            List<Model.Customer> list = db.Queryable<Model.Customer>()
                .Where(it => it.phone == tBoxPhone.Text).ToList();

            if (list.Count > 0) showIsUsedLabel.Visible = true;
            else showIsUsedLabel.Visible = false;

        }
    }
}
