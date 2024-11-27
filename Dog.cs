using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Dog : Animal
    {
        public string _dogColour { get; set; } = "Golden";
        public Dog(int age, string food, string nickname, string habitat, double weight)
           : base(age, food, nickname, habitat, weight) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{_nickname} wuf wuf !");
        }
        public void Play()
        {
            Console.WriteLine($"{_nickname} is playing in the {_habitat}");
        }
    }
}
