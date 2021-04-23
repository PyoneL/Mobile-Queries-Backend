using Core.Entities.Abstract;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleThree : IDto
    {
        public row longest_trip { get; set; }
        public row shortest_trip { get; set; }
    }
}