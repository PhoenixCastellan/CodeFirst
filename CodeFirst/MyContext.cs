using System.Data.Entity;
using CodeFirst.Entity;

namespace CodeFirst
{
    public class MyContext: DbContext
    {
        public MyContext() : base("name=MyContext") { }

        public virtual DbSet<Company> Company { get; set; }

        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
