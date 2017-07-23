using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockFace.Core.Problem
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationListItemDto>> GetAllLocationListItems();
        Task<LocationDetailsItemDto> GetLocationDetails(int locationId);
    }
}
