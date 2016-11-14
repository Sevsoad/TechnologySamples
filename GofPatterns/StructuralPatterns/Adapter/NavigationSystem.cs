using System.Collections.Generic;

namespace GofPatterns.StructuralPatterns.Adapter
{
    public class NavigationSystem
    {
        public List<string> GetCoordinats()
        {
            var result = new List<string>();

            result.Add("12445");
            result.Add("3254");
            result.Add("12");

            return result;
        }
    }
}
