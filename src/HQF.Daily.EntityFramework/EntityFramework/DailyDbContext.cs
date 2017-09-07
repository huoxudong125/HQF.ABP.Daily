using System.Data.Common;
using Abp.Zero.EntityFramework;
using HQF.Daily.Authorization.Roles;
using HQF.Daily.Authorization.Users;
using HQF.Daily.MultiTenancy;

namespace HQF.Daily.EntityFramework
{
    public class DailyDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DailyDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DailyDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DailyDbContext since ABP automatically handles it.
         */
        public DailyDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public DailyDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public DailyDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
