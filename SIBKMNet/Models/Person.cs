using SIBKMNet.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIBKMNet.Models
{
    public class Person : Behaviour, IBehaviour
    {
        public Person(int Id, string Name, string City, int Age, bool Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.City = City;
            this.Age = Age;
            this.Gender = Gender;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public int Age { get; private set; }
        public bool Gender { get; private set; }

        public override void Bernapas(string Name)
        {
            base.Bernapas(Name);
            Console.WriteLine(Name + " bernapas dengan hidung");
        }

        public override void Eat()
        {
            Console.WriteLine("menggunakan mulut dan tangan");
        }

        public override void Sleep()
        {
            Console.WriteLine("memejamkan kedua mata");
        }

        public override void Play()
        {
            Console.WriteLine("bermain dengan console game");
        }

        public void Study(string Name)
        {
            Console.WriteLine(Name + " sedang belajar");
        }
    }
}
