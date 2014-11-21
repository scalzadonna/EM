using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtramileManager.Cotizaciones
{
    public class Cotizacion : Entity<int>
    {
        public virtual string Titulo { get; set; }
        public virtual Customers.Customer Customer { get; set; }
        public virtual string Tipo {get;set;}
        public virtual string Carga{get;set;}
        public virtual string Contr_M3 {get;set;}
        public virtual string Servicio{get;set;}
        public virtual string Condicion_Flete{get;set;}
        public virtual string Q_Type{get;set;}
        public virtual string Agente{get;set;}
        public virtual string Shipper {get;set;}
        public virtual string Consignee{get;set;}
        public virtual string Incoterm{get;set;}
        public virtual string Aduana{get;set;}
        public virtual string Fc_Comercial{get;set;}
        public virtual float Monto_USD{get;set;}
        public virtual DateTime Fecha_Carga {get;set;}
        public virtual string Origen{get;set;}
        public virtual string POL_AOL{get;set;}
        public virtual string POD_AOD{get;set;}
        public virtual string Destino{get;set;}
        public virtual string Armador{get;set;}
        public virtual string Vss_Vol{get;set;}
        public virtual DateTime ETD { get; set; }
        public virtual DateTime ETA { get; set; }
        public virtual string MBL_MAWB_MCRT { get; set; }
        public virtual string HBL_HAWB_HCRT { get; set; }
        public virtual string Bandera{ get; set; }
        public virtual string CutOff_Doc { get; set; }
        public virtual string CutOff_Fisico { get; set; }
        public virtual string Terminal_Fiscal { get; set; }
        public virtual string Seguro { get; set; }
        public virtual string ATA { get; set; }
        public virtual string Doc_Issue { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual int Booking { get; set; }




    }
}
