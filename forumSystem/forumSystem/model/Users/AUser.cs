namespace forumSystem.model
{
    public abstract class AUser : IObserver
    {
        public abstract string getName();
        public abstract void notify(string data);
    }
}
