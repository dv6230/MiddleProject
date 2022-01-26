using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiddleProject
{
    class Initialization
    {

        public Initialization()
        {
            getFood();
        }

        void getFood()
        {
            var productDict = Model.GolbalVar.productDictionary;
            string sql = "SELECT * FROM products";
            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                SqlConnection cn = new SqlConnection(DBProduceStr.DBstr);
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

                if (productDict.ContainsKey(productType))
                {
                    productDict[productType].Add(p);
                }
                else
                {
                    var list = new List<Model.Product>();
                    list.Add(p);
                    productDict.Add(productType, list);
                }
            }
            reader.Close();
            con.Close();
        }
    }
}
