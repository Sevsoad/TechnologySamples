using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Serialization
{
    
    public class BookSerializable : IXmlSerializable
    {
        public int ID;
        
        public string Title { get; set; }
        
        public bool Avaliable { get; set; }
        
        public BookState State { get; set; }
        
        public int Price { get; set; }
        
        public List<string> Tags { get; set; }
        
        public List<Author> Authors { get; set; }

        public BookSerializable()
        {
            Tags = new List<string>();
            Authors = new List<Author>();
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            var rootName = reader.Name;

            while(reader.Read() && reader.Name != rootName)
            {
                var name = reader.Name;
                switch (name)
                {
                    case "Название":
                        Title = reader.Value;
                        break;
                }
            }


        }

        public void WriteXml(XmlWriter writer)
        {            
            writer.WriteAttributeString("Цена", Price.ToString());
            writer.WriteElementString("НаЗвАнИе", Title);
            writer.WriteElementString("Наличие", Avaliable ? "Yes" : "No");
            writer.WriteElementString(")))))", ":P");
        }
    }
}
