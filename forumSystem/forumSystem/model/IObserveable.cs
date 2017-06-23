namespace forumSystem.model
{
    interface IObserveable
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
    }
}
