using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IMemoryCacheService
    {
        IResult CacheRestore();
    }
}