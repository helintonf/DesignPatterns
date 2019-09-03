namespace Singleton
{
    internal class ChocolateBoiler
    {
        private static ChocolateBoiler Instance { get; set; }
        private bool Empty { get; set; }
        private bool Boiled { get; set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ChocolateBoiler();
            }
            return Instance;
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }
    }
}