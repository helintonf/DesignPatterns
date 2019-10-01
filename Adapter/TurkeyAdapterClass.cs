namespace Adapter
{
    internal class TurkeyAdapterClass : Duck
    {
        public Turkey Turkey { get; set; }

        public TurkeyAdapterClass(Turkey turkey)
        {
            Turkey = turkey;
        }

        public void Fly()
        {
            Turkey.Gobble();
        }

        public void Quack()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }
    }
}