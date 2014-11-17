using Abp.Application.Services;
using Abp.Domain.Repositories;
using ExtramileManager.Customers;
using ExtramileManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Services
{
    public class CustomerAppService : ApplicationService, ICustomerAppService
    {
        private readonly IRepository<Customer> _customerRepository;

        
        //ABP provides that we can directly inject IRepository<Customer> (without creating any repository class)
        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetProviders(Customer input)
        {
            var results = _customerRepository.GetAllList().FindAll(x => x.Tipo.Equals(CustomerType.Proveedor));
            
            if (input != null && input.Estado > 0)
                results = results.FindAll(x => x.Estado.Equals(input.Estado));
            return results;
        }
        public List<Customer> GetCustomers(Customer input)
        {
            var results = _customerRepository.GetAllList().FindAll(x => x.Tipo.Equals(CustomerType.Cliente));
            
            if (input != null && input.Estado > 0)
                results = results.FindAll(x => x.Estado.Equals(input.Estado));
            return results;
        }

        public bool SaveCustomer(Customer input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            //Logger.Info("Creating a new customer: " + input.Nombre);
            input.Estado = CustomerStatus.Activo;
            //Saving entity with standard Insert method of repositories.
            _customerRepository.Insert(input);
            return true;
        }

        public bool UpdateCustomer(Customer input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            //Logger.Info("Creating a new customer: " + input.Nombre);

            //Saving entity with standard Insert method of repositories.
            _customerRepository.Update(input);
            return true;
        }

        public Customer GetCustomer(Customer input)
        {
            return _customerRepository.Get(input.Id);
        }

        public String hello()
        {
            return "helloWorld";
        }
    }
}
