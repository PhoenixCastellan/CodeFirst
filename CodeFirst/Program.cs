using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                var company = new Company()
                {
                    Name = "北琳网络有限公司",
                    Descript = "It's a good Company."
                };
                ctx.Company.Add(company);
                ctx.SaveChanges();
            }
        }
    }
}
