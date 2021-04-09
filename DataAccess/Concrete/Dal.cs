using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Dal : DbContext
    {
        private static string connectionString = "server = localhost; database=taxi; uid=admin; pwd=123456";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }
        public DbSet<taxi_info> taxi_info { get; set; }
        public DbSet<location_info> location_info { get; set; }
    }
}
