using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Elephant : Animal //En klass som ärver från den abstrakta basklassen Animal. 
    {
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Breed { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public int Hearing { get; set; } // En unik egenskap för djuret som tar fram djurets hörsel.

        public Elephant(string name = "Elephant", string breed = "Unknown", string color = "Grey", int age = 0, int weight = 0, int hearing = 0)
            : base(name, breed, color, age, weight)
        {
            Hearing = hearing;
        }

        public override void Food()
        {
            Console.WriteLine("My daily diet consists of fruit, branches, twigs and bark. I eat an average of 130\n" +
                "kg a day. ");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} ton.\n" +
                $"I have a very good hearing, I can hear sounds under {Hearing} Hz.");
            
        }
        public void SwimmingSkills() //Skapar en unik metod för att berätta om elefantens simkunnigheter.
        {
            Console.WriteLine("What many don't know about elephants is that we're great swimmers!\n" +
                "Guess you wouldn't believe that when you saw my weight!");
        }
        public override void makeSound()
        {
            Console.WriteLine("My sound is: Yyyy-m");
        }
    }
}
