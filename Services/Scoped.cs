namespace Application.Services
{
    public class Scoped
    {
        public readonly int randomNumber;

        public Scoped()
        {
            Random rand = new Random();
            randomNumber = rand.Next();
        }
    }
}
