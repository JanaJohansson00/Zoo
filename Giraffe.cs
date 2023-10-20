using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Giraffe : Animal //En klass som ärver från den abstrakta basklassen Animal. 
    {
        public override bool IsWild => true; //Här sätts true eftersom att djuret är vilt.
        public override string Name { get; set; } //Override används för att subklasserna ärver från den abstrakta klassen Animals.
                                                  //Override måste användas för att metoder och egenskaper ska kunna implementera den abstrakta klassen eller egenskapen.
        public override string Breed { get; set; } 
        public override string Color { get; set; }
        public override int Age { get; set; }
        public override int Weight { get; set; }

        public double Length { get; set; } //En unik egenskap för djuret som tar fram djurets längd.

        //Konstruktorn för Giraffe klassen som tar flera parametrar och som används ör att skapa en ny instans av giraff.
        //Jag har även lagt in defaultvärden i klasserna som ärver från animal, det gör att det finns en standardvärde för djuret.
        //Om man inte sätter värden så sätts det automatiskt via default.
        //I konstruktorn läggs även den unika egenskapen till.
        public Giraffe(string name = "Loke", string breed = "Unknown", string color = "Orange", int age = 10, int weight = 850, double length = 4.2)
            :base(name, breed, color, age, weight) //:base, Variablerna kopplas till huvudklasssen i underordnande klasser.
        {
            Length = length;
        }

        public override void Food() //Implementerar den abstrakta metoden Food för att ta fram djurets kost.
        {
            Console.WriteLine("I love to eat plant and leaves are my favorite. I can eat up to 30 kg leaves per day! ");
        }
        public override void IntroduceAnimal() //Implementerar den abstrakta metoden IntroduceAnimal för att presentera infon om djuret.
        {
            Console.WriteLine($"My name is {Name} and I'm a {Breed}. I'm {Age} years old.\nI'm {Color} and my weight is {Weight} kg.\n" +
                $"Giraffes are famous for being very tall, I'm {Length} meter. ");
            
        }
        public void GetToungeLenght() //Skapar en unik metod för att berätta om giraffens tunglängd.
        {
            Console.WriteLine("I have a noticeably long tounge, just like every other giraffe. My tounge is 45 cm.");
        }
        public override void makeSound() //Implementerar den abstrakta metoden för att beskriva djurets ljud.
        {
            Console.WriteLine("My sound is: So low that human can't hear me.You usually only hear me when I'm munching\non food.");
        }
    }
}
