using System;

namespace Serialization
{
    [Serializable]
    public class Car
    {
        private static string serialNumber = "StaticField";
        private string x;
        public string y;
        public string z;
        public string CarName { get; set; }
        public Engine engine;

        
        public Car(int x1)
        {
            x = "1";
            y = "2";
            z = "3";
            CarName = "Tesla";
            engine = new Engine();
        }

        public void Ride()
        {
            y += " +1";
        }
    }

    [Serializable]
    public class Engine
    {
        public string engineNumber;

        public Engine()
        {
            engineNumber = "12345";
        }
    }
}
