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

                var product = new Model.Product();
                product.Id = (int)reader["id"];
                product.Name = reader["name"].ToString();
                product.Price = (int)reader["price"];
                product.FoodType = productType;

                List<Model.Ingredients> ingredients = Model.GolbalVar.db.Queryable<Model.Ingredients>()
                    .Where(i => i.Id == (int)reader["id"]).ToList();

                product.ingredient = new List<Model.Ingredients>(ingredients);

                if (productDict.ContainsKey(productType))
                {
                    productDict[productType].Add(product);
                }
                else
                {
                    var list = new List<Model.Product>();
                    list.Add(product);
                    productDict.Add(productType, list);
                }
            }
            reader.Close();
            con.Close();
        }
    }
}
