using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.TypeOne;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class QueryExampleLocationManager : IQueryExampleLocationService
    {
        private IOperationLocationDal _locationDal;

        public QueryExampleLocationManager(IOperationLocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IDataResult<List<Location>> GetAllLocation()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAllLocation());
        }
    
    }
}
