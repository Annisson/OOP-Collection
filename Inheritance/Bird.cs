using System.Drawing;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool WillStealFood { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("You're trying to sleep? Let me sing you the song of my people");
        }
        public Bird(string name, int age, double weight, bool pet, bool theif) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood = theif;
        }
        public override string Stats()
        {
            return base.Stats() + $", Will steal food? {(WillStealFood ? "Big theif" : "No way!")}";
        }
    }

    internal class Pelican : Bird
    {
        public int BeakLength { get; set; }
        public Pelican(string name, int age, double weight, bool pet, bool theif, int beak) : base(name, age, weight, pet, theif)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg= pet;
            WillStealFood = theif;
            BeakLength = beak;
        }
        public override string Stats()
        {
            return base.Stats() + $", Beak length: {BeakLength}cm";
        }
    }

    internal class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo(string name, int age, double weight, bool pet, bool theif, string color) : base(name, age, weight, pet, theif)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood = theif;
            Color = color;
        }
        public override string Stats()
        {
            return base.Stats() + $", Color: {Color}";
        }
    }

    internal class Swan : Bird
    {
        public bool IsMean { get; set; }
        public Swan(string name, int age, double weight, bool pet, bool theif, bool mean) : base(name, age, weight, pet, theif)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WillStealFood= theif;
            IsMean = mean;
        }
        public override string Stats()
        {
            return base.Stats() + $", Mean birdie? {(IsMean ? "Very mean :(" : "Very kind, promise")}";
        }
    }
}
