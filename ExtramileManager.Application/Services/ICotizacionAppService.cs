using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using ExtramileManager.Cotizaciones;

namespace ExtramileManager.Services
{
    public interface ICotizacionAppService : IApplicationService
    {

        List<Cotizacion> GetCotizaciones();

        Cotizacion GetCotizacion(Cotizacion input);

        bool SaveCotizacion(Cotizacion input);
        bool UpdateCotizacion(Cotizacion input);


    }
   
}
