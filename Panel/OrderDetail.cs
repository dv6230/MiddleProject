using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class OrderDetail : UserControl
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderId = 0;
            try
            {
                orderId = int.Parse(tBoxOrderId.Text);
            }
            catch (Exception)
            {

                throw;
            }

            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            string sql = "SELECT name as 產品名稱 , count as 數量 , price as 金額　," +
                " ingredient　as 配料 , ice　as 冰塊 , sweet　as 甜度  FROM orderDetail WHERE orderId = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", orderId);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            con.Close();
            reader.Close();
            var ord = Model.GolbalVar.db.Queryable<Model.Orders>().Where(p => p.Id == orderId).ToList();
            lblOrderDate.Text = ord[0].orderDateTime.ToString();
            lblAmount.Text = ord[0].amount.ToString();
        }
    }
}
