using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak();  // Output: The animal makes a sound.
            myDog.Speak();     // Output: The dog barks.
            myCat.Speak();     // Output: The cat meows.
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }








}