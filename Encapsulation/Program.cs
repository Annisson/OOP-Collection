namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.1 - Encapsulation");

            try
            {
                Person person = new Person("Harry", "Potter");

                Console.WriteLine($"F: {person.FName}, L: {person.LName}");


                //Testing age property and exception
                //Console.WriteLine("Test: ");
                //int.TryParse(Console.ReadLine(), out int nr);
                //person.Age = nr;
                //Console.WriteLine($"Age is set to: {person.Age}");


                //Console.WriteLine("Name: ");

                //person.FName = Console.ReadLine();
                //Console.WriteLine($"Name is set to: {person.FName}");



            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"Error message: {ex.Message}");

            }

        }
    }
}
