using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public interface IProduct
        {
            string Operation();
        }

        class ConcreteProduct1 : IProduct
        {
            public string Operation()
            {
                return "Result of ConcreteProduct1";
            }
        }

        class ConcreteProduct2 : IProduct
        {
            public string Operation()
            {
                return "Result of ConcreteProduct 2";
            }
        }

        abstract class Creator
        {
            public abstract IProduct FactoryMethod();

            public string SomeOperation()
            {
                var product = FactoryMethod();
                var result = "the same creator code has worked with " + product.Operation();
                return result;
            }
        }

        class ConcreteCreator1 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct1();
            }
        }

        class ConcreteCreator2 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct2();
            }
        }
    }
}
