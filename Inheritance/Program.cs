namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.3 - Inheritance");

            // 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            // S: I klassen Bird, eftersom alla fåglar ska ärva från den och därmed får med sig allt som bygger basen för en fågel

            // 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            // S: I klassen Animal som alla djuren ärver ifrån (förutsatt att vi implementerat arvet)


            List<Animal> animalsList = new List<Animal>();

            animalsList.Add(new Horse("Bob", 12, 450, true, "Carrot"));
            animalsList.Add(new Horse("Susan", 32, 550, false, "Small children"));
            animalsList.Add(new Dog("Mr Bean", 2, 2, true, 42));
            animalsList.Add(new Hedgehog("Holly", 1, 0.5, false, 4));
            animalsList.Add(new Worm("Billy", 1, 0.00025, true, true));
            animalsList.Add(new Pelican("Pete", 13, 5, false, false, 32));
            animalsList.Add(new Flamingo("Luna", 16, 3, true, false, "Pinkish"));
            animalsList.Add(new Swan("Karen", 2, 9, false, true, true));
            animalsList.Add(new Wolf("Robert", 5, 55, true, false));
            animalsList.Add(new Wolfman("Steven", 17, 85, false, true));

            foreach (var animal in animalsList)
            {
                Console.WriteLine($"{animal.Stats()}");
                // animal.Floofer();
                // 17. F: Skapa en ny metod med valfritt namn  i klassen Dog som endast returnerar en valfri sträng.
                // Kommer du åt den metoden frånAnimals listan? Varför inte?
                // S: Klassen Animal innehåller inte metoden Floofer och kan därför inte komma åt den, endast subklassen Dog kommer åt den metoden.

                if (animal is IPerson person)
                {
                    Console.Write($"What does the {animal.GetType().Name} say? ");
                    person.Talk();
                }
                else
                {
                    Console.Write($"What does the {animal.GetType().Name} say? ");
                    animal.DoSound();
                }
            }
            // 13. F: Förklara vad det är som händer.
            // S: Alla objects lagrade i Animal-listan skrivs ut med Stats-metoden.
            // Stats-metoden skriver ut alla properties från basklassen Animal + eventuella unika properties som lagts till i varje subklass.
            // If-satsen checkar sedan om varje enskilt objekt är av typen IPerson, om den är det kommer metoden Talk skrivas ut, annars kommer
            // metoden DoSound skrivas ut.

            foreach (var animal in animalsList)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine($"\nLil floofer: {animal.Stats()}, What? {dog.Floofer()}");

                }
            }

            

            List<Dog> dogsList = new List<Dog>();

            //dogsList.Add(new Horse("Lilly", 10, 500, true, "Apples"));

            // 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // S: Listan tar endast emot objects av typen Dog, och Horse är inte kopplat till Dog.

            // 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // S: Animal, eftersom alla djur-subklasser ärver från den så skulle det går att lagra de tillsammans.

        }
    }
}
