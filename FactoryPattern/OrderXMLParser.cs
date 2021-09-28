using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class OrderXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("Parsing order xml");
            return "Order XML Message";
        }
    }
}
