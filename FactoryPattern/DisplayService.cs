using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class DisplayService
    {
        public void Display()
        {
            IXMLParser xMLParser = getParser();
            string msg = xMLParser.Parse();
            Console.WriteLine(msg);
        }

        protected abstract IXMLParser getParser();
    }
}
