using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
