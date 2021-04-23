using Business.Abstract;
using System.Collections.Generic;
using Business.Constants.Messages;
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
            var result = _operationTypeTwoDal.TypeTwo_ArticleOne(input);
            if (result.Count < 1)
            {
                return new ErrorDataResult<List<TypeTwo_ArticleOne>>(message: Messages.NotFoundData);
            }

            return new SuccessDataResult<List<TypeTwo_ArticleOne>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeTwo_ArticleTwo>> QueryTwo()
        {
            var result = _operationTypeTwoDal.TypeTwo_ArticleTwo();
            if (result.Count < 1)
            {
                return new ErrorDataResult<List<TypeTwo_ArticleTwo>>(message: Messages.NotFoundData);
            }

            return new SuccessDataResult<List<TypeTwo_ArticleTwo>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeTwo_ArticleThree>> QueryThree(TypeTwo_ArticleThree_Input input)
        {
            var result = _operationTypeTwoDal.TypeTwo_ArticleThree(input);
            if (result.Count < 1)
            {
                return new ErrorDataResult<List<TypeTwo_ArticleThree>>(message: Messages.NotFoundData);
            }
            
            return new SuccessDataResult<List<TypeTwo_ArticleThree>>(result,Messages.SuccessData);
        }
    }
}
