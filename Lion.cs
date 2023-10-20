using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Lion : Animal //En klass som ärver från den abstrakta basklassen Animal. 
    {
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Breed { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public string Gender { get; set; } //En unik egenskap som tar fram djurets kön.

        public Lion(string name = "Lion", string breed = "Unknown", string color = "Orange", int age = 0, int weight = 0, string gender = "Unknown")
            :base(name, breed, color, age, weight)
        {
            Gender = gender;
        }

        public override void Food()
        {
            Console.WriteLine("I love to eat meat, my favorite is zebra. Buffaloes and antelopes works to, but preferably\n" +
                "on weekdays.");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} kg.\n" +
                $"I am a {Gender} and I lead the herd.");
            
        }
        public void LifeSpan() //En unik metod som berätta om lejonets livslängd
        {
            Console.WriteLine("Lions live up to 20 years, but I'm gonna get older than that!");
        }
        public override void makeSound()
        {
            Console.WriteLine("My sound is: Roaaar");
        }
    }
}
