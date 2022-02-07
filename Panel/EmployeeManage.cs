using MiddleProject.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class EmployeeManage : UserControl
    {

        List<Accounts> accounts = new List<Accounts>();

        Accounts selectItem = new Accounts();

        public EmployeeManage()
        {
            InitializeComponent();
        }

        void loadListBox()
        {
            listBox1.Items.Clear(); 
            accounts = GolbalVar.db.Queryable<Accounts>().ToList();
            foreach (var item in accounts)
            {
                listBox1.Items.Add(item);
            }
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            loadListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ls = (ListBox)sender;
            selectItem = (Accounts)ls.SelectedItem;
            txtAccount.Text = selectItem.account;
            txtPassword.Text = selectItem.password;
            txtName.Text = selectItem.name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Length <= 0 || txtName.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("不可空白");
                return;
            }
            var b = GolbalVar.db.Queryable<Accounts>().Where(item => item.account == txtAccount.Text)
                .Where(item=> item.Id != selectItem.Id).ToList();
            if (b.Count > 0)
            {
                MessageBox.Show("帳號已被使用");
                return;
            }
            Accounts act = (Accounts)listBox1.SelectedItem;
            act.account = txtAccount.Text;
            act.password = txtPassword.Text;
            act.name = txtName.Text;
            bool result = GolbalVar.db.Updateable(act).ExecuteCommandHasChange();
            int selectId = listBox1.SelectedIndex; 
            loadListBox();
            listBox1.SelectedIndex = selectId;
            if (result)
            {
                MessageBox.Show("更新成功");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Accounts act = (Accounts)listBox1.SelectedItem;
            GolbalVar.db.Deleteable<Model.Accounts>().Where(new Accounts() { Id = act.Id }).ExecuteCommand();
            loadListBox();
            act = new Accounts();
            txtAccount.Text = act.account;  
            txtName.Text = act.name;
            txtPassword.Text = act.password;
        }
    }
}
