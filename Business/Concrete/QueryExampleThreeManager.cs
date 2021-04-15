using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto.TypeTree;

namespace Business.Concrete
{
    public class QueryExampleThreeManager : IQueryExampleThreeService
    {
        private IOperationTypeThreeDal _operationTypeThreeDal;

        public QueryExampleThreeManager(IOperationTypeThreeDal operationTypeThreeDal)
        {
            _operationTypeThreeDal = operationTypeThreeDal;
        }


        public IDataResult<List<TypeThree_ArticleOne>> QueryOne(TypeThree_ArticleOne_Input input)
        {
            return new SuccessDataResult<List<TypeThree_ArticleOne>>(
                _operationTypeThreeDal.TypeThree_ArticleOne(input));
        }

        public IDataResult<List<TypeThree_ArticleTwo>> QueryTwo(TypeThree_ArticleTwo_Input input)
        {
            return new SuccessDataResult<List<TypeThree_ArticleTwo>>(
                _operationTypeThreeDal.TypeThree_ArticleTwo(input));
        }

        public IDataResult<List<TypeThree_ArticleThree>> QueryThree()
        {
            return new SuccessDataResult<List<TypeThree_ArticleThree>>(_operationTypeThreeDal.TypeThree_ArticleThree());
        }
    }
}