namespace Application.Services
{
    public class Singleton
    {
        public readonly int randomNumber;

        public Singleton()
        {
            Random rand = new Random();
            randomNumber = rand.Next();
        }
    }
}
