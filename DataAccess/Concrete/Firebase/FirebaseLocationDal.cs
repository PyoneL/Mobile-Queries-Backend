using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Utilities.Helper;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public static class FirebaseLocationDal 
    {
        private static  List<Location> _locations;

        public static void CreateLocationData()
        {
            _locations = new List<Location>();
            string _queryLink = "https://mobilqueryfirebase-default-rtdb.firebaseio.com/tlc_data/locations.json";
            _locations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Location>>(GetRequestHelper.GetRequest(_queryLink));

        }
        public static List<Location> GetAll()
        {
            return _locations;
        }


    }
}