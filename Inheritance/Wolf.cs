namespace Inheritance
{
    internal class Wolf : Animal
    {
        public bool DangerFloof { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Rawrrr grr awooooooo");
        }
        public Wolf(string name, int age, double weight, bool pet, bool floof) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            DangerFloof = floof;
        }
        public override string Stats()
        {
            return base.Stats() + $", Dangerous floofer? {(DangerFloof ? "Yah, big danger" : "No, it's just a pupper")}";
        }
    }

    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, bool pet, bool floof) : base(name, age, weight, pet, floof)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            DangerFloof = floof;
        }

        public void Talk()
        {
            Console.WriteLine("AWOOOOOOOOOOOOO");
        }
    }
}
