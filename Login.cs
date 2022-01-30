using MiddleProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        private void tBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        }

        void loginCheck()
        {

            var con = GolbalVar.db;

            List<Accounts> list = con.Queryable<Accounts>().Where(it => it.account == tBoxAccount.Text).ToList();

            if (list.Count > 0 && list[0].password.Equals(tBoxPassword.Text))
            {
                List<Permission> pList = con.Queryable<Permission>().Where(it => it.accountId == list[0].Id).ToList();
                foreach (var it in pList)
                {
                    GolbalVar.userPermissionList.Add(it.permitName);
                }
                this.Hide();
                GolbalVar.userId = list[0].Id;

                var form2 = new FrontSide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else { MessageBox.Show("帳號或密碼錯誤"); }

        }

        void checkAccount()
        {
            string sql = "SELECT * from accounts WHERE account = @acnt ";
            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@acnt", tBoxAccount.Text);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                MessageBox.Show("帳號或密碼錯誤");
                return;
            }

            while (reader.Read())
            {
                if (reader["password"].Equals(tBoxPassword.Text))
                {
                    this.Hide();
                    Model.GolbalVar.userId = (int)reader["id"];

                    var form2 = new FrontSide();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
