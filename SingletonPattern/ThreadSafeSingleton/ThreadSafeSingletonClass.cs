using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    public sealed class ThreadSafeSingletonClass
    {
        private static int counter = 0;
        private static ThreadSafeSingletonClass instance = null;
        private static readonly object obj = new object();
        private ThreadSafeSingletonClass()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }

        public static ThreadSafeSingletonClass GetInstance()
        {
            if(instance == null)
            {
                lock (obj)
                {
                    if (instance == null) instance = new ThreadSafeSingletonClass();
                }
            }
            
            return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
