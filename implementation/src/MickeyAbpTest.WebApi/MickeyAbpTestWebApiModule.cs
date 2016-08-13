using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace MickeyAbpTest
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MickeyAbpTestApplicationModule))]
    public class MickeyAbpTestWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MickeyAbpTestApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
