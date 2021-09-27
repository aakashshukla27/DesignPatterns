using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Implementation
{
    /// <summary>
    /// Sealed class to prevent inheritance
    /// </summary>
    public sealed class BasicSingleton
    {
        private static int counter = 0;
        private static BasicSingleton instance = null;
        /// <summary>
        /// lazy initialization
        /// </summary>
        /// <returns></returns>
        public static BasicSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new BasicSingleton();
            }
            return instance;
        }
        /// <summary>
        /// Private constructor ensures that object is not instantiated other than the class itself.
        /// </summary>
        private BasicSingleton()
        {
            Console.WriteLine("Counter value: " + (++counter).ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
