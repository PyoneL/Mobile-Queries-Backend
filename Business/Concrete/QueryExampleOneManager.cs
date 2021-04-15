using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto.TypeOne;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class QueryExampleOneManager : IQueryExampleOneService
    {
        private IOperationTypeOneDal _operationTypeOneDal;

        public QueryExampleOneManager(IOperationTypeOneDal operationTypeOneDal)
        {
            _operationTypeOneDal = operationTypeOneDal;
        }

        public IDataResult<List<TypeOne_ArticleOne>> QueryOne()
        {
            return new SuccessDataResult<List<TypeOne_ArticleOne>>(_operationTypeOneDal.TypeOne_ArticleOne());
        }
        public IDataResult<List<TypeOne_ArticleThree>> QueryThree()
        {
            return new SuccessDataResult<List<TypeOne_ArticleThree>>(_operationTypeOneDal.TypeOne_ArticleThree());
        }
        public IDataResult<List<TypeOne_ArticleTwo>> QueryTwo(TypeOne_ArticleTwo_Input input)
        {
            return new SuccessDataResult<List<TypeOne_ArticleTwo>>(_operationTypeOneDal.TypeOne_ArticleTwo(input));
        }
    }
}
