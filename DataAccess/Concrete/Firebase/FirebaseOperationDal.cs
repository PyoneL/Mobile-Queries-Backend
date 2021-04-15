using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Utilities.Helper;
using Entities.Concrete;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseOperationDal : IOperationDal
    {
        internal List<Operation> _operations;
        private string _queryLink;
        public FirebaseOperationDal()
        {
            _operations = new List<Operation>();
            _queryLink = "https://mobilequery-2ba56-default-rtdb.firebaseio.com/tlc-data/operations.json";
            _operations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Operation>>(GetRequestHelper.GetRequest(_queryLink));
        }
        internal List<Operation> GetAll()
        {
            return _operations;
        }
    }
}