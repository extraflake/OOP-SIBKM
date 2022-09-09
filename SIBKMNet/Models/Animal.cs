using SIBKMNet.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Animal : Behaviour
    {
        public Animal(int Id, string Name, int Age, bool Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        public Animal()
        {

        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public bool Gender { get; protected set; }

        public override void Eat()
        {
            Console.WriteLine("makan menggunakan mulut");
        }

        public override void Sleep()
        {
            Console.WriteLine("memejamkan kedua mata");
        }

        public override void Play()
        {
            Console.WriteLine("berenang di sungai");
        }
    }
}
