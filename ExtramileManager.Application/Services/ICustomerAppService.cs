using Abp.Application.Services;
using ExtramileManager.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Services
{
    public interface ICustomerAppService : IApplicationService
    {
        
        List<Customer> GetCustomers(Customer input);
        Customer GetCustomer(Customer input);
        
        bool SaveCustomer(Customer input);
        bool UpdateCustomer(Customer input);
        
        
    }
}
