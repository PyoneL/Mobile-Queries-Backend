using System;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Operation : IEntity
    {
        public int DOLocationID { get; set; }
        public int PULocationID { get; set; }
        public int passenger_count { get; set; }
        public decimal total_amount { get; set; }
        public decimal trip_distance { get; set; }
        public DateTime tpep_pickup_datetime { get; set; }
        public DateTime tpep_dropoff_datetime { get; set; }
    }
}