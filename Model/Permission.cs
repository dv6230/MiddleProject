namespace MiddleProject.Model
{
    internal class Permission
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int accountId { get; set; }
        public string permitName { get; set; }

        public override string ToString()
        {
            return this.permitName;
        }
    }
}
