using SimUDuck.Fly;
using SimUDuck.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public Duck()
        {

        }
        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim");
        }

    }
}
