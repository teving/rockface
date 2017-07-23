using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockFace.Core.Problem;

namespace RockFace.Core.DummyData
{
    public class DummyDataStore : ILocationRepository, ICircuitRepository
    {
        private static readonly LocationListItemDto[] Locations = {
            new LocationListItemDto(0, "Biscuit Factory"),
            new LocationListItemDto(1, "Building One")
        };

        private static readonly HuecoGrade[] HuecoGrades =
        {
            new HuecoGrade {Id = 0, Number = 0},
            new HuecoGrade {Id = 1, Number = 1},
            new HuecoGrade {Id = 2, Number = 2},
            new HuecoGrade {Id = 3, Number = 3},
            new HuecoGrade {Id = 4, Number = 4},
            new HuecoGrade {Id = 5, Number = 5},
            new HuecoGrade {Id = 6, Number = 6},
            new HuecoGrade {Id = 7, Number = 7},
            new HuecoGrade {Id = 8, Number = 8}
        };

        private static readonly CircuitListItemDto[] Circuits =
        {
            new CircuitListItemDto {Id = 0, LocationId = 0, Colour = "Spotty White", MinimumGrade = HuecoGrades[0]},
            new CircuitListItemDto {Id = 1, LocationId = 0, Colour = "Black", MinimumGrade = HuecoGrades[1]},
            new CircuitListItemDto {Id = 2, LocationId = 0, Colour = "Tiger", MinimumGrade = HuecoGrades[1], MaximumGrade = HuecoGrades[2]},
            new CircuitListItemDto {Id = 3, LocationId = 0, Colour = "Blue", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[3]},
            new CircuitListItemDto {Id = 4, LocationId = 0, Colour = "Salmon", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[3]},
            new CircuitListItemDto {Id = 5, LocationId = 0, Colour = "Yellow", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[4]},
            new CircuitListItemDto {Id = 6, LocationId = 0, Colour = "Purple and Yellow", MinimumGrade = HuecoGrades[3], MaximumGrade = HuecoGrades[5]},
            new CircuitListItemDto {Id = 7, LocationId = 0, Colour = "Hendrix", MinimumGrade = HuecoGrades[3], MaximumGrade = HuecoGrades[5]},
            new CircuitListItemDto {Id = 8, LocationId = 0, Colour = "Red", MinimumGrade = HuecoGrades[4], MaximumGrade = HuecoGrades[6]},
            new CircuitListItemDto {Id = 9, LocationId = 0, Colour = "White", MinimumGrade = HuecoGrades[5], MaximumGrade = HuecoGrades[7]},
            new CircuitListItemDto {Id = 10, LocationId = 0, Colour = "Green", MinimumGrade = HuecoGrades[6], MaximumGrade = HuecoGrades[8]},
            new CircuitListItemDto {Id = 11, LocationId = 1, Colour = "Spotty White", MinimumGrade = HuecoGrades[0]},
            new CircuitListItemDto {Id = 12, LocationId = 1, Colour = "Black", MinimumGrade = HuecoGrades[1]},
            new CircuitListItemDto {Id = 13, LocationId = 1, Colour = "Tiger", MinimumGrade = HuecoGrades[1], MaximumGrade = HuecoGrades[2]},
            new CircuitListItemDto {Id = 14, LocationId = 1, Colour = "Blue", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[3]},
            new CircuitListItemDto {Id = 15, LocationId = 1, Colour = "Salmon", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[3]},
            new CircuitListItemDto {Id = 16, LocationId = 1, Colour = "Yellow", MinimumGrade = HuecoGrades[2], MaximumGrade = HuecoGrades[4]},
            new CircuitListItemDto {Id = 17, LocationId = 1, Colour = "Purple and Yellow", MinimumGrade = HuecoGrades[3], MaximumGrade = HuecoGrades[5]},
            new CircuitListItemDto {Id = 18, LocationId = 1, Colour = "Hendrix", MinimumGrade = HuecoGrades[3], MaximumGrade = HuecoGrades[5]},
            new CircuitListItemDto {Id = 19, LocationId = 1, Colour = "Red", MinimumGrade = HuecoGrades[4], MaximumGrade = HuecoGrades[6]},
            new CircuitListItemDto {Id = 20, LocationId = 1, Colour = "White", MinimumGrade = HuecoGrades[5], MaximumGrade = HuecoGrades[7]},
            new CircuitListItemDto {Id = 21, LocationId = 1, Colour = "Green", MinimumGrade = HuecoGrades[6], MaximumGrade = HuecoGrades[8]},
            new CircuitListItemDto {Id = 22, LocationId = 0, Description = "Competition Wall"}
        };

        public Task<IEnumerable<LocationListItemDto>> GetAllLocationListItems()
        {
            return Task<IEnumerable<LocationListItemDto>>.Factory.StartNew(() => Locations);
        }

        public Task<LocationDetailsItemDto> GetLocationDetails(int locationId)
        {
            return Task<LocationDetailsItemDto>.Factory.StartNew(() =>
            {
                var location = Locations.SingleOrDefault(l => l.Id == locationId);
                if (location == null)
                {
                    return null;
                }

                return new LocationDetailsItemDto
                {
                    Id = locationId,
                    Name = location.Name,
                    Circuits = Circuits.Where(c => c.LocationId == locationId)
                };
            });
        }

        public Task<IEnumerable<CircuitListItemDto>> GetCircuitsForLocation(int locationId)
        {
            return Task<IEnumerable<CircuitListItemDto>>.Factory.StartNew(() => Circuits.Where(c => c.LocationId == locationId));
        }
    }
}
