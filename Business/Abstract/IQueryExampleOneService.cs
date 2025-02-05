﻿using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Dto.TypeOne;

namespace Business.Abstract
{
    public interface IQueryExampleOneService
    {
        public IDataResult<List<TypeOne_ArticleOne>> QueryOne();
        public IDataResult<List<TypeOne_ArticleTwo>> QueryTwo(TypeOne_ArticleTwo_Input input);
        public IDataResult<List<TypeOne_ArticleThree>> QueryThree();
    }
}