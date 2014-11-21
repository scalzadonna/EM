using Abp.Application.Services;
using Abp.Domain.Repositories;
using ExtramileManager.Cotizaciones;
using ExtramileManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Services
{

    public class CotizacionAppService : ApplicationService, ICotizacionAppService
    {
        private readonly IRepository<Cotizacion> _cotizacionRepository;


        //ABP provides that we can directly inject IRepository<Customer> (without creating any repository class)
        public CotizacionAppService(ICotizacionRepository cotizacionRepository)
        {
            _cotizacionRepository = cotizacionRepository;
        }

        public List<Cotizacion> GetCotizaciones()
        {
            var results = _cotizacionRepository.GetAllList();

            return results;
        }
       

        public bool SaveCotizacion(Cotizacion input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            //Logger.Info("Creating a new customer: " + input.Nombre);
            
            //Saving entity with standard Insert method of repositories.
            _cotizacionRepository.Insert(input);
            return true;
        }

        public bool UpdateCotizacion(Cotizacion input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            //Logger.Info("Creating a new customer: " + input.Nombre);

            //Saving entity with standard Insert method of repositories.
            _cotizacionRepository.Update(input);
            return true;
        }

        public Cotizacion GetCotizacion(Cotizacion input)
        {
            return _cotizacionRepository.Get(input.Id);
        }

        public String hello()
        {
            return "helloWorld";
        }
    }
}
