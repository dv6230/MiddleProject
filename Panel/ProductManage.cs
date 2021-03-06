using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        List<Model.ProductType> typeList = new List<Model.ProductType>();

        List<CheckBox> checkBoxList = new List<CheckBox>();

        bool isEditing = false;

        private void ProductManage_Load(object sender, EventArgs e)
        {
            loadpage();
        }

        void loadpage()
        {

            productList.Clear();
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            checkBoxList.Clear();

            productList = Model.GolbalVar.db.Queryable<Model.Products>().ToList();

            foreach (var item in productList)
            {
                listBox1.Items.Add(item.Name);
            }

            typeList = Model.GolbalVar.db.Queryable<Model.ProductType>().ToList();
            foreach (var item in typeList)
            {
                comboBox1.Items.Add(item.Name);
            }
            comboBox1.SelectedIndex = -1;

            // flowLayoutPanel1 
            flowLayoutPanel1.Controls.Clear();
            var Ingredients = Model.GolbalVar.db.Queryable<Model.Ingredients>().ToList();
            foreach (var item in Ingredients)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.name;
                cb.AutoSize = true;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.Padding = new Padding(4);
                cb.Tag = item;
                cb.CheckedChanged += Cb_CheckedChanged;
                flowLayoutPanel1.Controls.Add(cb);
                checkBoxList.Add(cb);
            }

        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Model.Ingredients ig = (Model.Ingredients)cb.Tag;
            if (cb.Checked && isEditing == false)
            {
                product.ProductIngredientList.Add(
                    new Model.ProductIngredient()
                    { ingredientId = ig.Id, productId = this.product.Id }
                );
            }
            else if (isEditing == false)
            {

                int id = 0;
                foreach (var item in product.ProductIngredientList)
                {
                    if (item.ingredientId == ig.Id)
                    {
                        break;
                    }
                    else
                    {
                        id++;
                    }
                }
                product.ProductIngredientList.RemoveAt(id);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.isEditing = true;

            if (listBox1.SelectedIndex == -1 || listBox1.SelectedIndex >= productList.Count)
            {
                return;
            }

            tBoxName.Text = productList[listBox1.SelectedIndex].Name;
            tBoxPrice.Text = productList[listBox1.SelectedIndex].Price.ToString();
            product = productList[listBox1.SelectedIndex];
            product.ProductIngredientList = Model.GolbalVar.db.Queryable<Model.ProductIngredient>().Where((i) => i.productId == product.Id).ToList();

            var result = Enumerable.Range(0, typeList.Count)
               .Where(i => typeList[i].Id == product.ProductTypeId)
               .ToList();


            foreach (var item2 in checkBoxList) item2.Checked = false;


            foreach (var item in product.ProductIngredientList.ToArray())
            {
                foreach (var item2 in checkBoxList.ToArray())
                {
                    var a = (Model.Ingredients)item2.Tag;
                    if (a.Id == item.ingredientId)
                    {
                        item2.Checked = true;
                    }
                }
            }

            if (result.Count > 0)
            {
                comboBox1.SelectedIndex = result[0];
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }

            this.isEditing = false;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadpage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (product.Id == null || product.Id == 0)
            {
                return;
            }

            product.Name = tBoxName.Text;
            product.Price = int.Parse(tBoxPrice.Text.ToString());
            product.ProductTypeId = typeList[comboBox1.SelectedIndex].Id;
            Model.GolbalVar.db.Updateable(this.product).ExecuteCommand();
            int index = listBox1.SelectedIndex;

            Model.GolbalVar.db.Deleteable<Model.ProductIngredient>().Where(it => it.productId == product.Id).ExecuteCommand();
            
            foreach (var item in product.ProductIngredientList)
            {
                Model.GolbalVar.db.Insertable(item).ExecuteCommand();                
            }

            loadpage();
            listBox1.SelectedIndex = index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model.GolbalVar.db.Deleteable<Model.ProductIngredient>().Where(new Model.ProductIngredient() { productId = product.Id }).ExecuteCommand();
            Model.GolbalVar.db.Deleteable<Model.Products>().Where(new Model.Products() { Id = product.Id }).ExecuteCommand();
            loadpage();
            listBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            tBoxName.Text = "";
            tBoxPrice.Text = "";
            product = new Model.Products();
        }
    }
}
