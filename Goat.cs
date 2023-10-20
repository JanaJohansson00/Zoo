using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Goat : Animal
    {
        public override bool IsWild => false; //Här används false eftersom att djuret inte är vilt.
        public override string Name { get; set; }
        public override string Breed { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public double Jumping { get; set; } //En unik egenskap som framhäver getens förmåga att hoppa.

        public Goat(string name = "Goat", string breed = "Unknown", string color = "Brown", int age = 0, int weight = 0, double jumping = 0)
            :base(name, breed, color, age, weight)
        {
            Jumping = jumping;
        }
        public override void Food()
        {
            Console.WriteLine("I usually eat bushes and grass for breakfast, lunch and dinner!");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI am {Color} and my weight is {Weight} kg.\nOne of our characteristics is that we're good at jumping, I can jump {Jumping} meters.");

        }
        public void GetGoatCheese() //En unik metod som beskriver vad geten producerar.
        {
            Console.WriteLine("We have good quality milk, humans like to make cheese with it..");
        }
        public override void makeSound()
        {
            Console.WriteLine("My sound is: Ahhhh");
        }
    }
}
