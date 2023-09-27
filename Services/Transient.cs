namespace Application.Services
{
    public class Transient
    {
        public readonly int randomNumber;

        public Transient()
        {
            Random rand = new();
            randomNumber = rand.Next();
        }
    }
}
