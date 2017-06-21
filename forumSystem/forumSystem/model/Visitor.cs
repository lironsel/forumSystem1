using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    interface Visitor
    {
        bool visit(Admin admin);
        bool visit(User user);
        bool visit(Moderator moderator);
    }
}
