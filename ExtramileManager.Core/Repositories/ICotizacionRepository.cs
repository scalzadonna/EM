using Abp.Domain.Repositories;
using ExtramileManager.Cotizaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Repositories
{
    public interface ICotizacionRepository : IRepository<Cotizacion>
    {
    }
}
