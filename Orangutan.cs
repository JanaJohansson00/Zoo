using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Orangutan : Monkey //En klass som ärver från den abstrakta basklassen Animal och även subklassen Monkey. Arv i två generationer.
    {
        public string Climbing { get; set; } //En unik egenskap som framhäver orangutangens förmåga att klättra.

        public Orangutan(string name = "Orangutan", string breed = "Unknown", string color = "Orange", int age = 0, int weight = 0, int iq = 0, string climbing = "Unknown")
            :base(name, breed, color, age, weight, iq)
        {
            Climbing = climbing;
        }
        public override void Food()
        {
            Console.WriteLine("We mostly eat fruit, herbs, termites and honey. ");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} kg. My IQ is very high, it's {IQ}.\nOrangutans are experts at climbing {Climbing} ");

        }
        public override void Family() 
        {
            Console.WriteLine("We like to live alone, so I don't have a family.");
        }

        public void ToolSkills() //En unik metoden som berättar om orangutangens förmåga att skapa verktyg.
        {
            Console.WriteLine("Orangutans are very good at making tools. For an example making leaves into a umbrella.");
        }
        public override void makeSound()
        {
            Console.WriteLine("My sound is: Hmwooh Hmwooh Mwooh");
        }
    }
}
