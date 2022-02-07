using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class AccountPermission : UserControl
    {
        public AccountPermission()
        {
            InitializeComponent();
        }

        int accountId = 0;

        private void AccountPermission_Load(object sender, EventArgs e)
        {
            var accounts = Model.GolbalVar.db.Queryable<Model.Accounts>().ToList();
            comboBox1.Items.Clear();
            foreach (var account in accounts)
            {
                comboBox1.Items.Add(account);
            }
            listBoxReload();
        }

        void listBoxReload()
        {
            checkedListBox1.Items.Clear();
            foreach (var item in Model.GolbalVar.permissionList)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇用戶");
                return;
            }

            Model.GolbalVar.db.Deleteable<Model.Permission>().Where(it => it.accountId == accountId).ExecuteCommand();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                Model.Permission p = new Model.Permission();
                p.accountId = accountId;
                p.permitName = checkedListBox1.CheckedItems[i].ToString();
                Model.GolbalVar.db.Insertable(p).ExecuteCommand();
            }
            MessageBox.Show("更新成功");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }
            this.accountId = ((Model.Accounts)comboBox1.SelectedItem).Id;
            listBoxReload();

            Model.Accounts acnt = (Model.Accounts)comboBox1.SelectedItem;
            var permissionList = Model.GolbalVar.db.Queryable<Model.Permission>().Where(item => item.accountId == acnt.Id).ToList();
            foreach (var permission in permissionList)
            {                
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.Items[i].ToString().Equals(permission.permitName))
                    {                        
                        checkedListBox1.SetItemChecked(i, true);
                        break;
                    }
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
