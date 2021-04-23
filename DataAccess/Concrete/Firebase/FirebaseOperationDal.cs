using System.Collections.Generic;
using DataAccess.Utilities.Helper;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public static class FirebaseOperationDal
    {
        private static List<Operation> _operations;

        public static void CreateList()
        {
            _operations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Operation>>(GetRequestHelper.GetRequest("https://mobilqueryfirebase-default-rtdb.firebaseio.com/tlc_data/operations.json"));
        }
        
        public static List<Operation> GetAll()
        {
            return _operations;
        }
    }
}