namespace Inheritance
{
    internal class Hedgehog : Animal
    {
        public bool IsCute { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Squeaky squeak eek eek");
        }
        public Hedgehog(string name, int age, double weight, bool pet, bool cute) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            IsCute = cute;
        }
    }
}
