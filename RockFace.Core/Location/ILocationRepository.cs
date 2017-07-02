using System.Collections.Generic;

namespace RockFace.Core.Location
{
    interface ILocationRepository
    {
        IEnumerable<LocationListItemDto> GetAllLocationListItems();
    }
}
