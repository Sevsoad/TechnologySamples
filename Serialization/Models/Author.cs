using System.Xml.Serialization;

namespace Serialization
{    
    public class Author
    {
        [XmlElement("Имя")]
        public string FirstName { get; set; }

        [XmlElement("Прозвишча")]
        public string LastName { get; set; }
    }
}
