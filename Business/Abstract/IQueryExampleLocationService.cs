using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.TypeOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQueryExampleLocationService
    {
        public IDataResult<List<Location>> GetAllLocation();
    }
}
