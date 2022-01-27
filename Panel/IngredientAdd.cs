using System;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class IngredientAdd : UserControl
    {
        public IngredientAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBoxIgredientName.Text.Length <= 0 || tBoxIgredientPrice.Text.Length <= 0)
            {
                MessageBox.Show("請輸入名稱價錢");
                return;
            }
            var m = new Model.Ingredients();
            m.name = tBoxIgredientName.Text;
            try
            {
                m.price = int.Parse(tBoxIgredientPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("數值輸入錯誤");
                return;
            }

            int a = Model.GolbalVar.db.Insertable(m).ExecuteCommand();
            if (a > 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }
            tBoxIgredientName.Text = "";
            tBoxIgredientPrice.Text = "0";

        }
    }
}
