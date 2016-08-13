using System.Reflection;
using Abp.Modules;

namespace MickeyAbpTest
{
    public class MickeyAbpTestCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
