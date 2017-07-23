using RockFace.Core.Base;

namespace RockFace.Core.Problem
{
    public class LocationListItemDto : BaseEntity
    {
        public string Name { get; }

        public LocationListItemDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
