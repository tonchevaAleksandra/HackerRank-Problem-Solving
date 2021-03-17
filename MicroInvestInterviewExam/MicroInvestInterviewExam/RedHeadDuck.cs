using System;
using System.Collections.Generic;
using System.Text;
using DuckSimulator.Interfaces;

namespace DuckSimulator
{
   public class RedHeadDuck:Duck, IFlyable, IMakeSound
    {
        public RedHeadDuck(string name, string color, int age) 
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
