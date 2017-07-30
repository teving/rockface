using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RockFace.Core.Problem
{
    public class LocationProvider
    {
        private readonly ILocationRepository repository;

        public LocationProvider(ILocationRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<LocationListItemDto>> GetAllLocations()
        {
            return repository.GetAllLocationListItems();
        }

        public Task<LocationDetailsItemDto> GetDetailsById(int locationId)
        {
            return repository.GetLocationDetails(locationId);
        }
    }
}
