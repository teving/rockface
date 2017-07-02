using System.Collections.Generic;
using RockFace.Core.Location;

namespace RockFace.Core.DummyData
{
    public class DummyLocationRepository : ILocationRepository
    {
        public IEnumerable<LocationListItemDto> GetAllLocationListItems()
        {
            return new[]
            {
                new LocationListItemDto(1, "Biscuit Factory"),
                new LocationListItemDto(2, "Building One")
            };
        }
    }
}
