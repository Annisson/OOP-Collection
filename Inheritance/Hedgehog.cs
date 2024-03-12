namespace Inheritance
{
    internal class Hedgehog : Animal
    {
        public int WinsAgainstCats { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Squeaky squeak eek eek");
        }
        public Hedgehog(string name, int age, double weight, bool pet, int wins) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            WinsAgainstCats = wins;
        }
    }
}
