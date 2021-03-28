using DuckSimulator.Interfaces;
using System;

namespace DuckSimulator
{
    public class MallardDuck : Duck, IFlyable, IMakeSound
    {
        public MallardDuck(string name, string color, int age)
            : base(name, color, age)
        {
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
