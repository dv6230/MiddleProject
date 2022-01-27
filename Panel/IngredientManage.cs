using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class IngredientManage : UserControl
    {

        List<Model.Ingredients> ingredients = new List<Model.Ingredients>();

        Model.Ingredients item = null;

        public IngredientManage()
        {
            InitializeComponent();
        }

        private void IngredientManage_Load(object sender, EventArgs e)
        {
            List<Model.Ingredients> list = Model.GolbalVar.db.Queryable<Model.Ingredients>().ToList();
            ingredients = list;
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox1.SelectedIndex >= ingredients.Count)
            {
                return;
            }

            item = ingredients[listBox1.SelectedIndex];
            textBox1.Text = item.name;
            textBox2.Text = item.price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("沒有選擇資料");
                return;
            }

            item.name = textBox1.Text;

            try { item.price = int.Parse(textBox2.Text); }
            catch (Exception) { }

            var result = Model.GolbalVar.db.Updateable(item).ExecuteCommand();

            if (result > 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }

            listBox1.Items.Clear();
            List<Model.Ingredients> list = Model.GolbalVar.db.Queryable<Model.Ingredients>().ToList();
            ingredients = list;
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = item.name;
            textBox2.Text = item.price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model.GolbalVar.db.Deleteable<Model.Ingredients>().Where(new Model.Ingredients() { Id = item.Id }).ExecuteCommand();
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            List<Model.Ingredients> list = Model.GolbalVar.db.Queryable<Model.Ingredients>().ToList();
            ingredients = list;
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            listBox1.SelectedIndex = -1; 
        }
    }
}
