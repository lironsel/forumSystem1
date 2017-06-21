using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    abstract class Guest : Visitor, Visited
    {
        public void accept(Visitor v)
        {
            v.visit(this);//to check
        }

        public abstract bool visit(Guest guest);
        public abstract bool visit(Moderator moderator);
        public abstract bool visit(User user);
        public abstract bool visit(Admin admin);
    }
}
