using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Horse : Animal //En klass som ärver från den abstrakta basklassen Animal. 
    {
        public override bool IsWild => false; //Här används false eftersom att djuret inte är vilt.
        public override string Name { get; set; }
        public override string Breed { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public int Speed { get; set; } //En unik egenskap som tar fram hästens hastighet.

        public Horse(string name = "Horse", string breed = "Unknown", string color = "Brown", int age = 0, int weight = 0, int speed = 0)
            :base(name, breed, color, age, weight)
       
        {
            Speed = speed;
        }
        public override void Food()
        {
            Console.WriteLine("I love carrots, but usually my caregivers give me hay..");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI am {Color} and my weight is {Weight} kg.\nHorses can run fast up to {Speed} km per hour");

        }
        public void RaceCompetition() //En unik metod som berättar om hästens förmåga att springa.
        {
            Console.WriteLine("I've been in many races before I arrived at the zoo! We run at a high speed!");
        }
        public override void makeSound()
        {
            Console.WriteLine("My sound is: Brrrhh");
        }
    }
}
