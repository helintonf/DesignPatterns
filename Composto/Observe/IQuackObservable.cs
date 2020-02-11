namespace Composto
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObervers();
    }
}