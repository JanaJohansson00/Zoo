using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal //En abstrakt klass det som fungerar som en bas för dom olika djuren. De andra klasserna ärver från animal.
    {
        public abstract bool IsWild { get; } //En bool som kollar om djuret är tamt eller vilt. Här behövs endast { get; } för att djuret kommer vara antingen tamt eller vilt.
                                             //Eftersom att att vi inte har { set; } kan värdet inte ändras.
        public abstract string Name { get; set; } //En abstrakt egenskap som hämtar och sätter djurets namn.
        //{ get; } gör att man sätter värdet, { set; } gör att man kan hämta och ändra värdet.
        public abstract string Color { get; set; } //En abstrakt egenskap som hämtar och sätter djurets färg.
        public abstract string Breed { get; set; } //En abstrakt egenskap som hämtar och sätter djurets ras.
        public abstract int Age { get; set; } //En abstrakt egenskap som hämtar och sätter djurets ålder.
        public abstract int Weight { get; set; } //En abstrakt egenskap som hämtar och sätter djurets vikt.

        public Animal(string name, string breed, string color, int age, int weight) //Konstruktor med fem imparametrar. Detta gör att egenskaperna sparas när ett nytt djur skapas.
        {
            Name = name;
            Breed = breed;
            Color = color;
            Age = age;
            Weight = weight;
        }

        //Dessa metoder ärver subklasserna
        public abstract void makeSound(); //En abstrakt metod för att göra ljuden. Implementeras av subklasserna.

        public abstract void Food(); //En abstrakt metod för att få info om vad djuren äter. Implementeras av subklasserna.

        public abstract void IntroduceAnimal(); //En abstrakt metod för att introducera djuren. Implementeras av subklasserna.

    }
}
