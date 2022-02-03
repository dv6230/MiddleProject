using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class CheckOutForm : Form
    {

        int customerId = 0;
        public int price = 0;
        public delegate void ReFreshPanel();
        public ReFreshPanel refreshPanel;

        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            lblPrice.Text = price.ToString();
        }

        void searchCustomer()
        {
            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            string sql = "SELECT * FROM customer WHERE phone = @phone";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@phone", tBoxPhone.Text.ToString());
            var reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                lblCName.Text = reader["name"].ToString();
                customerId = (int)reader["id"];
            }
            reader.Close();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            Model.Orders odr = new Model.Orders();

            odr.customerId = customerId;
            odr.amount = price;
            odr.employeeId = Model.GolbalVar.userId;
            odr.orderDateTime = DateTime.Now;

            var id = Model.GolbalVar.db.Insertable(odr).ExecuteReturnIdentity();

            foreach (var item in Model.GolbalVar.purchaseList)
            {
                Model.OrderDetail detail = new Model.OrderDetail();
                detail.orderId = id;
                detail.price = item.TotalPrice;
                detail.ice = item.Temperature;
                detail.sweet = item.Sweet;
                detail.name = item.Name;
                detail.count = item.Count;
                detail.ingredient = listToString(item.UserSelectIngredient);
                Model.GolbalVar.db.Insertable(detail).ExecuteCommand();
            }

            if (refreshPanel != null) refreshPanel();
            this.Dispose();
        }

        string listToString(List<Model.Ingredients> list)
        {
            string s = "";

            foreach (var item in list)
            {
                s += item.name + ",";
                Console.WriteLine(item.name);
            }
            if (s.Length > 0) s = s.Substring(0, s.Length - 1);
            return s;
        }

    }
}
