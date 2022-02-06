using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class ProductManage : UserControl
    {
        public ProductManage()
        {
            InitializeComponent();
        }

        List<Model.Products> productList = new List<Model.Products>();

        Model.Products product = new Model.Products();


        private void ProductManage_Load(object sender, EventArgs e)
        {
            loadpage(); 
        }

        void loadpage()
        {

            productList.Clear();
            listBox1.Items.Clear();

            productList = Model.GolbalVar.db.Queryable<Model.Products>().ToList();

            foreach (var item in productList)
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox1.SelectedIndex >= productList.Count)
            {
                return;
            }

            tBoxName.Text = productList[listBox1.SelectedIndex].Name;
            tBoxPrice.Text = productList[listBox1.SelectedIndex].Price.ToString();
            product = productList[listBox1.SelectedIndex];

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            product.Name = tBoxName.Text;
            product.Price = int.Parse(tBoxPrice.Text.ToString());
            Model.GolbalVar.db.Updateable(this.product).ExecuteCommand();
            int index = listBox1.SelectedIndex; 
            loadpage();
            listBox1.SelectedIndex = index; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadpage();
        }
    }
}
