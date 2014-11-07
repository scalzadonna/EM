using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;
using ExtramileManager.Customers;

namespace ExtramileManager.EntityFramework
{
    public class ExtramileManagerDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Customer> Customers { get; set; }


        //public virtual IDbSet<Person> People { get; set; } //Sample

        public ExtramileManagerDbContext()
            : base("EMDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...
            modelBuilder.Entity<Customer>().ToTable("Customers");
            //modelBuilder.Entity<Person>().ToTable("TsPeople"); //Sample
        }
    }
}
