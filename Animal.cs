using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Arv
{
    public class Animal
    {
        public int _age { get; set; }
        public string _food { get; set; }
        public string _nickname { get; set; }
        public string _habitat { get; set; }
        public double _weight { get; set; }

        public Animal(int age, string food, string nickname, string habitat, double weight)
        {
            _age = age;
            _food = food;
            _nickname = nickname;
            _habitat = habitat;
            _weight = weight;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{_nickname} is making sound.");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{_nickname} is eating {_food}.");
        }
        public virtual void Act()
        {
            Console.WriteLine($"{_nickname} is in the {_habitat}.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{_nickname} is sleeping.");
        }
    }
}
