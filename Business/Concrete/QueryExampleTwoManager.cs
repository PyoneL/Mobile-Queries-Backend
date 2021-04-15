using Business.Abstract;
using System.Collections.Generic;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto.TypeTwo;

namespace Business.Concrete
{
    public class QueryExampleTwoManager : IQueryExampleTwoService
    {
        private readonly IOperationTypeTwoDal _operationTypeTwoDal;

        public QueryExampleTwoManager(IOperationTypeTwoDal operationTypeTwoDal)
        {
            _operationTypeTwoDal = operationTypeTwoDal;
        }


        public IDataResult<List<TypeTwo_ArticleOne>> QueryOne(TypeTwo_ArticleOne_Input input)
        {
            return new SuccessDataResult<List<TypeTwo_ArticleOne>>(_operationTypeTwoDal.TypeTwo_ArticleOne(input));
        }

        public IDataResult<List<TypeTwo_ArticleTwo>> QueryTwo()
        {
            return new SuccessDataResult<List<TypeTwo_ArticleTwo>>(_operationTypeTwoDal.TypeTwo_ArticleTwo());
        }

        public IDataResult<List<TypeTwo_ArticleThree>> QueryThree(TypeTwo_ArticleThree_Input input)
        {
            return new SuccessDataResult<List<TypeTwo_ArticleThree>>(_operationTypeTwoDal.TypeTwo_ArticleThree(input));
        }
    }
}
