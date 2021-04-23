using DataAccess.Abstract;
using DataAccess.Utilities.Helper;
using Entities.Concrete;
using Entities.Dto.TypeThree;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataAccess.Concrete.GoogleMap
{
    public class GoogleCoordinateDal : ICoordinateDal
    {
        private readonly string _key;

        public GoogleCoordinateDal()
        {
            _key = "AIzaSyCOA7g0o-KcAnxg7C_d74h8quV_Ffsc4Ng";
        }

        public CoordinateDto GetCoordinate(Location location)
        {
            var address = string.Join(" ", location.Borough, location.Zone);
            var queryLink = $@"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={_key}";
            var result = JObject.Parse(GetRequestHelper.GetRequest(queryLink));
            var coordinateJson = result["results"][0]["geometry"]["location"];
            var coordinate = JsonConvert.DeserializeObject<Coordinate>(coordinateJson.ToString());

            return new CoordinateDto
            {
                Latitude = coordinate.lat,
                Longitude = coordinate.lng
            };
        }
    }
}