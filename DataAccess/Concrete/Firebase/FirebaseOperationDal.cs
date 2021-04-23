using System.Collections.Generic;
using DataAccess.Utilities.Helper;
using Entities.Concrete;
using Newtonsoft.Json;

namespace DataAccess.Concrete.Firebase
{
    public static class FirebaseOperationDal
    {
        private static List<Operation> _operations;

        public static void CreateList()
        {
            _operations = JsonConvert.DeserializeObject<List<Operation>>(
                GetRequestHelper.GetRequest(
                    "https://mobilqueryfirebase-default-rtdb.firebaseio.com/tlc_data/operations.json"));
        }

        public static List<Operation> GetAll()
        {
            return _operations;
        }
    }
}