using Abp.Web.Mvc.Views;

namespace MickeyAbpTest.Web.Views
{
    public abstract class MickeyAbpTestWebViewPageBase : MickeyAbpTestWebViewPageBase<dynamic>
    {

    }

    public abstract class MickeyAbpTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MickeyAbpTestWebViewPageBase()
        {
            LocalizationSourceName = MickeyAbpTestConsts.LocalizationSourceName;
        }
    }
}