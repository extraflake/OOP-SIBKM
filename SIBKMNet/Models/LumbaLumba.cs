using SIBKMNet.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class LumbaLumba : Animal, IBehaviour
    {
        public LumbaLumba(int id, string name, int age, bool gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Study(string Name)
        {
            Console.WriteLine(Name + " sedang belajar");
        }
    }
}
