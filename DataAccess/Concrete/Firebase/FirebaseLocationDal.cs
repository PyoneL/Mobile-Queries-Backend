using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Utilities.Helper;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseLocationDal : ILocationDal
    {
        private List<Location> _locations;
        private string _queryLink;
        public FirebaseLocationDal()
        {
            _locations = new List<Location>();
            _queryLink = "https://mobilequery-2ba56-default-rtdb.firebaseio.com/tlc-data/locations.json";

        }

        public List<Location> GetAll()
        {
            _locations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Location>>(GetRequestHelper.GetRequest(_queryLink));
            return _locations;
        }


    }
}