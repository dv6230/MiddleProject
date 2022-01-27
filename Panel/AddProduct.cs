using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class AddProduct : UserControl
    {

        List<Model.Ingredients> selectIngredient = new List<Model.Ingredients>();

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
            Model.Product p  = new Model.Product();
            p.Name = tBoxname.Text;
            p.Price = int.Parse(tBoxPrice.Text);
            int i = Model.GolbalVar.db.Insertable(p).ExecuteReturnIdentity();
            Console.WriteLine(i);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
