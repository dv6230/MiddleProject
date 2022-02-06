using System.Collections.Generic;

namespace MiddleProject.Model
{
    internal class Products
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Note { get; set; }
        public int ProductTypeId { get; set; }

        public List<Ingredients> IngredientList = new List<Ingredients>();
        public List<ProductIngredient> ProductIngredientList = new List<ProductIngredient>();
    }
}
