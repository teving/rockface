using RockFace.Core.Problem;
using StructureMap;

namespace RockFace.Service.Config
{
    public class SystemWideIoCRegistry : Registry
    {
        public SystemWideIoCRegistry()
        {
            Scan(_ =>
            {
                _.AssembliesAndExecutablesFromApplicationBaseDirectory();
                _.AddAllTypesOf<ILocationRepository>();
                _.AddAllTypesOf<ICircuitRepository>();
                _.WithDefaultConventions();
            });
        }
    }
}
