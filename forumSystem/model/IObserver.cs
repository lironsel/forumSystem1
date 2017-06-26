namespace forumSystem.model
{
    public interface IObserver
    {
        void notify(string data);
        string getName();
        string getUserName();
    }
}