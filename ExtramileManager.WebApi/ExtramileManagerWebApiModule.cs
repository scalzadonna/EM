using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Application;
using Abp.WebApi.Startup;

using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using ExtramileManager.Services;
using ExtramileManager.Tasks;

namespace ExtramileManager
{
    public class ExtramileManagerWebApiModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       //typeof(AbpApplicationModule),
                       //typeof(ExtramileManagerApplicationModule),
                       typeof(AbpWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .For<ICustomerAppService>("extramile/customer")
                .Build();

            DynamicApiControllerBuilder
                .For<ITaskAppService>("extramile/task")
                .Build();
            DynamicApiControllerBuilder
                .For<ICotizacionAppService>("extramile/cotizacion")
                .Build();

        }
    }
}
