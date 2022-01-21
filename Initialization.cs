using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiddleProject
{
    class Initialization
    {

        public Initialization()
        {
            getFood();
            //getUserAuth();
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

                SqlConnection cn = new SqlConnection(DBConnection.DBstr);
                cn.Open();
                SqlCommand cm = new SqlCommand($"SELECT * FROM productType WHERE id = {(int)reader["productTypeId"]}", cn);
                SqlDataReader rd = cm.ExecuteReader();
                string productType = "其他";
                while (rd.Read())
                {
                    productType = rd["name"] != null ? rd["name"].ToString() : "其他";
                }

                rd.Close();
                cn.Close();

                var p = new Model.Product();
                p.Name = reader["name"].ToString();
                p.Price = (int)reader["price"];
                p.FoodType = productType;

                if (productList.ContainsKey(productType))
                {
                    productList[productType].Add(p);
                }
                else
                {
                    var list = new List<Model.Product>();
                    list.Add(p);
                    productList.Add(productType, list);
                }


            }
            reader.Close();
            con.Close();
        }

        void getUserAuth()
        {
            var userPermission = Model.GolbalVar.userPermissionList;
            string sql = "SELECT * FROM userPermission WHERE id = @Id";
            SqlConnection con = new SqlConnection(DBConnection.DBstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", Model.GolbalVar.userId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userPermission.Add(reader["name"].ToString());
            }
            reader.Close();
            con.Close();
        }



    }
}
