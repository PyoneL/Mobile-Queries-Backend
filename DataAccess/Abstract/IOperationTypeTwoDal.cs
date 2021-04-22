using Entities.Dto.TypeTwo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOperationTypeTwoDal
    {
        public List<TypeTwo_ArticleOne> TypeTwo_ArticleOne(TypeTwo_ArticleOne_Input input);
        public List<TypeTwo_ArticleTwo> TypeTwo_ArticleTwo();
        public List<TypeTwo_ArticleThree> TypeTwo_ArticleThree(TypeTwo_ArticleThree_Input input);
    }
}
