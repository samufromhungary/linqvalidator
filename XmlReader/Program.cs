using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;

namespace XmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate();
        }

        static void Validate()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "testfile.xsd");

            Console.Write("Attempting validation of document...\n\n");

            XDocument doc = XDocument.Load("testfile.xml");
            bool errors = false;

            doc.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("Document is: {0}", errors ? "not valid" : "valid");
            Console.ReadKey();
        }
        
        static void Read()
        {

        }
    }
}
