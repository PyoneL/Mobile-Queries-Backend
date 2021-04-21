using DataAccess.Abstract;
using DataAccess.Utilities.Helper;
using Entities.Concrete;
using Entities.Dto.TypeThree;
using Newtonsoft.Json.Linq;

namespace DataAccess.Concrete.GoogleMap
{
    public class GoogleCoordinateDal : ICoordinateDal
    {
        private string key;

        public GoogleCoordinateDal()
        {
            key = "AIzaSyDzB1CFvd7Lg-FHQCWGwZnsu5hO6anD2aE";
        }

        public CoordinateDto GetCoordinate(Location location)
        {
            Coordinate coordinate;
            string address = string.Join(" ", location.Borough, location.Zone);
            var _queryLink = $@"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={key}";
            JObject result = JObject.Parse(GetRequestHelper.GetRequest(_queryLink));
            var coordinateJson = result["results"][0]["geometry"]["location"];
            coordinate = Newtonsoft.Json.JsonConvert.DeserializeObject<Coordinate>(coordinateJson.ToString());

            return new CoordinateDto
            {
                Latitude = coordinate.lat,
                Longitude = coordinate.lng
            };
        }
    }
}