using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Business.Constants.Messages;

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
            if (result.Count < 1)
            {
                return new ErrorDataResult<List<Location>>(message: Messages.NotFoundData);
            }

            return new SuccessDataResult<List<Location>>(result, Messages.SuccessData);
        }
    
    }
}
