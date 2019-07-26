using Microsoft.EntityFrameworkCore;
using System;

namespace se.interbellum.gpsync.settings
{
    public class Settings
    {
    }
    public class SettingsContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=settings.db");
        }
    }

    public class Setting
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
