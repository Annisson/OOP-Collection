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

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}years, Weight: {Weight}kg, Can I pet that dawg? {(CanIPetThatDawg ? "Yes! Pets please!" : "0/10 would not recommend")}";
        }

    }
}
