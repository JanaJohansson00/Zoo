using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Monkey : Animal //En klass som ärver från den abstrakta basklassen Animal. 
    {
        public override bool IsWild => true;
        public override string Name { get; set; }
        public override string Breed { get; set; }
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }

        public int IQ { get; set; } //En unik egenskap som tar fram apans IQ.

        public Monkey(string name = "Monkey", string breed = "Unknown", string color = "Darkbrown", int age = 0, int weight = 0, int iq = 0)
            :base(name, breed, color, age, weight)
        {
            IQ = iq;
        }

        public override void Food()
        {
            Console.WriteLine("My diet consists of fruit and vegetables. Sometimes I also eat bugs and fish, if I have to..");
        }
        public override void IntroduceAnimal()
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} kg.\nI have a very high IQ, just like some humans. My IQ is {IQ}.");
            
        }
        public virtual void Family() //En unik metod för att berätta om apans familj.
        {
            Console.WriteLine("I am a pack animal, there are 15 of us in my family!");
        }
        public override void makeSound() 
        {
            Console.WriteLine("My sound is: OaA-a-a");
        }
    }
}
