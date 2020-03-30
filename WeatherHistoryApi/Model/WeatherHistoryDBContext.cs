using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherHistoryApi.Model
{
    public class WeatherHistoryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SMOKU\\MSSQLSERVER01;Database=WeatherHistory;Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherHistory>().HasNoKey();
        }

        public DbSet<WeatherHistory> WeatherHistorys { get; set; }

    }
}
