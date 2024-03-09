namespace Inheritance
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool CanIPetThatDawg { get; set; }

        public abstract void DoSound();

        protected Animal(string name, int age, double weight, bool pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
        }


        // 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
        // S: I klassen Bird, eftersom alla fåglar ärver från den och därmed får med sig allt som bygger basen för en fågel

        // 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        // S: I klassen Animal som alla djuren ärver ifrån (förutsatt att vi implementerat arvet)

    }
}
