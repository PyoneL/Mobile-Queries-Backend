using System.Collections.Generic;
using Entities.Dto.TypeTree;

namespace DataAccess.Abstract
{
    public interface IOperationTypeThreeDal
    {
        public List<TypeThree_ArticleOne> TypeThree_ArticleOne(TypeThree_ArticleOne_Input input);
        public List<TypeThree_ArticleTwo> TypeThree_ArticleTwo(TypeThree_ArticleTwo_Input input);
        public List<TypeThree_ArticleThree> TypeThree_ArticleThree();
    }
}