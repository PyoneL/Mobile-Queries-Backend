using Entities.Dto.TypeThree;

namespace Entities.Dto.TypeTree
{
    public class row
    {
        public CoordinateDto PULocationCoordinate { get; set; }

        public CoordinateDto DOLocationCoordinate { get; set; }

        public string PULocation { get; set; }
        public string DOLocation { get; set; }
        public decimal trip_distance { get; set; }
    }
}