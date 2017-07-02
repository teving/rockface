using System.Collections.Generic;
using RockFace.Core.Location;

namespace RockFace.Core.DummyData
{
    public class DummyLocationRepository : ILocationRepository
    {
        private static readonly LocationListItemDto[] Locations = {
            new LocationListItemDto(1, "Biscuit Factory"),
            new LocationListItemDto(2, "Building One")
        };

        public IEnumerable<LocationListItemDto> GetAllLocationListItems()
        {
            return Locations;
        }
    }
}
