using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockFace.Core.Location
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationListItemDto>> GetAllLocationListItems();
    }
}
