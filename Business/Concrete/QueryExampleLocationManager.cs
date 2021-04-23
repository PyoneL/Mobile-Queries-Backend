using System.Collections.Generic;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class QueryExampleLocationManager : IQueryExampleLocationService
    {
        private readonly IOperationLocationDal _locationDal;

        public QueryExampleLocationManager(IOperationLocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IDataResult<List<Location>> GetAllLocation()
        {
            var result = _locationDal.GetAllLocation();
            if (result.Count < 1) return new ErrorDataResult<List<Location>>(Messages.NotFoundData);

            return new SuccessDataResult<List<Location>>(result, Messages.SuccessData);
        }
    }
}