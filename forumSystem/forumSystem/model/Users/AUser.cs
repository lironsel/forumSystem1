namespace forumSystem.model
{
    public abstract class AUser : IObserver
    {
        public abstract string getUserName();
        public abstract void notify(string data);
        public abstract string getName();
    }
}
