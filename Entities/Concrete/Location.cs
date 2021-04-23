using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public string Borough { get; set; }
        public int LocationId { get; set; }
        public string Zone { get; set; }
    }
}