namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.3 - Inheritance");
        }

        // 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
        // S: I klassen Bird, eftersom alla fåglar ska ärva från den och därmed får med sig allt som bygger basen för en fågel

        // 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        // S: I klassen Animal som alla djuren ärver ifrån (förutsatt att vi implementerat arvet)
    }
}
