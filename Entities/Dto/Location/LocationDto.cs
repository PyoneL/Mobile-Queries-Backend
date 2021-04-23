using Core.Entities.Abstract;

namespace Entities.Dto.Location
{
    public class LocationDto : IDto
    {
        public int LocationID { get; set; }
        public string Location { get; set; }
    }
}