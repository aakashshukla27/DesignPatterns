using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ResponseXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("Parsing response XML");
            return "Response XML";
        }
    }
}
