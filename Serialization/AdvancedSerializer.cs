using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Serialization
{
    public class AdvancedSerializer
    {
        public void ToXML<T>(T objToSerial, XmlAttributeOverrides overds)
        {
            var serializer = new XmlSerializer(objToSerial.GetType(), overds);
            var className = objToSerial.GetType().FullName.ToString();

            using (FileStream fs = new FileStream(className + ".xml", FileMode.Create))
            {
                serializer.Serialize(fs, objToSerial);
            }
        }

        public XmlAttributeOverrides GetOverrides(List<Book> books)
        {
            var overrides = new XmlAttributeOverrides();
            var attrs = new XmlAttributes();

            attrs.XmlRoot = new XmlRootAttribute("Кнiгi");
            overrides.Add(books.GetType(), attrs);

            return overrides;
        }
    }
}
