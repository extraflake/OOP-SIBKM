using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Katak : Animal
    {
        public Katak(int id, string name, int age, bool gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override void Bernapas(string Name)
        {
            base.Bernapas(Name);
            Console.WriteLine(Name + " bernapas dengan kulit");
        }
    }
}
