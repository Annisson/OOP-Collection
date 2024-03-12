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
        public int BeakLength { get; set; }
        public Pelican(string name, int age, double weight, bool pet, bool food, int beak) : base(name, age, weight, pet, food)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg= pet;
            WillStealFood = food;
            BeakLength = beak;
        }
    }

    internal class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo(string name, int age, double weight, bool pet, bool food, string color) : base(name, age, weight, pet, food)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood = food;
            Color = color;
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
