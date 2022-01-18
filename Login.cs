using System;
using System.Data.SqlClient;
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
            string sql = "SELECT * from accounts WHERE account = @acnt ";
            SqlConnection con = new SqlConnection(DBConnection.DBstr);
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
                    var form2 = new FrontOperate();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();

                }
            }
        }

    }
}
