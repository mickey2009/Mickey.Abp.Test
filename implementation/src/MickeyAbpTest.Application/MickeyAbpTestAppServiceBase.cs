using Abp.Application.Services;

namespace MickeyAbpTest
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MickeyAbpTestAppServiceBase : ApplicationService
    {
        protected MickeyAbpTestAppServiceBase()
        {
            LocalizationSourceName = MickeyAbpTestConsts.LocalizationSourceName;
        }
    }
}