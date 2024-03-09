namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.2 - Polymorphism ");

            List<UserError> errorList = new List<UserError>();

            NumericInputError numErr = new NumericInputError();
            errorList.Add(numErr);

            TextInputError textErr = new TextInputError();
            errorList.Add(textErr);

            MyrtleInputError myrtleErr = new MyrtleInputError();
            errorList.Add(myrtleErr);

            TrelawneyInputError trelawneyErr = new TrelawneyInputError();
            errorList.Add(trelawneyErr);


            foreach (UserError error in errorList)
            {
                Console.WriteLine($"Error: {error.UEMessage()}");
            }

        }
    }
}
