using Abp.Web.Mvc.Views;

namespace HQF.Daily.Web.Views
{
    public abstract class DailyWebViewPageBase : DailyWebViewPageBase<dynamic>
    {

    }

    public abstract class DailyWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DailyWebViewPageBase()
        {
            LocalizationSourceName = DailyConsts.LocalizationSourceName;
        }
    }
}