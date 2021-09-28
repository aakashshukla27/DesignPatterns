using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FeedbackXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("Parsing XML feedback");
            return "Feedback XML message";
        }
    }
}
