using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class LivingCreatures
    {
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
