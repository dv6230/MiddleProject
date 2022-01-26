using System.Collections.Generic;

namespace MiddleProject.Model
{
    class Product
    {
        private string foodType;
        private string name;
        private int price;
        private int count;
        private int total;
        public List<string> ingredient = new List<string>();
        private List<string> userSelectIngredient = new List<string>();
        private string sweet;
        private string temperature;

        //public string[] sweetLevelAry = { "無糖", "三分", "五分", "七分", "全糖" };
        //public string[] temperatureAry = { "正常", "少冰", "微冰", "去冰", "熱" };

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public int TotalPrice { get => total; set => total = value; }
        public List<string> UserSelectIngredient { get => userSelectIngredient; set => userSelectIngredient = value; }
        public string Sweet { get => sweet; set => sweet = value; }
        public string Temperature { get => temperature; set => temperature = value; }
        public string FoodType { get => foodType; set => foodType = value; }

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public Product()
        {
        }

        public Product(string name, int price, List<string> ingredient) : this(name, price)
        {
            this.ingredient = ingredient;
        }

        public Product setIngredient(List<string> ary)
        {
            this.ingredient = ary;
            return this;
        }

        public override string ToString()
        {
            string str = "";
            str += this.name + "/";
            str += this.price + "/";
            str += this.sweet + "/";
            str += this.temperature + "/";
            str += "[";

            if (userSelectIngredient != null && userSelectIngredient.Count > 0)
            {
                foreach (var item in userSelectIngredient)
                {
                    str += item + " ";
                }
            }

            str += "]";
            return str;
        }
    }
}
