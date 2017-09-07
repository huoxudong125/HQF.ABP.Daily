using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using HQF.Daily.EntityFramework;

namespace HQF.Daily.Migrator
{
    [DependsOn(typeof(DailyDataModule))]
    public class DailyMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DailyDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}