using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal(0,"something","New animal","somewhere",0);
            newAnimal.MakeSound();
            newAnimal.Eat();

            Dog charli = new Dog(5, "bones", "Charli", "at home on the rug", 12.5);
            Elephant bigboss = new Elephant(7, "fruits", "Big Boss", "rain forest", 6000);
            Eagle sony = new Eagle(4, "rodents", "Sony", "steppe",6.5 );
            HummingBird sweety = new HummingBird(2,"nectar", "Sweety", "mountainmeadows",0.4);

            charli.MakeSound();
            charli.Play();
            charli.Sleep();

            bigboss.MakeSound();
            bigboss.Smile();
            bigboss.Eat();

            sony.MakeSound();
            sony.Fly();
            sony.Fight();

            sweety.MakeSound();
            sweety.LookingForFood();
            sweety.Act();
        }
    }
}
