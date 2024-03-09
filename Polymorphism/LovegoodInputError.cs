namespace Polymorphism
{
    internal class LovegoodInputError : UserError
    {
        public override string UEMessage()
        {
            return "Oh no! This isn't a good place for Luna, she won't find any Nargles here! Whoopsie";
        }
    }
}
