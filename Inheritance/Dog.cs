﻿namespace Inheritance
{
    internal class Dog : Animal
    {
        public int NumberOfTeef { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Rrrrrrrruff");
        }
        public Dog(string name, int age, double weight, bool pet, int teef) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            NumberOfTeef = teef;
        }

        public override string Stats()
        {
            return base.Stats() + $", Number of teef: {NumberOfTeef}";
        }

        public string Floofer()
        {
            return "I'm a cute floofer heh";
        }
    }
}
