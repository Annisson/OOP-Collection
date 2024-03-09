namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.1 - Encapsulation");

            try
            {
                //Person person = new Person();
                //Console.WriteLine($"F: {person.FName}, L: {person.LName}");

                //Testing age property and exception
                //Console.WriteLine("Test: ");
                //int.TryParse(Console.ReadLine(), out int nr);
                //person.Age = nr;
                //Console.WriteLine($"Age is set to: {person.Age}");

                //Console.WriteLine("Name: ");
                //person.FName = Console.ReadLine();
                //Console.WriteLine($"Name is set to: {person.FName}");

                PersonHandler handler = new PersonHandler();

                Person harry = handler.CreatePerson(22, "Harry", "Potter", 165, 57);
                Person hermione = handler.CreatePerson(21, "Hermione", "Granger", 165, 52);
                Person ronald = handler.CreatePerson(22, "Ronald", "Weasley", 173, 75);

                Console.WriteLine($"Hello, my name is {harry.FName} {harry.LName} and I'm {harry.Age}yrs old. I'm kinda short, about {harry.Height}cm and " +
                    $"I weight {harry.Weight}kg, but that's ok. I can still grab all the points from Slytherin :>");
                Console.WriteLine($"\nHiiii! I'm {hermione.FName} {hermione.LName}! I'm not gonna tell you my age, don't you know that you should never ask a lady that? " +
                    $"I won't tell you me weight either. Just know these two nobheads would not have made it through the first year without me.");
                Console.WriteLine($"\nWazzup, I'm {ronald.FName} {ronald.LName}. I'm {ronald.Age}ys old, and I am a whooping {ronald.Height}cm tall, " +
                    $"which is way taller than Harry mind you. I weight about {ronald.Weight}kg so I can totally sit on Harry to win a fight. \nHas anyone seen Scabbers?");

                handler.SetAge(hermione, 500);
                Console.WriteLine($"\nWhoopsie, Hermione didn't age well. She looks about {hermione.Age}yrs. Must be one of those potions...");

                handler.SetWeight(ronald, 120);
                Console.WriteLine($"\nDamn {ronald.FName}, what did you eat? Your weight must be {ronald.Weight}kg or something!");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"Error message: {ex.Message}");

            }

        }
    }
}
