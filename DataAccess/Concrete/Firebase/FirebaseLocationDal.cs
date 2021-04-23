using System.Collections.Generic;
using DataAccess.Utilities.Helper;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public static class FirebaseLocationDal 
    {
        private static  List<Location> _locations;

        public static void CreateLocationData()
        {
            _locations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Location>>(GetRequestHelper.GetRequest("https://mobilqueryfirebase-default-rtdb.firebaseio.com/tlc_data/locations.json"));
        }
        public static IEnumerable<Location> GetAll()
        {
            return _locations;
        }


    }
}