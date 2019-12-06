namespace Proxy
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Interests { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }

        public int HotOrNotRating
        {
            get
            {
                if (RatingCount == 0)
                    return 0;
                return Rating / RatingCount;
            }
            set
            {
                Rating += value;
                RatingCount += 1;
            }
        }

        protected Person()
        {
            RatingCount = 0;
        }
    }
}