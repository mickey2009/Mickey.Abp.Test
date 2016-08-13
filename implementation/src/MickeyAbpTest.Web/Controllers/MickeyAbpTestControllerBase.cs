using Abp.Web.Mvc.Controllers;

namespace MickeyAbpTest.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MickeyAbpTestControllerBase : AbpController
    {
        protected MickeyAbpTestControllerBase()
        {
            LocalizationSourceName = MickeyAbpTestConsts.LocalizationSourceName;
        }
    }
}