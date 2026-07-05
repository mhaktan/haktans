using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Haktans
{
    [DependsOn(typeof(HaktansCoreModule), typeof(AbpAutoMapperModule))]
    public class HaktansApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddMaps(typeof(HaktansApplicationModule).GetAssembly());
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HaktansApplicationModule).GetAssembly());
        }
    }
}
