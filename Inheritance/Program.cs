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
        }
    }
}
