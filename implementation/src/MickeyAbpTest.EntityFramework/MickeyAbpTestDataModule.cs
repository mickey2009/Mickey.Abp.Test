using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MickeyAbpTest.EntityFramework;

namespace MickeyAbpTest
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MickeyAbpTestCoreModule))]
    public class MickeyAbpTestDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MickeyAbpTestDbContext>(null);
        }
    }
}
