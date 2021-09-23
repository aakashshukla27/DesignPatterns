using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class CentralLocking : IProduct
    {
        private readonly string ProductName;

        public CentralLocking(string productName)
        {
            this.ProductName = productName;
        }
        public void produce()
        {
            Console.WriteLine("Producing Central Locking System");
        }

        public string productName()
        {
            return ProductName;
        }
    }
}
