using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockFace.Core.Problem;

namespace RockFace.Service.Problem
{
    [Route("api/locations")]
    public class LocationsController : Controller
    {
        private readonly ILocationRepository repository;

        public LocationsController(ILocationRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<LocationListItemDto>> Get()
        {
            return await repository.GetAllLocationListItems();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<LocationDetailsItemDto> Get(int id)
        {
            return await repository.GetLocationDetails(id);
        }
    }
}
