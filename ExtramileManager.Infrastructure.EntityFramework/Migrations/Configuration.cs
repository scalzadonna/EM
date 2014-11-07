namespace ExtramileManager.Migrations
{
    using ExtramileManager.Customers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExtramileManager.EntityFramework.ExtramileManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExtramileManager.EntityFramework.ExtramileManagerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
//            context.Customers.AddOrUpdate(
//                    c => c.Nombre,
//                    new Customer{Nombre = "DAYCO", Tipo = CustomerType.Cliente, Cuit="14-24533653-7", Estado = CustomerStatus.Activo },
//                    new Customer{Nombre = "DUPONT", Tipo = CustomerType.Proveedor, Cuit = "2-22099433-2",Estado = CustomerStatus.Activo}
//,                );
            //
        }
    }
}
