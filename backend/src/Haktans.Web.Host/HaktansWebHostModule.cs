using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Haktans.EntityFrameworkCore;

namespace Haktans.Web.Host
{
    [DependsOn(typeof(HaktansApplicationModule), typeof(HaktansEntityFrameworkCoreModule), typeof(AbpAspNetCoreModule))]
    public class HaktansWebHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Expose all AppServices as dynamic API controllers
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(HaktansApplicationModule).GetAssembly(),
                    moduleName: "app",
                    useConventionalHttpVerbs: true
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HaktansWebHostModule).GetAssembly());
        }
    }
}
