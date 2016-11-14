namespace GofPatterns.StructuralPatterns.Adapter
{
    public class CoordinatBoard
    {
        private ICoordinateProvider _coordProvider;

        public CoordinatBoard(ICoordinateProvider provider)
        {
            _coordProvider = provider;
        }

        public string GetCoordinates()
        {
            var coordinats = _coordProvider.GetCoordinats();

            var result = string.Format("X:{0}, Y:{1}, Z:{2}",
                coordinats[0], coordinats[1], coordinats[2]);

            if (coordinats[0] > 0 && coordinats[1] > 0)
            {
                result += "\n Eto norma";
            }            

            return result;
        }
    }    
}
