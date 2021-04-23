using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Dto.TypeTwo;

namespace Business.Abstract
{
    public interface IQueryExampleTwoService
    {
        public IDataResult<List<TypeTwo_ArticleOne>> QueryOne(TypeTwo_ArticleOne_Input input);
        public IDataResult<List<TypeTwo_ArticleTwo>> QueryTwo();
        public IDataResult<List<TypeTwo_ArticleThree>> QueryThree(TypeTwo_ArticleThree_Input input);
    }
}