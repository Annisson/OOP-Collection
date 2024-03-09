namespace Inheritance
{
    internal class Horse : Animal
    {
        public bool IsGoodPony {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Neheheheheheee weeee");
        }

        public Horse(string name, int age, double weight, bool pet, bool good) : base(name, age, weight, pet)
        {
            Name = name;
            Age = age;
            Weight = weight;
            CanIPetThatDawg = pet;
            IsGoodPony = good;
        }
        
    }
}
