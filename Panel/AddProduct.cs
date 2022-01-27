using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class AddProduct : UserControl
    {

        List<Model.Ingredients> selectIngredient = new List<Model.Ingredients>();
        List<Model.ProductType> typeList = new List<Model.ProductType>();   
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            List<Model.Ingredients> Ingredients = new List<Model.Ingredients>();

            Ingredients = Model.GolbalVar.db.Queryable<Model.Ingredients>().ToList();

            foreach (var item in Ingredients)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.name;
                // cb.BackColor = Color.LightBlue;
                cb.AutoSize = true;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.Padding = new Padding(4);
                cb.Tag = item;
                cb.CheckedChanged += Cb_CheckedChanged;
                IngredientPanel1.Controls.Add(cb);
            }

            typeList = Model.GolbalVar.db.Queryable<Model.ProductType>().ToList();
            comboBox1.Items.Clear();
            foreach (var item in typeList)
            {
                comboBox1.Items.Add(item.Name);
            }

        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Model.Ingredients ig = (Model.Ingredients)cb.Tag;
            if (cb.Checked)
            {
                selectIngredient.Add(ig);
            }
            else
            {
                selectIngredient.Remove(ig);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1 )
            {
                MessageBox.Show("請選擇類別");
                return;
            }
            Model.Products p  = new Model.Products();
            p.Name = tBoxname.Text;
            try
            {
                p.Price = int.Parse(tBoxPrice.Text);
            }
            catch (Exception)
            {
                p.Price = 0 ;
            }
            
            p.ProductTypeId = typeList[comboBox1.SelectedIndex].Id;
            int i = Model.GolbalVar.db.Insertable(p).ExecuteReturnIdentity();
            foreach (var item in selectIngredient)
            {
                var productIngredient = new Model.ProductIngredient();
                productIngredient.productId = i ;
                productIngredient.ingredientId = item.Id;
                Model.GolbalVar.db.Insertable(productIngredient).ExecuteCommand();
            }
            MessageBox.Show("新增完成");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
