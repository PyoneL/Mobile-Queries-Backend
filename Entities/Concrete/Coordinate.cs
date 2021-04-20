using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Coordinate : IEntity
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
}