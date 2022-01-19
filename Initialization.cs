using System.Data.SqlClient;

namespace MiddleProject
{
    class Initialization
    {

        public Initialization()
        {
            getFood();
            getUserAuth();
        }

        void getFood()
        {
            var productList = Model.GolbalVar.productList;
            string sql = "SELECT * FROM products";
            SqlConnection con = new SqlConnection(DBConnection.DBstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string foodType = reader["foodType"].ToString();

                var p = new Model.Product();
                p.Name = reader["name"].ToString();
                p.Price = (int) reader["price"];
                p.FoodType = foodType;

                productList[foodType].Add(p);
            }
            reader.Close();
            con.Close();
        }

        void getUserAuth()
        {
            var productList = Model.GolbalVar.userPermissionList;
            string sql = "SELECT * FROM userPermission WHERE id = @Id";
            SqlConnection con = new SqlConnection(DBConnection.DBstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id",Model.GolbalVar.userId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                productList.Add(reader["name"].ToString());
            }
            reader.Close();
            con.Close();
        }



    }
}
