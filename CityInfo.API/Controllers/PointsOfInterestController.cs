using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterestDto>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(item => item.Id == cityId);
            if (city == null) return NotFound();

            return Ok(city);
        }

        [HttpGet("{pointofinterestid}")]
        public ActionResult<PointsOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(item => item.Id == cityId);
            if (city == null) return NotFound();

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(item => item.Id == pointOfInterestId);
            if (pointOfInterest == null) return NotFound();

            return Ok(pointOfInterest);
        }
    }
}
