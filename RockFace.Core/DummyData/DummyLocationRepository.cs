using System.Collections.Generic;
using System.Threading.Tasks;
using RockFace.Core.Location;

namespace RockFace.Core.DummyData
{
    public class DummyLocationRepository : ILocationRepository
    {
        private static readonly LocationListItemDto[] Locations = {
            new LocationListItemDto(1, "Biscuit Factory"),
            new LocationListItemDto(2, "Building One")
        };

        public Task<IEnumerable<LocationListItemDto>> GetAllLocationListItems()
        {
            return Task<IEnumerable<LocationListItemDto>>.Factory.StartNew(() => Locations);
        }
    }
}
