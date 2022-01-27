using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class ProductTypePanel : UserControl
    {
        public ProductTypePanel()
        {
            InitializeComponent();
        }

        List<Model.ProductType> typeList = new List<Model.ProductType>();

        private void ProductType_Load(object sender, EventArgs e)
        {
            typeList = Model.GolbalVar.db.Queryable<Model.ProductType>().ToList();
            listBox1.Items.Clear();
            foreach (var item in typeList)
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= -1)
            {
                return;
            }
            textBox2.Text = typeList[listBox1.SelectedIndex].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 0)
            {
                return;
            }
            int id = typeList[listBox1.SelectedIndex].Id;
            Model.GolbalVar.db.Deleteable<Model.ProductType>().Where(new Model.ProductType() { Id = id }).ExecuteCommand();

            typeList = Model.GolbalVar.db.Queryable<Model.ProductType>().ToList();
            listBox1.Items.Clear();
            foreach (var item in typeList)
            {
                listBox1.Items.Add(item.Name);
            }
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;

            var a = new Model.ProductType();
            a.Name = textBox1.Text;
            Model.GolbalVar.db.Insertable(a).ExecuteReturnIdentity();
            textBox1.Text = "";
            typeList = Model.GolbalVar.db.Queryable<Model.ProductType>().ToList();
            listBox1.Items.Clear();
            foreach (var item in typeList)
            {
                listBox1.Items.Add(item.Name);
            }
        }
    }
}
