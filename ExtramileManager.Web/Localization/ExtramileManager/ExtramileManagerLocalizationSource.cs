using System.Web;
using Abp.Localization.Sources.Xml;

namespace ExtramileManager.Web.Localization.ExtramileManager
{
    public class ExtramileManagerLocalizationSource : XmlLocalizationSource
    {
        public ExtramileManagerLocalizationSource()
            : base("ExtramileManager", HttpContext.Current.Server.MapPath("/Localization/ExtramileManager"))
        {
        }
    }
}