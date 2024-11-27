using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Arv
{
    public class Bird : Animal
    {
        public bool _dangerous { get; set; } = true;
        public Bird(int age, string food, string nickname, string habitat, double weight)
               : base(age, food, nickname, habitat, weight)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_nickname} uuuuuu!");
        }

        public void Fly()
        {
            Console.WriteLine($"{_nickname} is flying.");
        }

    }
    public class Eagle : Bird
    {
        public int _lenght { get; set; } = 65;
        public Eagle(int age, string food, string nickname, string habitat, double weight)
               : base(age, food, nickname, habitat, weight)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_nickname} aaaayyyy!");
        }

        public void Fight()
        {
            Console.WriteLine($"{_nickname} is fighting for prey.");
        }
    }
    public class HummingBird : Bird
    {
        public int _size { get; set; } = 5;
        public HummingBird(int age, string food, string nickname, string habitat, double weight)
               : base(age, food, nickname, habitat, weight)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_nickname} shuujj!");
        }

        public void LookingForFood()
        {
            Console.WriteLine($"{_nickname} is looking for {_food} in flowers.");
        }
    }
}
