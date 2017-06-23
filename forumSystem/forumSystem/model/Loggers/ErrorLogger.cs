namespace forumSystem.model
{
    class ErrorLogger : Logger
    {
        Forum belong_to;
        
        public ErrorLogger(Forum forum) : base(forum.getName() + "_Error.txt")
        {
            belong_to = forum;
        }
    }
}
