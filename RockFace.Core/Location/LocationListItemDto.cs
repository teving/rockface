namespace RockFace.Core.Location
{
    public class LocationListItemDto
    {
        public int Id { get; }
        public string Name { get; }

        public LocationListItemDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
