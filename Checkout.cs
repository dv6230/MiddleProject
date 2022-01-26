using System.Collections.Generic;

namespace MiddleProject
{
    internal class Checkout
    {
        public Checkout()
        {

            Model.Orders order = new Model.Orders(70);

            int orderId =  Model.GolbalVar.db.Insertable(order).ExecuteReturnIdentity();

            List<Model.OrderDetail> orderDetailList = new List<Model.OrderDetail>();

            foreach (var item in Model.GolbalVar.purchaseList)
            {
                var product = new Model.OrderDetail();

                product.name = item.Name;   
                product.price = item.Price;
                product.count = item.Count;
                product.note = ingredientTostr(item.UserSelectIngredient);
                orderDetailList.Add(product);
            }

            foreach (var item in orderDetailList)
            {
                item.orderId = orderId;
                Model.GolbalVar.db.Insertable(item).ExecuteCommand();
            }

            System.Windows.Forms.MessageBox.Show("結帳完成");

        }

        string ingredientTostr(List<Model.Ingredients> list)
        {
            string s = "";
            foreach (var item in list)
            {
                s += item.name + ", ";
            }
            if (s.Length > 2) s = s.Substring(0, s.Length - 2);
            return s;
        }

    }
}