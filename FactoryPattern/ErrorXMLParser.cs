using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ErrorXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("Parsing Error");
            return "Error XML";
        }
    }
}
