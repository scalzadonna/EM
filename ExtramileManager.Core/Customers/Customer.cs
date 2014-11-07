using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Customers
{
    public class Customer : Entity<int>
    {
        public virtual CustomerType Tipo { get; set;}
        public virtual string Nombre { get; set; }

        public virtual string Direccion { get; set; }

        public virtual string Provincia { get; set; }

        public virtual string Pais { get; set; }

        public virtual string Cuit { get; set; }

        public virtual string IBrutos { get; set; }

        public virtual CustomerStatus Estado { get; set; }

        

    }
}
