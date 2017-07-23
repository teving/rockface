using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockFace.Core.Problem
{
    public interface ICircuitRepository
    {
        Task<IEnumerable<CircuitListItemDto>> GetCircuitsForLocation(int locationId);
    }
}