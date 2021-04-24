using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.Firebase;

namespace Business.Concrete
{
    public class MemoryCacheManager : IMemoryCacheService
    {
        public IResult CacheRestore()
        {
            FirebaseLocationDal.CreateLocationData();
            FirebaseOperationDal.CreateList();
            return new SuccessResult("Cache Restored");
        }
    }
}