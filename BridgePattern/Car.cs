using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Car
    {
        private readonly IProduct product;
        private readonly string carType;
        public Car(IProduct product, String carType)
        {
            this.product = product;
            this.carType = carType;
        }
        public abstract void assemble();
        public abstract void produceProduct();


    }
}
