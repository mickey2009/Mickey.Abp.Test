using System.Reflection;
using Abp.Modules;

namespace MickeyAbpTest
{
    [DependsOn(typeof(MickeyAbpTestCoreModule))]
    public class MickeyAbpTestApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
