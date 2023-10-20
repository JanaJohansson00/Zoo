using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gorilla : Monkey //En klass som ärver från den abstrakta basklassen Animal och även subklassen Monkey
    {
        public string Strength { get; set; } //En unik egenskap som tar fram gorillans styrka.

        public Gorilla(string name = "Gorilla", string breed = "Unknown", string color = "Black", int age = 0, int weight = 0,int iq = 0, string strength = "Unknown")
            :base(name, breed, color, age, weight, iq)
        {
            Strength = strength;
        }
        public override void Food()
        {
            Console.WriteLine("We mostly eat fruits and herbs, sometimes I also eat termites and ants. ");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} kg. My IQ is very high, it's {IQ}.\n" +
                $"Gorillas are extremly strong, {Strength} ");

        }
        public override void Family() 
        {
            Console.WriteLine("We're a pack animal, there are 20 of us in my family!");
        }
        public void SilverBack() //En unik metod som berättar om ledaren i gruppen.
        {
            Console.WriteLine("The silverback is the one who leads the pack, of course I'm the leader.");

        }
        public override void makeSound() 
        {
            Console.WriteLine("My sound is: HOO-HOO-Hoo");
        }
    }
}
