using Entities.Concrete;

namespace Entities.Dto.TypeTree
{
    public class row
    {
        public Coordinate PULocationCoordinate { get; set; }

        public Coordinate DOLocationCoordinate { get; set; }

        public string PULocation { get; set; }
        public string DOLocation { get; set; }
        public decimal trip_distance { get; set; }
    }

}
