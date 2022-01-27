using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleProject.Model
{
    internal class ProductIngredient
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int productId { get; set; }
        public int ingredientId { get; set; }
    }
}
