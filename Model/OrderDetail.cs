namespace MiddleProject.Model
{
    internal class OrderDetail
    {

        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int orderId { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public string note { get; set; }
        public string ingredient { get; set; }
        public string ice { get; set; }
        public string sweet { get; set; }

    }
}
