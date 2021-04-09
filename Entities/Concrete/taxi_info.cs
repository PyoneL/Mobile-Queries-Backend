using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
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
}
