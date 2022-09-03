using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOproject
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"Hello everyone! Jasmine said to tell you she may be called {Name} and her fav colour is {Color}.");
        }
    }
}
