using System;
using System.Collections.Generic;
using System.Text;
using RockFace.Core.Base;

namespace RockFace.Core.Problem
{
    public class LocationDetailsItemDto : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<CircuitListItemDto> Circuits { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
