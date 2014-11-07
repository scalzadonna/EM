using Abp.Web.Mvc.Views;

namespace ExtramileManager.Web.Views
{
    public abstract class ExtramileManagerWebViewPageBase : ExtramileManagerWebViewPageBase<dynamic>
    {

    }

    public abstract class ExtramileManagerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ExtramileManagerWebViewPageBase()
        {
            LocalizationSourceName = "ExtramileManager";
        }
    }
}