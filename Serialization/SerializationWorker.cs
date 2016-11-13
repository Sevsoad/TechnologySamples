using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    public class SerializationWorker
    {
        public void SerializeToBinary<T>(T objToSerial)
        {
            BinaryFormatter serializator = new BinaryFormatter();
            var className = objToSerial.GetType().FullName.ToString();

            using (FileStream fs = new FileStream(className + ".dat", FileMode.Create))
            {
                serializator.Serialize(fs, objToSerial);
            }
        }

        public void SerializeToSoap<T>(T objToSerial)
        {
            var serializator = new SoapFormatter();
            var className = objToSerial.GetType().FullName.ToString();

            using (FileStream fs = new FileStream(className + "Soap.txt", FileMode.Create))
            {
                serializator.Serialize(fs, objToSerial);
            }
        }

        public void SerializeToXML<T>(T objToSerial)
        {
            var serializator = new XmlSerializer(objToSerial.GetType());
            var className = objToSerial.GetType().FullName.ToString();

            using (FileStream fs = new FileStream(className + ".xml", FileMode.Create))
            {
                serializator.Serialize(fs, objToSerial);
            }
        }
        
        public void ToWcf<T>(T objToSerial)
        {
            var serializator = new DataContractSerializer(objToSerial.GetType());
            var className = objToSerial.GetType().FullName.ToString();

            using (FileStream fs = new FileStream(className + "_wcf.xml", FileMode.Create))
            {
                serializator.WriteObject(fs, objToSerial);
            }
        }

        public void ToJson<T>(T objToSerial)
        {
            var serializator = new JavaScriptSerializer();
            var className = objToSerial.GetType().FullName.ToString();
            
                var sb = new StringBuilder();
                serializator.Serialize(objToSerial, sb);

                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory +
                    objToSerial.GetType().FullName + ".json", sb.ToString());
            
        }

        public T FromWcf<T>(string fileName)
        {
            var serializator = new DataContractSerializer(typeof(T));
            T result;

            using (FileStream fs = new FileStream(fileName + "_wcf.xml", FileMode.Open))
            {
                result = (T)serializator.ReadObject(fs);
            }

            return result;
        }

        public T DeserializeFromXML<T>(string fileName)
        {
            var serializator = new XmlSerializer(typeof(T));
            T result;

            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Open))
            {
                result = (T)serializator.Deserialize(fs);
            }

            return result;
        }

        public T DeserializeFromBinary<T>(string fileName)
        {
            BinaryFormatter serializator = new BinaryFormatter();
            T result;

            using (FileStream fs = new FileStream(fileName + ".dat", FileMode.Open))
            {
                result = (T)serializator.Deserialize(fs);
            }

            return result;
        }
    }
}
