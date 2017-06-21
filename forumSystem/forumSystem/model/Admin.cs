using System.Collections.Generic;

namespace forumSystem.model
{
    public class Admin : User
    {
        List<Forum> admin;
        public Admin(string name, string password) : base(name, password) { }

        public override bool visit(Moderator moderator)
        {
            return false;
        }

        //public override bool visit(User user)
        //{
        //    return false;
        //}

        public override bool visit(Admin admin)
        {
            return false;
        }

        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
