using System;

namespace GofPatterns.StructuralPatterns.Adapter
{
    public class CoordinatProviderAdapter : ICoordinateProvider
    {
        private NavigationSystem _navSystem;

        public CoordinatProviderAdapter(NavigationSystem navSystem)
        {
            _navSystem = navSystem;
        }

        public int[] GetCoordinats()
        {
            var navCoords = _navSystem.GetCoordinats();

            var result = new[] { Int32.Parse(navCoords[0]),
                Int32.Parse(navCoords[1]), Int32.Parse(navCoords[2])};

            return result;
        }
    }
}
