using MiddleProject.Model;
using System;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void btnInsert_click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Length <= 0 || txtName.Text.Length <= 0 || txtPassword.Text.Length <=0 )
            {
                MessageBox.Show("不可空白");
                return;
            }
            var b = GolbalVar.db.Queryable<Accounts>().Where(item => item.account == txtAccount.Text).ToList();
            if (b.Count > 0 )
            {
                MessageBox.Show("帳號已被使用");
                return;
            }
            Accounts acnt = new Accounts()
            { account = txtAccount.Text, password = txtPassword.Text, name = txtName.Text };
            var result = GolbalVar.db.Insertable(acnt).ExecuteCommand();
            if (result > 0 )
            {
                MessageBox.Show("新增成功");
            }
            cleanAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanAll();
        }

        void cleanAll()
        {
            txtAccount.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
