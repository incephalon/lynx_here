using Abp.Web.Mvc.Controllers;

namespace AngularMVC.Web.Controllers
{
    public abstract class AngularMVCControllerBase : AbpController
    {
        protected AngularMVCControllerBase()
        {
            LocalizationSourceName = "AngularMVC";
        }
    }
}