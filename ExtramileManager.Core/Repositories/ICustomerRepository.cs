using Abp.Domain.Repositories;
using ExtramileManager.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
