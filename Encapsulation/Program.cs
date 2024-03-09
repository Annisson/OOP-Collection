namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.1 - Encapsulation");

            try
            {
                Person person = new Person();

                /*  //Testing age property and exception
                Console.WriteLine("Age: ");
                int.TryParse(Console.ReadLine(), out int age);
                person.Age = age;
                Console.WriteLine($"Age is set to: {person.Age}");
                */

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"Error message: {ex.Message}");

            }

        }
    }
}
