namespace Inheritance
{
    internal class Horse : Animal
    {
        public string FaveSnack {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Neheheheheheee weeee");
        }

        public Horse(string name, int age, double weight, bool pet, string snack) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            FaveSnack = snack;
        }
        
    }
}
