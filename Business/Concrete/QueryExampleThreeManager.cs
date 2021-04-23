using System.Collections.Generic;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto.TypeTree;

namespace Business.Concrete
{
    public class QueryExampleThreeManager : IQueryExampleThreeService
    {
        private readonly IOperationTypeThreeDal _operationTypeThreeDal;

        public QueryExampleThreeManager(IOperationTypeThreeDal operationTypeThreeDal)
        {
            _operationTypeThreeDal = operationTypeThreeDal;
        }


        public IDataResult<List<TypeThree_ArticleOne>> QueryOne(TypeThree_ArticleOne_Input input)
        {
            var result = _operationTypeThreeDal.TypeThree_ArticleOne(input);
            if (result.Count < 1) return new ErrorDataResult<List<TypeThree_ArticleOne>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeThree_ArticleOne>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeThree_ArticleTwo>> QueryTwo(TypeThree_ArticleTwo_Input input)
        {
            var result = _operationTypeThreeDal.TypeThree_ArticleTwo(input);
            if (result.Count < 1) return new ErrorDataResult<List<TypeThree_ArticleTwo>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeThree_ArticleTwo>>(result, Messages.SuccessData);
        }

        public IDataResult<List<TypeThree_ArticleThree>> QueryThree()
        {
            var result = _operationTypeThreeDal.TypeThree_ArticleThree();
            if (result.Count < 1) return new ErrorDataResult<List<TypeThree_ArticleThree>>(Messages.NotFoundData);

            return new SuccessDataResult<List<TypeThree_ArticleThree>>(result, Messages.SuccessData);
        }
    }
}