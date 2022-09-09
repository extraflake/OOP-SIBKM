using SIBKMNet.Models;
using System; 

namespace SIBKMNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Manusia", "Jakarta", 18, true);
            person.Eat();
            person.Bernapas("Manusia");
            person.Living("a", "b");
            person.Study("Manusia");

            Console.WriteLine();

            Katak katak = new Katak(1, "Froggy", 2, false);
            katak.Eat();
            katak.Bernapas("Katak");
            katak.Living("Air", "Daratan");

            LumbaLumba lumbaLumba = new LumbaLumba(1, "Dolphain", 2, false);
            lumbaLumba.Eat();
            lumbaLumba.Bernapas("Lumba - Lumba");
            lumbaLumba.Living("Air", "Daratan");
            lumbaLumba.Study("Lumba - Lumba");
        }
    }
}