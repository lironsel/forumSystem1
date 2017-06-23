namespace forumSystem.model
{
    public abstract class AUser : Visited, Visitor, IObserver
    {
        public abstract void accept(Visitor v);
        public abstract bool visit(Moderator moderator);
        public abstract bool visit(User user);
        public abstract bool visit(Admin admin);
        public abstract string getName();
        public abstract void notify(string data);
    }
}
