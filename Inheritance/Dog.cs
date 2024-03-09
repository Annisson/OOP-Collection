namespace Inheritance
{
    internal class Dog : Animal
    {
        public bool HasGoodTeef { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Woof woof ruff");
        }
        public Dog(string name, int age, double weight, bool pet, bool teef) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            HasGoodTeef = teef;
        }
    }
}
