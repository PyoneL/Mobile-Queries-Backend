using Core.Entities.Abstract;

namespace Entities.Dto.TypeThree
{
    public class CoordinateDto :IDto
    {
        public double Latitude  { get; set; }
        public double Longitude { get; set; }
        
        
    }
}