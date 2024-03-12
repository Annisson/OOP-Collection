namespace Inheritance
{
    internal class Worm : Animal
    {
        public bool LovesRain {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("I'm a slithery lil snekky snekk");
        }

        public Worm(string name, int age, double weight, bool pet, bool love) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            LovesRain = love;
        }
        public override string Stats()
        {
            return base.Stats() + $", Loves rain? {(LovesRain ? "Yes!" : "Nooo")}";
        }
    }
}
