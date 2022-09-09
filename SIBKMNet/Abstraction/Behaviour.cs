using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Abstraction
{
    public abstract class Behaviour
    {
        // replacement
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();
        // modify
        public virtual void Bernapas(string Name)
        {
            Console.WriteLine(Name + " sedang bernapas");
        }

        // overloading
        public void Living(string alam)
        {
            Console.WriteLine("bisa hidup di alam " + alam);
        }

        public void Living(string alam1, string alam2)
        {
            Console.WriteLine("bisa hidup di alam " + alam1 + " & alam " + alam2);
        }
    }
}
