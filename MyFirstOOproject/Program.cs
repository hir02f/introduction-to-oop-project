using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bird myBird = new Bird("Tweety", "Yellow");
            //myBird.Speak();
            //myBird.Fly();

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();
            pippa.Spin();
            pippa.DoTheCaterpillar();
            pippa.Jump();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();
            pingu.Spin();
            pingu.DoTheCaterpillar();
            pingu.Jump();

            Parrot myPet = new Parrot("Jazz", "Blue");
            myPet.Speak();            
        }
    }
}
