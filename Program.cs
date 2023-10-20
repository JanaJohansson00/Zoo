using System.Threading.Channels;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animalsInZoo = new List<Animal> //Skapar en lista av Animal objekt, som representerar djuren i zooet.
            {
                //Här skapas instanser av olika djurklasser, med specifika egenskaper.
                new Giraffe("Kurt", "Masai Giraffe", "light brown with spots", 15, 900, 3.9),
                new Elephant("Rosie","Forest Elephant", "grey", 45, 550, 16),
                new Lion("Simba", "African Lion", "yellow-gold", 11, 180, "Male"),
                new Monkey("Nicke", "Schimpanzee", "brown", 4, 40, 130),
                new Gorilla("Bo", "Mountain Gorilla", "black with a silverback", 28, 200, 135, "stronger than 15 humans together."),
                new Orangutan("Boris", "Sumatran Orangutan", "red orange", 23, 95, 133, "I use my hands and feet to get around!"),
                new Horse("Rider", "cold-blooded trotting horse", "darkbrown", 12, 500, 50),
                new Goat("Peter", "Domesticate goat", "white", 9, 110, 1.40)
            };
            //Djuren filtreras i två kategorier, tama och vilda.
            var wildAnimals = animalsInZoo.Where(animal => animal.IsWild);
            var domesticatedAnimals = animalsInZoo.Where(animal => !animal.IsWild);

            Console.WriteLine("Welcome to the Zoo! Each animal is gonna tell a litte about themselves.");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Here's our domesticated animals: ");
            Console.WriteLine("-----------------------------------------------------------------------");

            //En foreach loop som skriver ut information om de tama djuren.
            foreach(var animal in domesticatedAnimals)
            {
                printAnimal(animal);
            }
            Console.WriteLine("Here's our wild animals: ");
            Console.WriteLine("-----------------------------------------------------------------------");
            //En foreach loop som skriver ut information om de vilda djuren.
            foreach(var animal in wildAnimals)
            {
                printAnimal(animal);
            }
            Console.WriteLine("Thanks for visiting our zoo and welcome back!");
        }

        public static void printAnimal(Animal animal) //Metod som tar in ett objekt av djur och skriver ut information.
        {
            //Anropar metoderna från basklassen, dessa skrivs ut för varje djur.
            animal.IntroduceAnimal();
            animal.Food();

            //En if-sats som kollar om djuret finns och skriver ut specifik information beroende på vilket djur.
            if (animal is Monkey monkey)
            {
                monkey.Family();

                if (animal is Gorilla gorilla)
                {
                    gorilla.SilverBack();
                }
                else if (animal is Orangutan orangutan)
                {
                    orangutan.ToolSkills();
                }
            }
            else if (animal is Giraffe giraffe)
            {
                giraffe.GetToungeLenght();
            }
            else if (animal is Elephant elephant)
            {
                elephant.SwimmingSkills();
            }
            else if (animal is Lion lion)
            {
                lion.LifeSpan();
            }
            else if (animal is Horse horse)
            {
                horse.RaceCompetition();
            }
            else if (animal is Goat goat)
            {
                goat.GetGoatCheese();
            }
            animal.makeSound(); //Anropar metoden makeSound här för att ljudet sak skrivas ut sist i texten på samtliga djur.
            Console.WriteLine();
        }
    }
}