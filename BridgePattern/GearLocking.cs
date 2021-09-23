using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class GearLocking : IProduct
    {
        private readonly string ProductName;

        public GearLocking(string s)
        {
            ProductName = s;
        }
        public void produce()
        {
            Console.WriteLine("Producing Gear Locking System");
        }

        public string productName()
        {
            return ProductName;
        }
    }
}
