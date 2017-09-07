﻿using HQF.Daily.EntityFramework;
using EntityFramework.DynamicFilters;

namespace HQF.Daily.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly DailyDbContext _context;

        public InitialHostDbBuilder(DailyDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
