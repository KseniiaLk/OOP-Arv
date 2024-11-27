using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Arv
{
    public class Elephant : Animal
    {
        public int _quantity { get; set; } = 6;
        public Elephant(int age, string food, string nickname, string habitat, double weight)
            : base(age,food,nickname,habitat,weight){ }

        public override void MakeSound()
        {
            Console.WriteLine($"{_nickname} wohoooo!");
        }
        public void Smile()
        {
            Console.WriteLine($"{_nickname} is smiling with all {_quantity} of teeth");
        }
    }
}
