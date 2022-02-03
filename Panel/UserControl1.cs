using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            dataGridView1.Location = new Point(25,65); 
            dataGridView1.Size = new Size((int)(this.Width - 25 * 2 ), (int)((panel3.Height - 65) * 0.9));
        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBProduceStr.DBstr);
            con.Open();
            string strSQL = "select * from orders Where (orderDateTime >= @StartDate AND orderDateTime <= @EndDate );";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@StartDate", startTimePicker.Value);
            cmd.Parameters.AddWithValue("@EndDate", endTimePicker.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine(cmd.CommandText);
            
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
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
