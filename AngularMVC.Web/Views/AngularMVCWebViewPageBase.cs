using Abp.Web.Mvc.Views;

namespace AngularMVC.Web.Views
{
    public abstract class AngularMVCWebViewPageBase : AngularMVCWebViewPageBase<dynamic>
    {

    }

    public abstract class AngularMVCWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularMVCWebViewPageBase()
        {
            LocalizationSourceName = "AngularMVC";
        }
    }
}