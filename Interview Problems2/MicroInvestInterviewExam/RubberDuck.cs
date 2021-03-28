using DuckSimulator.Interfaces;
using System;

namespace DuckSimulator
{
    public class RubberDuck : Duck, IMakeSound
    {

        public RubberDuck(string name, string color, int age) 
            : base(name, color, age)
        {
        }
        public void MakeSound()
        {
            Console.WriteLine("Kwak");
        }

    }
}
