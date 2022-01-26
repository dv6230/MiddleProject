using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleProject.Model
{
    internal class Accounts
    {
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public string name  { get; set; }

        public override string ToString()
        {
            string s = "";
            s += Id + " / ";
            s += account + " / ";
            s += password + " / ";
            s += name;
            return s;
        }
    }
}
