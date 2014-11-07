using ExtramileManager.Customers;
using ExtramileManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.EntityFramework.Repositories
{
    public class CustomerRepository : ExtramileManagerRepositoryBase<Customer>, ICustomerRepository
    {
    }
}
