using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Dto.TypeTree;

namespace Business.Abstract
{
    public interface IQueryExampleThreeService
    {
        public IDataResult<List<TypeThree_ArticleOne>> QueryOne(TypeThree_ArticleOne_Input input);
        public IDataResult<List<TypeThree_ArticleTwo>> QueryTwo(TypeThree_ArticleTwo_Input input);
        public IDataResult<List<TypeThree_ArticleThree>> QueryThree();
    }
}