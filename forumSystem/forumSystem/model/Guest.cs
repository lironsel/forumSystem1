namespace forumSystem.model
{
    public abstract class Guest : Visited, Visitor
    {
        public abstract void accept(Visitor v);
        public abstract bool visit(Moderator moderator);
        public abstract bool visit(User user);
        public abstract bool visit(Admin admin);
    }
}
