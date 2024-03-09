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
    }
}
