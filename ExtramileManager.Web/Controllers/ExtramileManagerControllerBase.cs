using Abp.Web.Mvc.Controllers;

namespace ExtramileManager.Web.Controllers
{
    public abstract class ExtramileManagerControllerBase : AbpController
    {
        protected ExtramileManagerControllerBase()
        {
            LocalizationSourceName = "ExtramileManager";
        }
    }
}