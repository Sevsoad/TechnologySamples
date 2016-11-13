using System.Collections.Generic;

namespace Serialization
{
    public class CarShop
    {
        private string SecretPassword = "Dont serialize";
        public string Address;
        public int RoomsQty;
        public List<Car> Cars;

        public CarShop()
        {
            Address = "StreetName";
            Cars = new List<Car>();
            RoomsQty = 10;
        }        

        public void SetPassword(string input)
        {
            SecretPassword = input;
        }
    }
}
