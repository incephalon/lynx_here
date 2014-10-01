using System.Web;
using Abp.Localization.Sources.Xml;

namespace AngularMVC.Web.Localization.AngularMVC
{
    public class AngularMVCLocalizationSource : XmlLocalizationSource
    {
        public AngularMVCLocalizationSource()
            : base("AngularMVC", HttpContext.Current.Server.MapPath("/Localization/AngularMVC"))
        {
        }
    }
}