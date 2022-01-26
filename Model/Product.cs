using System.Collections.Generic;

namespace MiddleProject.Model
{
    class Product
    {
        public int Id { get; set; } 
        private string foodType;
        private string name;
        private int price;
        private int count;
        private int total;
        public List<Model.Ingredients> ingredient = new List<Model.Ingredients>();
        private List<Model.Ingredients> userSelectIngredient = new List<Model.Ingredients>();
        private string sweet;
        private string temperature;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public int TotalPrice { get => total; set => total = value; }
        public List<Model.Ingredients> UserSelectIngredient { get => userSelectIngredient; set => userSelectIngredient = value; }
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

        public Product setIngredient(List<Model.Ingredients> ary)
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
