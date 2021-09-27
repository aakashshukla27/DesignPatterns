using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Implementation
{
    class Driver
    {
        static void Main(string[] args)
        {
            PrintS1Details();
            PrintS2Details();

            Console.ReadKey();
        }

        private static void PrintS2Details()
        {
            BasicSingleton s2 = BasicSingleton.GetInstance();
            s2.PrintDetails("From s2");
        }

        private static void PrintS1Details()
        {
            BasicSingleton s1 = BasicSingleton.GetInstance();
            s1.PrintDetails("From s1");
        }
    }
}
