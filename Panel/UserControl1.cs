using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class SearchOrderPanel : UserControl
    {
        public SearchOrderPanel()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sizeChange();
        }

        void sizeChange()
        {

            dataGridView1.Location = new Point(25, 65);
            dataGridView1.Size = new Size((int)(this.Width - 25 * 2), (int)((panel3.Height - 65) * 0.9));
        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            string strSQL = "select id as 訂單編號 , customerId as 顧客編號 , amount as 訂單金額 , orderDateTime as 訂單日期 " +
                " from orders Where (orderDateTime >= @StartDate AND orderDateTime <= @EndDate );";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@StartDate", startTimePicker.Value);
            cmd.Parameters.AddWithValue("@EndDate", endTimePicker.Value);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
            }
            else
            {
                Console.WriteLine("no row");
            }
            reader.Close();
            con.Close();
        }
    }
}
