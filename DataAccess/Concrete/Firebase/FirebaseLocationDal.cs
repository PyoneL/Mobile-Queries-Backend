using System.Collections.Generic;
using DataAccess.Utilities.Helper;
using Entities.Concrete;
using Newtonsoft.Json;

namespace DataAccess.Concrete.Firebase
{
    public static class FirebaseLocationDal
    {
        private static List<Location> _locations;

        public static void CreateLocationData()
        {
            _locations = new List<Location>();
            _locations = JsonConvert.DeserializeObject<List<Location>>(
                GetRequestHelper.GetRequest(
                    "https://mobilqueryfirebase-default-rtdb.firebaseio.com/tlc_data/locations.json"));
        }

        public static IEnumerable<Location> GetAll()
        {
            return _locations;
        }
    }
}