namespace Composto
{
    internal class GooseAdapter : IQuackable
    {
        public Goose Goose { get; set; }

        public GooseAdapter(Goose goose)
        {
            Goose = goose;
        }

        public void Quack()
        {
            Goose.Honk();
        }
    }
}