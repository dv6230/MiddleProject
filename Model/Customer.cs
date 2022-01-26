using System;

namespace MiddleProject.Model
{
    internal class Customer
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int point { get; set; }
        public int gender { get; set; }
        public DateTime createDate { get; set; }
        public DateTime birth { get; set; }

        public Customer() { }

        public Customer(string name, string phone, string email, string address, int gender, DateTime birth)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.phone = phone ?? throw new ArgumentNullException(nameof(phone));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.gender = gender;
            this.birth = birth;
            this.createDate = DateTime.Now;
        }




    }
}
