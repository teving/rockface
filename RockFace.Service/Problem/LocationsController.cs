using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockFace.Core.Problem;

namespace RockFace.Service.Problem
{
    [Route("api/locations")]
    public class LocationsController : Controller
    {
        private readonly LocationProvider provider;

        public LocationsController(LocationProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public async Task<IEnumerable<LocationListItemDto>> Get()
        {
            return await provider.GetAllLocations();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<LocationDetailsItemDto> Get(int id)
        {
            return await provider.GetDetailsById(id);
        }
    }
}
