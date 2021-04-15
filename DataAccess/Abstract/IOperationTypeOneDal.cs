using Entities.Dto.TypeOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOperationTypeOneDal : IOperationDal
    {
        List<TypeOne_ArticleOne> TypeOne_ArticleOne();
        List<TypeOne_ArticleTwo> TypeOne_ArticleTwo(TypeOne_ArticleTwo_Input input);
        List<TypeOne_ArticleThree> TypeOne_ArticleThree();
    }
}
