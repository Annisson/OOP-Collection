namespace Polymorphism
{
    internal class MyrtleInputError : UserError
    {
        public override string UEMessage()
        {
            return "You cannot put Moaning Myrtle in here, this isn't the girl's bathroom!";
        }
    }
}
