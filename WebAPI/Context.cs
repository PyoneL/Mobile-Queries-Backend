using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;

namespace WebAPI
{
    public class taxi_info
    {
        [Key]
        public int ID { get; set; }
        public DateTime PUDatetime { get; set; }
        public DateTime DODatetime { get; set; }
        public int PULocationID { get; set; }
        public int DOLocationID { get; set; }
        public int passenger_count { get; set; }
        public float trip_distance { get; set; }
        public float total_amount { get; set; }

    }
    public class location_info
    {
        [Key]
        public int LocationID { get; set; }
        public string Borough { get; set; }
        public string Zone { get; set; }
    }
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; database=taxi; uid=admin; pwd=123456");    
        }
        
        public DbSet<taxi_info> taxi_info { get; set; }
       // public DbSet<location_info> location_info { get; set; }
    
    }
}
