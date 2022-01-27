using System.Data.SqlClient;

namespace MiddleProject
{
    class DBProduceStr
    {
        public static string DBstr = "";

        public void ProduceConnectStr()
        {
            SqlConnectionStringBuilder scrb = new SqlConnectionStringBuilder();
            scrb.DataSource = @".";
            scrb.InitialCatalog = "MidProject";
            scrb.IntegratedSecurity = true;
            DBstr = scrb.ToString();
        }

        public void ProduceConnectStr2()
        {
            DBstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MidProject.mdf;Integrated Security=True";
        }

    }
}
