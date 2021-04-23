using System.Collections.Generic;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto.TypeOne;

namespace Business.Concrete
{
    public class QueryExampleOneManager : IQueryExampleOneService
    {
        private readonly IOperationTypeOneDal _operationTypeOneDal;

        public QueryExampleOneManager(IOperationTypeOneDal operationTypeOneDal)
        {
            _operationTypeOneDal = operationTypeOneDal;
        }

        public IDataResult<List<TypeOne_ArticleOne>> QueryOne()
        {
            var result = _operationTypeOneDal.TypeOne_ArticleOne();
            if (result.Count < 1) return new ErrorDataResult<List<TypeOne_ArticleOne>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeOne_ArticleOne>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeOne_ArticleThree>> QueryThree()
        {
            var result = _operationTypeOneDal.TypeOne_ArticleThree();
            if (result.Count < 1) return new ErrorDataResult<List<TypeOne_ArticleThree>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeOne_ArticleThree>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeOne_ArticleTwo>> QueryTwo(TypeOne_ArticleTwo_Input input)
        {
            var result = _operationTypeOneDal.TypeOne_ArticleTwo(input);
            if (result.Count < 1) return new ErrorDataResult<List<TypeOne_ArticleTwo>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeOne_ArticleTwo>>(result, Messages.SuccessData);
        }
    }
}