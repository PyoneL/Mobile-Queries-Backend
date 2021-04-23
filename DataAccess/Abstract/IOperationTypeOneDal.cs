using System.Collections.Generic;
using Entities.Dto.TypeOne;

namespace DataAccess.Abstract
{
    public interface IOperationTypeOneDal
    {
        List<TypeOne_ArticleOne> TypeOne_ArticleOne();
        List<TypeOne_ArticleTwo> TypeOne_ArticleTwo(TypeOne_ArticleTwo_Input input);
        List<TypeOne_ArticleThree> TypeOne_ArticleThree();
    }
}