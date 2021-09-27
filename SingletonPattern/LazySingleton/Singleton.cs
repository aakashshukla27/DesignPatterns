using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.LazySingleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private Singleton()
        {            
            Console.WriteLine("Counter Value: " + (++counter).ToString());
        }

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public static Singleton GetInstance()
        {
            return instance.Value;
        }
    }
}
