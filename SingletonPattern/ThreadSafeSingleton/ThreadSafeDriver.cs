using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    class ThreadSafeDriver
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>PrintS1Details(),
                ()=>PrintS2Details()
                );

            //PrintS1Details();
            //PrintS2Details();

            Console.ReadKey();
        }

        private static void PrintS2Details()
        {
            ThreadSafeSingletonClass s2 = ThreadSafeSingletonClass.GetInstance();
            s2.PrintDetails("From s2");
        }

        private static void PrintS1Details()
        {
            ThreadSafeSingletonClass s1 = ThreadSafeSingletonClass.GetInstance();
            s1.PrintDetails("From s1");
        }
    }
}
