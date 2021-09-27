using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.LazySingleton
{
    class LazySingletonDriver
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintS1Details(),
                () => PrintS2Details()
                );

            //PrintS1Details();
            //PrintS2Details();

            Console.ReadKey();
        }

        private static void PrintS2Details()
        {
            Singleton s2 = Singleton.GetInstance();
            s2.PrintDetails("From s2");
        }

        private static void PrintS1Details()
        {
            Singleton s1 = Singleton.GetInstance();
            s1.PrintDetails("From s1");
        }
    }
}
