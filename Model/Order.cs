using System;

namespace MiddleProject.Model
{
    internal class Orders
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int customerId { get; set; }
        public int amount { get; set; }
        public DateTime orderDateTime { get; set; }
        public int employeeId { get; set; }

        public Orders() {
            orderDateTime = DateTime.Now;
        }

        public Orders(int amount)
        {
            this.amount = amount;
            orderDateTime = DateTime.Now;
        }

    }
}