namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool WillStealFood { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("You're trying to sleep? Let me sing you the song of my people");
        }
        public Bird(string name, int age, double weight, bool pet, bool food) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood = food;
        }
    }

    internal class Pelican : Bird
    {
        public bool IsBigBirdy { get; set; }
        public Pelican(string name, int age, double weight, bool pet, bool food, bool big) : base(name, age, weight, pet, food)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg= pet;
            WillStealFood = food;
            IsBigBirdy = big;
        }
    }

    internal class Flamingo : Bird
    {
        public bool IsPretty { get; set; }
        public Flamingo(string name, int age, double weight, bool pet, bool food, bool pretty) : base(name, age, weight, pet, food)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood = food;
            IsPretty = pretty;
        }
    }

    internal class Swan : Bird
    {
        public bool IsMean { get; set; }
        public Swan(string name, int age, double weight, bool pet, bool food, bool mean) : base(name, age, weight, pet, food)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood= food;
            IsMean = mean;
        }
    }
}
