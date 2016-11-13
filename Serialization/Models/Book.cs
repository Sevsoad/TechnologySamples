using System.Collections.Generic;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("Кнiга")]
    public class Book
    {
        public int ID;
        [XmlElement("Назва")]
        public string Title { get; set; }
        [XmlIgnore]
        public string Avaliable { get; set; }
        [XmlElement("Састянне")]
        public BookState State { get; set; }
        [XmlAttribute("Цана")]
        public int Price { get; set; }
        [XmlElement("Тэг")]
        public List<string> Tags { get; set; }
        [XmlArray("Аутары")]
        [XmlArrayItem("Аутар", typeof(Author))]
        public List<Author> Authors { get; set; }

        public Book()
        {
            Tags = new List<string>();
            Authors = new List<Author>();
        }
    }

    public enum BookState
    {
        [XmlEnum("Цэлая")]
        NoDamage,
        [XmlEnum("Добрая")]
        MinorDamage,
        [XmlEnum("Дрэнная")]
        SevereDamage,
        [XmlEnum("Спорчаная")]
        Unreadable
    }
}
