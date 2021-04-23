using Core.Entities.Abstract;
using Entities.Dto.TypeThree;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleTwo : IDto
    {
        public CoordinateDto PULocationCoordinate { get; set; }

        public CoordinateDto DOLocationCoordinate { get; set; }

        public string PULocation { get; set; }
        public string DOLocation { get; set; }
    }
}