using System.Data.SqlClient;

namespace MiddleProject
{
    class DBConnection
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

        

    }
}
