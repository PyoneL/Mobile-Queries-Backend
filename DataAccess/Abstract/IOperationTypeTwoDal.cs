using System.Collections.Generic;
using Entities.Dto.TypeTwo;

namespace DataAccess.Abstract
{
    public interface IOperationTypeTwoDal
    {
        public List<TypeTwo_ArticleOne> TypeTwo_ArticleOne(TypeTwo_ArticleOne_Input input);
        public List<TypeTwo_ArticleTwo> TypeTwo_ArticleTwo();
        public List<TypeTwo_ArticleThree> TypeTwo_ArticleThree(TypeTwo_ArticleThree_Input input);
    }
}