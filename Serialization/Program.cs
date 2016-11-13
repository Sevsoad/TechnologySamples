using Serialization.Models.Figures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdvancedSerializatorExample();
        }

        private static void AdvancedSerializatorExample()
        {
            var book = new BookSerializable();
            book.Title = ")))0000";
            var serializator = new SerializationWorker();

            serializator.SerializeToXML(book);

        }

        private static void DerivedFiguresExample()
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Circle() { x = 1, y = 1, r = 1});
            figures.Add(new Line() { x = 1, y = 1, x1 = 10, y1 = 10});
            figures.Add(new Circle() { x = 1, y = 1, r = 5});
            figures.Add(new Rectangle() { x = 1, y = 1, w = 10, h = 10});

            var serializer = new XmlSerializer(
                typeof(List<Figure>), new Type[]
                {
                    typeof(Circle), typeof(Line), typeof(Rectangle)
                }
                );

            using (FileStream fs = new FileStream("DerivedTypes.xml", FileMode.Create))
            {
                serializer.Serialize(fs, figures);
            }
        }

        private static void AttributesChangeExample()
        {
            var serializer = new AdvancedSerializer();

            var book = new Book();
            book.Price = 16;
            book.Title = "Dark tower";
            book.Tags.Add("Fiction");
            book.Tags.Add("Crippy");
            book.Authors.Add(new Author() { FirstName = "Stephen", LastName = "King" });

            var book2 = new Book();
            book2.Price = 12;
            book2.Title = "Dark tower 2";
            book2.Tags.Add("Fiction");
            book2.Tags.Add("Crippy");
            book2.Authors.Add(new Author() { FirstName = "Stephen", LastName = "King" });

            var books = new List<Book>();
            books.Add(book);
            books.Add(book2);

            var overrides = serializer.GetOverrides(books);
            serializer.ToXML(books, overrides);
        }
    }   
} 
