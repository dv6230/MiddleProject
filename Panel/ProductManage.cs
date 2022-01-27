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

        List<Model.Products> products;

        private void ProductManage_Load(object sender, EventArgs e)
        {
            products = Model.GolbalVar.db.Queryable<Model.Products>().ToList();

            foreach (var item in products)
            {
                listBox1.Items.Add(item.Name);
            }

        }
    }
}
