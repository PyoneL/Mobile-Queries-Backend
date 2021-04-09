using Core.Utilities.Results;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQueryService
    {
        public IDataResult<List<TypeOne_ArticleOne>> TypeOne_ArticleOne();
        public IDataResult<List<TypeOne_ArticleTwo>> TypeOne_ArticleTwo(TypeOne_ArticleTwo_Input input);
        public IDataResult<List<TypeOne_ArticleThree>> TypeOne_ArticleThree();

        public IDataResult<List<TypeTwo_ArticleOne>> TypeTwo_ArticleOne(TypeTwo_ArticleOne_Input input);
        public IDataResult<List<TypeTwo_ArticleTwo>> TypeTwo_ArticleTwo();
        public IDataResult<List<TypeTwo_ArticleThree>> TypeTwo_ArticleThree(TypeTwo_ArticleThree_Input input);

        public IDataResult<List<TypeThree_ArticleOne>> TypeThree_ArticleOne(TypeThree_ArticleOne_Input input);
        public IDataResult<List<TypeThree_ArticleTwo>> TypeThree_ArticleTwo(TypeThree_ArticleTwo_Input input);
        public IDataResult<List<TypeThree_ArticleThree>> TypeThree_ArticleThree();
    }
}
