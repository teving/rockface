using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockFace.Core.Location;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RockFace.Service.Location
{
    [Route("api/[controller]")]
    public class LocationController : Controller
    {
        private readonly ILocationRepository repository;

        public LocationController(ILocationRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<LocationListItemDto>> Get()
        {
            return await repository.GetAllLocationListItems();
        }
    }
}
